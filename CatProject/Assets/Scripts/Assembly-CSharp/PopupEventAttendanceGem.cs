using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupEventAttendanceGem", false, false)]
public class PopupEventAttendanceGem : UIBase
{
	[SerializeField]
	private ItemAttendance ItemAttendance;

	[SerializeField]
	private Button ClaimButton;

	[SerializeField]
	private Text ReplaceGemCountText;

	private int ATTENDANCE_REPLACE_GEM_COUNT;

	private Action OnClaimedEvent;

	protected override void Awake()
	{
	}

	public void Init(E_AttendanceEventType eventType, int dayIndex, Action onClaimedEvent)
	{
	}

	private void OnClickClaimButton()
	{
	}
}
