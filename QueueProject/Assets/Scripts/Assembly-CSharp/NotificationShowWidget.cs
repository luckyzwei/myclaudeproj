using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NotificationShowWidget : MonoBehaviour
{
	private const float ANIM_DELAY = 2f;

	private const string ANIM_IDLE = "Idle";

	private const string ANIM_ALERT = "Alert";

	private const string ANIM_INTRO = "Intro";

	private const string ANIM_OUTRO = "Outro";

	[SerializeField]
	private List<string> m_notificationIds;

	[SerializeField]
	private Transform m_visualRoot;

	[SerializeField]
	private bool m_displayNumber;

	[SerializeField]
	private TextMeshProUGUI m_text;

	[SerializeField]
	private Image m_icon;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private bool m_animateOut;

	private bool m_itWasActive;

	private bool m_started;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void AddNotificationId(string notificationId)
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void ToggleNotificationVisuals()
	{
	}
}
