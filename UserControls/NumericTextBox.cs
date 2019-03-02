using System.Windows.Forms;
using UserControls.Utils;

namespace UserControls
{
	public partial class NumericTextBox : TextBox
	{	
		public NumericTextBox()
		{
			InitializeComponent();
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);

			if (!e.KeyChar.IsValidDigitValue())
			{
				e.Handled = true;
			}
		}
	}
}
