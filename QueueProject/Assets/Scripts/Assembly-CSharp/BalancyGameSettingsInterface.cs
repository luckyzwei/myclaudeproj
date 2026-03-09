using KWGameSettings;
using KWGameSettings.Balancy;

public class BalancyGameSettingsInterface : GameSettingsInterface, IGameSettings
{
	private BalancySettingsAdapter m_gameSettings;

	public override IGameSettings GetGameSettingsServer()
	{
		return null;
	}

	public void Initialise(GameSettingsInterface settingsInterface)
	{
	}

	private void OnGameSettingsUpdated()
	{
	}

	public void DoOnApplicationPause(bool isPaused)
	{
	}

	public override bool HasSettings()
	{
		return false;
	}

	public GameSettings GetGameSettings()
	{
		return null;
	}
}
