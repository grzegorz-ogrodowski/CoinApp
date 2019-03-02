using System;
using System.Globalization;
using System.Text;
using Core;
using Generating.Configuation;
using static System.Decimal;
using static System.Int32;

namespace CinkciarzCoinApp.Utils
{
	internal static class ValidationHelper
	{
		internal static GeneratorConfiguration PrepareConfiguration(string maxSpread, string delay, string avgRate, out string errorMessage)
		{
			var result = true;
			errorMessage = "";

			int delayTmp;
			decimal maxSpreadTmp;
			decimal avgRateTmp;

			var errorsBuilder = new StringBuilder();

			if (!ValidatePositiveInteger(delay, out delayTmp))
			{
				result = false;
				errorsBuilder.AppendFormat("Delay is not positive integer.");
			}

			if (!ValidatePositiveDecimal(maxSpread, out maxSpreadTmp))
			{
				if (!result)
				{
					errorsBuilder.Append(" "); //For better message formatting
				}

				result = false;			

				errorsBuilder.AppendFormat("Max spread is not positive decimal.");
			}
			else
			{
				if (!ValidateFractionalPart(maxSpreadTmp))
				{
					if (!result)
					{
						errorsBuilder.Append(" "); //For better message formatting
					}

					result = false;

					errorsBuilder.AppendFormat("Max spread should have maximum four fractional digits");
				}
			}

			if (!ValidatePositiveDecimal(avgRate, out avgRateTmp))
			{
				if (!result)
				{
					errorsBuilder.Append(" "); //For better message formatting
				}

				result = false;
				errorsBuilder.AppendFormat("Average rate is not positive decimal.");
			}
			else
			{
				if (!ValidateFractionalPart(avgRateTmp))
				{
					if (!result)
					{
						errorsBuilder.Append(" "); //For better message formatting
					}

					result = false;

					errorsBuilder.AppendFormat("Average rate should have maximum four fractional digits");
				}
			}

			if (result)
			{
				return new GeneratorConfiguration()
				{
					AverageRate = avgRateTmp,
					Delay = delayTmp,
					MaxSpread = maxSpreadTmp
				};
			}

			errorMessage = errorsBuilder.ToString();
			return null;
		}

		private static bool ValidatePositiveInteger(string value, out int intValue)
		{
			return TryParse(value, out intValue) && intValue > 0;
		}

		private static bool ValidatePositiveDecimal(string value, out decimal decimalValue)
		{
			return TryParse(value, NumberStyles.AllowDecimalPoint, Constants.UsedCultureInfo, out decimalValue) && decimalValue > 0;
		}

		private static bool ValidateFractionalPart(decimal value)
		{
			int count = BitConverter.GetBytes(decimal.GetBits(value)[3])[2];
			return count <= 4;
		}
	}
}
