using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InGameFactory : OutGameMode
{
	[CompilerGenerated]
	private sealed class _003CSetFactories_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InGameFactory _003C_003E4__this;

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
		public _003CSetFactories_003Ed__13(int _003C_003E1__state)
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
	private List<FactoryMaterial> MaterialFactories;

	[SerializeField]
	private List<FactoryMake> MakeFactories;

	[SerializeField]
	private List<FactoryAssemble> AssembleFactories;

	[SerializeField]
	private FactoryStorage Storage;

	[SerializeField]
	private FactoryOrder OrderBuilding;

	private ActionQueue EnterActionQueue;

	private Coroutine EnterActionWaitCoroutine;

	private IDisposable Tuto_FactoryItem_Disposable;

	public bool IsLoading { get; private set; }

	public override void Load()
	{
	}

	[IteratorStateMachine(typeof(_003CSetFactories_003Ed__13))]
	private IEnumerator SetFactories()
	{
		return null;
	}

	private void MakeEnterActionQueue()
	{
	}

	private void SubscribeTutorialCondition()
	{
	}

	public void FocusStorage(Action action)
	{
	}

	public void FocusOrder(Action action)
	{
	}

	public void FocusFactory(int factory, Action action)
	{
	}

	public GameObject GetFactory(int factoryIdx)
	{
		return null;
	}

	protected override void LoadUI()
	{
	}

	public override void UnLoad()
	{
	}
}
