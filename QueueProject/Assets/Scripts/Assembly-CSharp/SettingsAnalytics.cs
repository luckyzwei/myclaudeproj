using UnityEngine;

public class SettingsAnalytics : MonoBehaviour
{
	private const string EVENT_NAME = "kpf_setting_menu_end";

	[SerializeField]
	private string m_openContext;

	private bool m_settingChanged;

	private SettingsDataPacket m_settingsDataPacket;

	private void Start()
	{
	}

	public void SettingsClose(string context)
	{
	}

	public void OnSettingChanged()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public void SendSettingsMenuClosedEvent(string closeContext)
	{
	}
}
