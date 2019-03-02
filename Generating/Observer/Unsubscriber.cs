using System;
using System.Collections.Generic;
using Objects;

namespace Generating.Observer
{
	internal class Unsubscriber : IDisposable
	{
		private readonly List<IObserver<ExchangeRateEntity>> _observers;
		private readonly IObserver<ExchangeRateEntity> _observer;

		public Unsubscriber(List<IObserver<ExchangeRateEntity>> observers, IObserver<ExchangeRateEntity> observer)
		{
			_observers = observers;
			_observer = observer;
		}

		public void Dispose()
		{
			if (_observer != null)
			{
				_observers.Remove(_observer);
			}
		}
	}
}
