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
			get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CWaitHUD_003Ed__33(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
				case 0:
					_003C_003E1__state = -1;
					// Wait for HUD to be available, then call waitCb with target position
					waitCb?.Invoke(Vector3.zero);
					return false;
				default:
					return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
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

	public Image OneTimeCurrencyIcon { get { return oneTimeCurrencyIcon; } }

	public int CurCurrency { get { return curCurrency; } }

	public bool IsActive { get { return isActive; } }

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (oneTimeBtn != null)
			oneTimeBtn.onClick.AddListener(OnClickOneTime);
		itemLevelCurrency = new Dictionary<int, int>();
	}

	private void OnEnable()
	{
		UpdateCurrencyCount();
		UpdateReddot();
	}

	public void Init()
	{
		isActive = false;
		isMaxLevel = false;
		curCurrency = 0;
		UpdateOneTimeHUDIcon();
		UpdateCurrencyIcon();
		SubscribeComponent();
	}

	private void SubscribeComponent()
	{
		if (disposables != null) disposables.Clear();
		// Subscriptions to OneTimeEventSystem currency changes go here
	}

	private void UpdateOneTimeHUDIcon()
	{
		if (oneTimeUIRoot != null) oneTimeUIRoot.SetActive(isActive);
	}

	private void UpdateCurrencyIcon()
	{
		if (rootObj != null) rootObj.SetActive(isActive);
	}

	public void UpdateCompanyResetCount()
	{
		UpdateCurrencyCount();
	}

	public void UpdateReddot()
	{
		if (oneTimeReddot != null)
			oneTimeReddot.SetActive(false);
	}

	public void UpdateCurrencyCount()
	{
		if (oneTimeCurrencyCount != null)
			oneTimeCurrencyCount.text = curCurrency.ToString();
	}

	private void UpdateRemainTime()
	{
		if (oneTimeRemainTime == null) return;
		oneTimeRemainTime.text = "";
	}

	[IteratorStateMachine(typeof(_003CWaitHUD_003Ed__33))]
	private IEnumerator WaitHUD(Action<Vector3> waitCb)
	{
		var d = new _003CWaitHUD_003Ed__33(0);
		d.waitCb = waitCb;
		return d;
	}

	public void ShowOneTimeGetEffectHUD(Vector3 startPos)
	{
		StartCoroutine(WaitHUD((endPos) =>
		{
			ShowOneTimeGetEffectTarget(startPos, endPos);
		}));
	}

	public void ShowOneTimeGetEffectTarget(Vector3 startPos, Vector3 endPos, Action endCb = null)
	{
		// Show currency fly effect from startPos to endPos
		endCb?.Invoke();
	}

	public void ShowOneTimeGetEffectTargetOffice(int count, Vector3 startPos, Vector3 endPos, Action endCb = null)
	{
		// Show multiple currency fly effects for office rewards
		endCb?.Invoke();
	}

	public int GetOneTimeOfficeCount(int level)
	{
		if (itemLevelCurrency != null && itemLevelCurrency.TryGetValue(level, out int count))
			return count;
		return 1;
	}

	private void OnClickOneTime()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupOneTimeEventOpen>();
	}

	private void Unscribe()
	{
		if (disposables != null)
			disposables.Clear();
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}

	private void OnDisable()
	{
		Unscribe();
	}
}
