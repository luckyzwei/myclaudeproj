using UnityEngine;

namespace KPFCore
{
	public abstract class InitialiserBase : MonoBehaviour, IInitialiser
	{
		public void Initialise(MasterConfig masterConfig)
		{
		}

		protected abstract void InitialiseLocal(MasterConfig masterConfig);

		protected abstract void RegisterConfigs();

		protected abstract void RegisterDefaultAdapters();
	}
}
