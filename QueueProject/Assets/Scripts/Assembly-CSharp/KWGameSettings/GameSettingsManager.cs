namespace KWGameSettings
{
	public class GameSettingsManager
	{
		private IGameSettings m_gameSettings;

		private GameSettingsInterface m_gameSettingsInterface;

		public void Initialise(GameSettingsInterface settingsInterface)
		{
		}

		public GameSettings GetGameSettings()
		{
			return null;
		}

		public bool HasSettings()
		{
			return false;
		}

		public void DoOnApplicationPause(bool isPaused)
		{
		}
	}
}
