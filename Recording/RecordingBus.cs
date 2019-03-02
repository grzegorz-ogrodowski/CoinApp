using System.Collections.Generic;
using Objects;
using Recording.StoreManager.Interfaces;

namespace Recording
{
	public class RecordingBus
	{
		private readonly IStoreManager _storeManager;

		public RecordingBus(IStoreManager storeManager)
		{
			_storeManager = storeManager;
		}

		public void Save(IEnumerable<ExchangeRateEntity> records, string filePath)
		{
			_storeManager.SaveRecords(records, filePath);
		}
	}
}
