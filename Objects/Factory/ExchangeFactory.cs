using System;

namespace Objects.Factory
{
	public static class ExchangeFactory
	{
		public static ExchangeRateEntity CreateInstace(decimal maxSpread, decimal averageRate)
		{
			var rateEntity = new ExchangeRateEntity()
			{
				AverageRate = averageRate
			};

			var spreadToUse = maxSpread;

			var rng = new Random();

			var tempSpread = GenerateDecimalValue(rng, spreadToUse);
			spreadToUse -= tempSpread;

			rateEntity.BuyingRate = averageRate + tempSpread;

			tempSpread = GenerateDecimalValue(rng, spreadToUse);
			rateEntity.SellingRate = averageRate - tempSpread;

			return rateEntity;
		}

		private static decimal GenerateDecimalValue(Random rng, decimal maxSpread)
		{
			while (true)
			{
				const int precision = 4;
				decimal currentValue = 0;

				for (var i = 0; i <= precision; i++)
				{
					var r = rng.Next(0, 10);
					currentValue = currentValue * 10m + r;
				}

				for (var s = 0; s < precision; s++)
				{
					currentValue /= 10m;
				}

				if (currentValue > maxSpread)
				{
					continue;
				}

				return currentValue;
			}
		}
	}
}
