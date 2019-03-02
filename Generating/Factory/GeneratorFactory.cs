using System;
using Objects;

namespace Generating.Factory
{
	public static class GeneratorFactory
	{
		public static  GenerateExchangeRate CreateInstance(IObserver<ExchangeRateEntity> observer)
		{
			var instance = new GenerateExchangeRate();

			instance.Subscribe(observer);

			return instance;
		}
	}
}
