using System;
using KWCore.UI;

namespace KWCore.Network
{
	public class NetworkSettingsManager
	{
		private NetworkSettings m_settings;

		private CoreUI.IDelegate m_delegate;

		public NetworkSettings Settings => null;

		public void Initialise(CoreUI.IDelegate del)
		{
		}

		public bool IsInAirplaneMode()
		{
			return false;
		}

		public bool CheckCanPlay(Action closeCallback)
		{
			return false;
		}
	}
}
