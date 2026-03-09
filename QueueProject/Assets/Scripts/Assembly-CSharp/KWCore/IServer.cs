using KWCore.Utils;

namespace KWCore
{
	public interface IServer
	{
		void Initialise(ServerInterface serverInterface, DeviceSettingsManager deviceSettingsManager = null);

		void DoOnApplicationPause(bool isPaused);

		void DoOnApplicationQuit();
	}
}
