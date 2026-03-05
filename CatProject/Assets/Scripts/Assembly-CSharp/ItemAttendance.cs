using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ItemAttendance : MonoBehaviour
{
	private enum E_AttendanceState
	{
		None = 0,
		Possible = 1,
		Rewarded = 2,
		Passed = 3
	}

	[CompilerGenerated]
	private sealed class _003CProcessRewardWithDelay_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RewardItemData rewardItemData;

		public ItemAttendance _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CProcessRewardWithDelay_003Ed__22(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private Text DayText;

	[SerializeField]
	private List<Image> RewardItemIcon;

	[SerializeField]
	private Text RewardItemCountText;

	[SerializeField]
	private Button ClaimButton;

	[SerializeField]
	private GameObject AttendancePossibleObj;

	[SerializeField]
	private GameObject AttendanceRewardedObj;

	[SerializeField]
	private GameObject AttendancePassedObj;

	private E_AttendanceEventType EventType;

	private int DayIndex;

	private E_AttendanceState CurAttendanceState;

	private const string DAY_FORMAT_KEY = "str_birthday_attendance_day";

	private const string REWARD_COUNT_PREFIX = "x";

	public void Awake()
	{
		if (ClaimButton != null)
			ClaimButton.onClick.AddListener(OnClickClaimButton);
	}

	public void Init(AttendanceData attData)
	{
		if (attData == null) return;
		DayIndex = attData.DayIndex;
		EventType = (E_AttendanceEventType)attData.EventType;
		UpdateUIText(attData);
		UpdateRewardIcon(attData);
		UpdateAttendanceState(attData);
	}

	private void UpdateUIText(AttendanceData attData)
	{
		if (DayText != null)
			DayText.text = "Day " + (attData.DayIndex + 1);
		if (RewardItemCountText != null && attData.RewardItemData != null)
			RewardItemCountText.text = REWARD_COUNT_PREFIX + attData.RewardItemData.RewardValue;
	}

	private void UpdateRewardIcon(AttendanceData attData)
	{
		// Set reward icon from AttendanceData.RewardItemData
	}

	private void UpdateAttendanceState(AttendanceData attData)
	{
		if (attData.IsAttended != null && attData.IsAttended.Value)
			UpdateAttendanceState(E_AttendanceState.Rewarded);
		else if (DateTime.UtcNow >= attData.AttendanceStartTime && DateTime.UtcNow < attData.AttendanceEndTime)
			UpdateAttendanceState(E_AttendanceState.Possible);
		else if (DateTime.UtcNow >= attData.AttendanceEndTime)
			UpdateAttendanceState(E_AttendanceState.Passed);
		else
			UpdateAttendanceState(E_AttendanceState.None);
	}

	private void UpdateAttendanceState(E_AttendanceState state)
	{
		CurAttendanceState = state;
		if (AttendancePossibleObj != null) AttendancePossibleObj.SetActive(state == E_AttendanceState.Possible);
		if (AttendanceRewardedObj != null) AttendanceRewardedObj.SetActive(state == E_AttendanceState.Rewarded);
		if (AttendancePassedObj != null) AttendancePassedObj.SetActive(state == E_AttendanceState.Passed);
		if (ClaimButton != null) ClaimButton.gameObject.SetActive(state == E_AttendanceState.Possible);
	}

	private void OnClickClaimButton()
	{
		if (CurAttendanceState != E_AttendanceState.Possible) return;
		// Claim attendance reward
	}

	private void PassedAttendanceClaim()
	{
		UpdateAttendanceState(E_AttendanceState.Passed);
	}

	private void ClaimReward(RewardItemData rewardItemData)
	{
		if (rewardItemData == null) return;
		StartCoroutine(ProcessRewardWithDelay(rewardItemData));
	}

	[IteratorStateMachine(typeof(_003CProcessRewardWithDelay_003Ed__22))]
	private IEnumerator ProcessRewardWithDelay(RewardItemData rewardItemData)
	{
		yield return new WaitForSeconds(0.3f);
		UpdateAttendanceState(E_AttendanceState.Rewarded);
	}
}
