using System.Collections.Generic;
using Objects;

namespace Recording.StoreManager.Interfaces
{
	public interface IStoreManager
	{
		void SaveRecords(IEnumerable<ExchangeRateEntity> records, string filePath);
	}
}
