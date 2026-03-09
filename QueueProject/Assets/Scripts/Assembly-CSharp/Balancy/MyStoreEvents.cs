using Balancy.Interfaces;
using Balancy.Models.LiveOps.Store;
using Balancy.Models.SmartObjects;

namespace Balancy
{
	public class MyStoreEvents : IStoreEvents
	{
		public void OnStoreResourcesMultiplierChanged(float multiplier)
		{
		}

		public void OnStoreUpdated(GameStoreBase storeConfig)
		{
		}

		public void OnStorePageUpdated(GameStoreBase storeConfig, Page page)
		{
		}
	}
}
