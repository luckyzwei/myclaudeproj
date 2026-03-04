using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupBuildFast", false, false)]
public class PopupBuildFast : UIBase
{
	[CompilerGenerated]
	private sealed class _003CUpdateTimer_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupBuildFast _003C_003E4__this;

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
		public _003CUpdateTimer_003Ed__20(int _003C_003E1__state)
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
	private Button Btn;

	[SerializeField]
	private Text CashText;

	[SerializeField]
	private Slider Progress;

	[SerializeField]
	private Text RemainTime;

	private int NeedCash;

	private CompositeDisposable disposables;

	private bool AutoConsumeCash;

	private int OfficeIdx;

	private int FactoryIdx;

	private int SeasonalBuildingIdx;

	private int SeasonalTargetBuildingLevel;

	private int BuildTime;

	private DateTime EndDateTime;

	public UnityAction OnConfirmedFastOpen;

	protected override void Awake()
	{
	}

	public override void OnHideBefore()
	{
	}

	public void Set(int office)
	{
	}

	public void SetFactory(int factory)
	{
	}

	public void SetSeasonal(int buildingIdx, int targetBuildingLevel)
	{
	}

	public void SetTimer(DateTime endDateTime, int totalBuildTime, bool bConsumeCash, UnityAction clickedAction)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateTimer_003Ed__20))]
	private IEnumerator UpdateTimer()
	{
		yield break;
	}

	public void UpdateRemainTime(int remainTimeSec)
	{
	}

	private void UpdateFactoryRemainTime(int remainTime)
	{
	}

	private void OnClickSkip()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
