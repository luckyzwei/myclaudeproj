using KPFCore;
using UnityEngine;

namespace KWPlayerProfile
{
	public class PlayerProfileInitialiser : InitialiserBase
	{
		[SerializeField]
		protected PlayerProfileConfig m_defaultConfig;

		protected override void InitialiseLocal(MasterConfig masterConfig)
		{
		}

		protected override void RegisterConfigs()
		{
		}

		protected override void RegisterDefaultAdapters()
		{
		}
	}
}
