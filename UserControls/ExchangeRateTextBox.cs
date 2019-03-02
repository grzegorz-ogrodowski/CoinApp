using System.Windows.Forms;
using UserControls.Utils;

namespace UserControls
{
	public partial class ExchangeRateTextBox : TextBox
	{
		public ExchangeRateTextBox()
		{
			InitializeComponent();
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);

			if (!e.KeyChar.IsValidDecimalValue())
			{
				e.Handled = true;
			}
		}
	}
}
