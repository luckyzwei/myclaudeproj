using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class OnetimeCurrencyComponent : MonoBehaviour
{
	private enum OneTimeEventCurrencyType
	{
		none = 0,
		office = 1,
		ad = 2,
		todo = 3
	}

	[CompilerGenerated]
	private sealed class _003CWaitHUD_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<Vector3> waitCb;

		private HUDTotal _003Chud_003E5__2;

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
		public _003CWaitHUD_003Ed__33(int _003C_003E1__state)
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

	[Header("[OnetimeCurrencyComponent]")]
	[SerializeField]
	private GameObject rootObj;

	[SerializeField]
	private OneTimeEventCurrencyType type;

	[SerializeField]
	private Text currencyText;

	[SerializeField]
	private Image currencyIcon;

	[Header("[UI]")]
	[SerializeField]
	private GameObject oneTimeUIRoot;

	[SerializeField]
	private Button oneTimeBtn;

	[SerializeField]
	private Image oneTimeIcon;

	[SerializeField]
	private Text oneTimeRemainTime;

	[SerializeField]
	private Image oneTimeCurrencyIcon;

	[SerializeField]
	private Text oneTimeCurrencyCount;

	[SerializeField]
	private GameObject oneTimeReddot;

	private int curCurrency;

	private Dictionary<int, int> itemLevelCurrency;

	private bool isMaxLevel;

	private bool isActive;

	private CompositeDisposable disposables;

	public Image OneTimeCurrencyIcon => null;

	public int CurCurrency => 0;

	public bool IsActive => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void Init()
	{
	}

	private void SubscribeComponent()
	{
	}

	private void UpdateOneTimeHUDIcon()
	{
	}

	private void UpdateCurrencyIcon()
	{
	}

	public void UpdateCompanyResetCount()
	{
	}

	public void UpdateReddot()
	{
	}

	public void UpdateCurrencyCount()
	{
	}

	private void UpdateRemainTime()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitHUD_003Ed__33))]
	private IEnumerator WaitHUD(Action<Vector3> waitCb)
	{
		return null;
	}

	public void ShowOneTimeGetEffectHUD(Vector3 startPos)
	{
	}

	public void ShowOneTimeGetEffectTarget(Vector3 startPos, Vector3 endPos, Action endCb = null)
	{
	}

	public void ShowOneTimeGetEffectTargetOffice(int count, Vector3 startPos, Vector3 endPos, Action endCb = null)
	{
	}

	public int GetOneTimeOfficeCount(int level)
	{
		return 0;
	}

	private void OnClickOneTime()
	{
	}

	private void Unscribe()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
