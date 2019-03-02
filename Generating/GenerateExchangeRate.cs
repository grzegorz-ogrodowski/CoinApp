using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Generating.Configuation;
using Generating.Observer;
using Objects;
using Objects.Factory;

namespace Generating
{
	public class GenerateExchangeRate : IObservable<ExchangeRateEntity>
	{
		private CancellationTokenSource _cancellationTokenSource;
		private readonly List<IObserver<ExchangeRateEntity>> _observers;
		private GeneratorConfiguration _configuration;
		private bool _isTaskRun;

		public GenerateExchangeRate()
		{
			RefreshToken();
			_observers = new List<IObserver<ExchangeRateEntity>>();
			_configuration = new GeneratorConfiguration();
		}

		public IDisposable Subscribe(IObserver<ExchangeRateEntity> observer)
		{
			if (!_observers.Contains(observer))
			{
				_observers.Add(observer);
			}

			return new Unsubscriber(_observers, observer);
		}

		public void Stop()
		{
			_cancellationTokenSource.Cancel();
			_isTaskRun = false;
		}

		public async Task Generate(GeneratorConfiguration configuration)
		{
			_isTaskRun = true;

			Refresh(configuration);

			await GenerateExchange();

			RaiseOnCompleted();
		}

		private void RaiseOnCompleted()
		{
			foreach (var observer in _observers)
			{
				observer.OnCompleted();
			}
		}

		private async Task GenerateExchange()
		{
			while (!_cancellationTokenSource.IsCancellationRequested)
			{
				var instance = ExchangeFactory.CreateInstace(_configuration.MaxSpread, _configuration.AverageRate);

				foreach (var observer in _observers)
				{
					observer.OnNext(instance);
				}

				await Task.Delay(_configuration.Delay, _cancellationTokenSource.Token);
			}
		}

		private void Refresh(GeneratorConfiguration configuration)
		{
			RefreshToken();
			_configuration = configuration;
		}

		private void RefreshToken()
		{
			_cancellationTokenSource = new CancellationTokenSource();
		}

		public void RefreshConfiguration(GeneratorConfiguration configuration)
		{
			_configuration = configuration;

			if (_isTaskRun)
			{
				_cancellationTokenSource.Cancel();

				//Await is not use because generate exchange rate process should run as asynchrounous 
				Generate(configuration);
			}
		}
	}
}
