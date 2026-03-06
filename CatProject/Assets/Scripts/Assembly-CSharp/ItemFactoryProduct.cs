using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemFactoryProduct : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COnFinishUnlock_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemFactoryProduct _003C_003E4__this;

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
		public _003COnFinishUnlock_003Ed__29(int _003C_003E1__state)
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
	private GameObject Lock;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Image LockIcon;

	[SerializeField]
	private Text Count;

	[SerializeField]
	private Text ProductionTime;

	[SerializeField]
	private GameObject SelectObj;

	[SerializeField]
	private Text UnLockLevel;

	[SerializeField]
	private Button UnLockBtn;

	[SerializeField]
	private Animator UnlockAnimator;

	private int FactoryIdx;

	private bool IsLock;

	private CompositeDisposable disposables;

	public Action<int> ClickCb;

	public Action GotoUnLockCb;

	public int ProductIdx { get; private set; }

	public bool IsReadyToUnlock { get; private set; }

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (Btn != null) Btn.onClick.AddListener(OnClickBtn);
		if (UnLockBtn != null) UnLockBtn.onClick.AddListener(OnClickUnLock);
	}

	public void Set(int factory, int idx)
	{
		FactoryIdx = factory;
		ProductIdx = idx;
		IsLock = false;
		IsReadyToUnlock = false;
		if (SelectObj != null) SelectObj.SetActive(false);
		if (Lock != null) Lock.SetActive(false);
		UpdateFactoryLevel();
	}

	public void UpdateFactoryLevel()
	{
		// Update product icon and production time from factory data
		if (Icon != null)
		{
			// Set product icon
		}
		if (Count != null) Count.text = "";
		if (ProductionTime != null) ProductionTime.text = "";
	}

	public void SetSelect(bool value)
	{
		if (SelectObj != null) SelectObj.SetActive(value);
	}

	public void ReadyToUnlock()
	{
		IsReadyToUnlock = true;
		IsLock = true;
		if (Lock != null) Lock.SetActive(true);
		if (UnLockBtn != null) UnLockBtn.gameObject.SetActive(true);
	}

	public void PlayUnlock()
	{
		IsReadyToUnlock = false;
		IsLock = false;
		if (UnlockAnimator != null)
		{
			UnlockAnimator.gameObject.SetActive(true);
			UnlockAnimator.SetTrigger("Unlock");
		}
		StartCoroutine(OnFinishUnlock());
	}

	[IteratorStateMachine(typeof(_003COnFinishUnlock_003Ed__29))]
	private IEnumerator OnFinishUnlock()
	{
		yield return new WaitForSeconds(1f);
		if (Lock != null) Lock.SetActive(false);
		if (UnlockAnimator != null) UnlockAnimator.gameObject.SetActive(false);
		UpdateFactoryLevel();
	}

	private void OnClickBtn()
	{
		if (IsLock) return;
		ClickCb?.Invoke(ProductIdx);
	}

	private void OnClickUnLock()
	{
		GotoUnLockCb?.Invoke();
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
