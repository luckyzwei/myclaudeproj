namespace KWGameSettings
{
	public interface IGameSettings
	{
		void Initialise(GameSettingsInterface settingsInterface);

		void DoOnApplicationPause(bool isPaused);

		GameSettings GetGameSettings();
	}
}
