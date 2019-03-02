using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Core;
using Objects;
using Recording.StoreManager.Interfaces;
using Recording.Utils;

namespace Recording.StoreManager.CSV
{
	public class CSVStoreManager : IStoreManager
	{
		public void SaveRecords(IEnumerable<ExchangeRateEntity> records, string filePath)
		{
			var csvBuilder = new StringBuilder();

			if (records == null || !records.Any())
			{
				throw new ArgumentNullException(nameof(records), "There is no records to save!");
			}

			csvBuilder.AppendWithSeparator("Exchange date");
			csvBuilder.AppendWithSeparator("Buying rate");
			csvBuilder.AppendWithSeparator("Selling rate");
			csvBuilder.AppendLine();

			foreach (var record in records)
			{
				csvBuilder.AppendWithSeparator(record.ExchangeRateDateTime.ToString(Constants.DateTimeFormat));
				csvBuilder.AppendWithSeparator(record.BuyingRate.ToString(Constants.ExchangeRateFormat, Constants.UsedCultureInfo));
				csvBuilder.AppendWithSeparator(record.SellingRate.ToString(Constants.ExchangeRateFormat, Constants.UsedCultureInfo));
				csvBuilder.AppendLine();
			}

			try
			{
				File.WriteAllText(filePath, csvBuilder.ToString());
			}
			catch (Exception ex)
			{
				throw new Exception("Error during save records: ", ex);
			}
		}
	}
}
