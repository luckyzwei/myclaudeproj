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
	}

	public void Init(AttendanceData attData)
	{
	}

	private void UpdateUIText(AttendanceData attData)
	{
	}

	private void UpdateRewardIcon(AttendanceData attData)
	{
	}

	private void UpdateAttendanceState(AttendanceData attData)
	{
	}

	private void UpdateAttendanceState(E_AttendanceState state)
	{
	}

	private void OnClickClaimButton()
	{
	}

	private void PassedAttendanceClaim()
	{
	}

	private void ClaimReward(RewardItemData rewardItemData)
	{
	}

	[IteratorStateMachine(typeof(_003CProcessRewardWithDelay_003Ed__22))]
	private IEnumerator ProcessRewardWithDelay(RewardItemData rewardItemData)
	{
		yield break;
	}
}
