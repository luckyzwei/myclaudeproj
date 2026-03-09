using System.Collections.Generic;
using KWCore.Utils;

namespace KWCore
{
	public class ServerManager
	{
		private readonly List<IServer> m_servers;

		public void RegisterServerInterface(ServerInterface serverInterface, DeviceSettingsManager deviceSettingsManager = null)
		{
		}

		public void DoOnApplicationPause(bool paused)
		{
		}

		public void DoOnApplicationQuit()
		{
		}
	}
}
