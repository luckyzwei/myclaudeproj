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
	}

	public void Set(int factory, int idx)
	{
	}

	public void UpdateFactoryLevel()
	{
	}

	public void SetSelect(bool value)
	{
	}

	public void ReadyToUnlock()
	{
	}

	public void PlayUnlock()
	{
	}

	[IteratorStateMachine(typeof(_003COnFinishUnlock_003Ed__29))]
	private IEnumerator OnFinishUnlock()
	{
		yield break;
	}

	private void OnClickBtn()
	{
	}

	private void OnClickUnLock()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
