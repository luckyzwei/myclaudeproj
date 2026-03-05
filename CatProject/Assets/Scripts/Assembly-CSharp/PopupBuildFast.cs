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
		base.Awake();
		disposables = new CompositeDisposable();
		AutoConsumeCash = false;

		if (Btn != null) Btn.onClick.AddListener(OnClickSkip);
	}

	public override void OnHideBefore()
	{
		StopAllCoroutines();
	}

	public void Set(int office)
	{
		OfficeIdx = office;
		FactoryIdx = -1;
		SeasonalBuildingIdx = -1;
	}

	public void SetFactory(int factory)
	{
		FactoryIdx = factory;
		OfficeIdx = -1;
		SeasonalBuildingIdx = -1;
	}

	public void SetSeasonal(int buildingIdx, int targetBuildingLevel)
	{
		SeasonalBuildingIdx = buildingIdx;
		SeasonalTargetBuildingLevel = targetBuildingLevel;
		OfficeIdx = -1;
		FactoryIdx = -1;
	}

	public void SetTimer(DateTime endDateTime, int totalBuildTime, bool bConsumeCash, UnityAction clickedAction)
	{
		EndDateTime = endDateTime;
		BuildTime = totalBuildTime;
		AutoConsumeCash = bConsumeCash;
		OnConfirmedFastOpen = clickedAction;

		if (CashText != null) CashText.text = NeedCash.ToString();

		StartCoroutine(UpdateTimer());
	}

	[IteratorStateMachine(typeof(_003CUpdateTimer_003Ed__20))]
	private IEnumerator UpdateTimer()
	{
		while (true)
		{
			int remainSec = (int)(EndDateTime - DateTime.UtcNow).TotalSeconds;
			if (remainSec <= 0)
			{
				Hide();
				yield break;
			}
			UpdateRemainTime(remainSec);
			yield return new WaitForSeconds(1f);
		}
	}

	public void UpdateRemainTime(int remainTimeSec)
	{
		if (RemainTime != null) RemainTime.text = ProjectUtility.GetTimeStringFormattingShort(remainTimeSec);
		if (Progress != null && BuildTime > 0)
		{
			float ratio = 1f - (float)remainTimeSec / (float)BuildTime;
			Progress.value = Mathf.Clamp01(ratio);
		}
	}

	private void UpdateFactoryRemainTime(int remainTime)
	{
		UpdateRemainTime(remainTime);
	}

	private void OnClickSkip()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		// Consume cash to skip build time
		OnConfirmedFastOpen?.Invoke();
		Hide();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
