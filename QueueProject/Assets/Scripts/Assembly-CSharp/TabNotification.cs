using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TabNotification : MonoBehaviour
{
	[SerializeField]
	private TabToolbarButton m_tab;

	[SerializeField]
	private GameObject m_notificationObject;

	[SerializeField]
	private Text m_text;

	private List<bool> m_notifications;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnTabChange(int tabIndex, bool immediately)
	{
	}

	private void OnAddNotification(int tab, bool sticky)
	{
	}

	private void OnClearNotification(int tab)
	{
	}

	private void SetNotificationActive(bool enable)
	{
	}
}
