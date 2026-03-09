using System.Collections.Generic;
using UnityEngine;

public class NotificationSwallowWidget : MonoBehaviour
{
	[Header("Include me in a button")]
	[SerializeField]
	private List<SwallowData> m_notificationIds;

	public void AddNotificationId(string notificationId, bool swallowAll = false)
	{
	}

	private void Awake()
	{
	}

	private void OnButtonClick()
	{
	}
}
