using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CinkciarzCoinApp.Utils;
using Core;
using Generating;
using Generating.Configuation;
using Generating.Factory;
using Objects;
using Recording;
using Recording.StoreManager.CSV;

namespace CinkciarzCoinApp
{
	public partial class MainForm : Form, IObserver<ExchangeRateEntity>
	{
		private readonly List<ExchangeRateEntity> _records;
		private readonly GenerateExchangeRate _generator;
		private GeneratorConfiguration _generatorConfiguration;
		private bool _shouldDataBeRecorded;
		private readonly RecordingBus _recordingBus;

		public MainForm()
		{
			InitializeComponent();
			_records = new List<ExchangeRateEntity>();
			_generator = GeneratorFactory.CreateInstance(this);
			_shouldDataBeRecorded = false;
			_recordingBus = new RecordingBus(new CSVStoreManager());
		}

		private void btnStartGenerate_Click(object sender, EventArgs e)
		{
			if (PrepareConfiguration(out _generatorConfiguration))
			{
				SetGenerateButtonsStatus(false);
				btnStartRecording.Enabled = true;
				//Await is not use because generate exchange rate process should run as asynchrounous 
				_generator.Generate(_generatorConfiguration);
			}
		}

		private void btnStopGenerate_Click(object sender, EventArgs e)
		{
			SetGenerateButtonsStatus(true);
			_generator.Stop();
		}

		private void btnStartRecording_Click(object sender, EventArgs e)
		{
			SetRecordingButtonsStatus(false, false);
			_shouldDataBeRecorded = true;
		}

		private void btnStopRecording_Click(object sender, EventArgs e)
		{
			SetRecordingButtonsStatus(true, true);
			_shouldDataBeRecorded = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				var filePath = saveFileDialog.FileName;
				_recordingBus.Save(_records, filePath);
				_records.Clear();
				MessageBox.Show("File has been saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void SetGenerateButtonsStatus(bool shouldEnableStart)
		{
			btnStartGenerate.Enabled = shouldEnableStart;
			btnStopGenerate.Enabled = !shouldEnableStart;
		}

		private void SetRecordingButtonsStatus(bool shouldEnableStart, bool shouldEnableSave)
		{
			btnStartRecording.Enabled = shouldEnableStart;
			btnStopRecording.Enabled = !shouldEnableStart;
			btnSave.Enabled = shouldEnableSave;
		}

		private void btnApplyConfiguration_Click(object sender, EventArgs e)
		{
			GeneratorConfiguration configuration;
			if (PrepareConfiguration(out configuration))
			{
				_generatorConfiguration = configuration;
				RefreshConfiguration();
			}
		}

		private void RefreshConfiguration()
		{
			_generator.RefreshConfiguration(_generatorConfiguration);
		}

		public void OnNext(ExchangeRateEntity value)
		{
			if (_shouldDataBeRecorded)
			{
				_records.Add(value);
			}

			RefreshLabels(value);
		}

		public void OnError(Exception error)
		{
			throw error;
		}

		public void OnCompleted()
		{
			MessageBox.Show("Generate process has stopped");
		}

		private void RefreshLabels(ExchangeRateEntity value)
		{
			lblBuyingRate.Text = value.BuyingRate.ToString(Constants.ExchangeRateFormat, Constants.UsedCultureInfo);
			lblSellingRate.Text = value.SellingRate.ToString(Constants.ExchangeRateFormat, Constants.UsedCultureInfo);
			lblCurrentSpread.Text = value.CurrentSpread.ToString(Constants.ExchangeRateFormat, Constants.UsedCultureInfo);

			var refresh = 1000 / _generatorConfiguration.Delay;
			lblRefresh.Text = refresh.ToString();
		}

		private bool PrepareConfiguration(out GeneratorConfiguration configuration)
		{
			var delay = tbxRefresh.Text;
			var maxSpread = tbxMaxSpread.Text;
			var avgRate = tbxAvgExchangeRate.Text;
			string errorMessage;

			configuration = ValidationHelper.PrepareConfiguration(maxSpread, delay, avgRate, out errorMessage);

			if (!string.IsNullOrWhiteSpace(errorMessage))
			{
				MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return configuration != null;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();

			if (_records.Any())
			{
				var dialogResult = MessageBox.Show("There is some records unsaved. Do you want lose these data and close application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				e.Cancel = dialogResult != DialogResult.Yes;
			}
		}
	}
}
