using UnityEngine;
using UnityEngine.UI;

public class WidgetPassiveNotification : MonoBehaviour
{
	[SerializeField]
	private Text m_message;

	[SerializeField]
	private Image m_icon;

	public void Configure(string key, bool showIcon)
	{
	}

	public void KillMe()
	{
	}
}
