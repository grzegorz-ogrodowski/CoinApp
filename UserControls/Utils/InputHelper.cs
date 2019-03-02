using static System.Char;

namespace UserControls.Utils
{
	internal static class InputHelper
	{
		private const char BackspaceKeyChar = '\b';
		private const char DecimalSeparator = ',';
		internal static bool IsValidDigitValue(this char value)
		{
			return (IsDigit(value) || value == BackspaceKeyChar);
		}

		internal static bool IsValidDecimalValue(this char value)
		{
			return (value.IsValidDigitValue() || value == DecimalSeparator);
		}
	}
}
