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
			get { return _003C_003E2__current; }
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get { return _003C_003E2__current; }
		}

		[DebuggerHidden]
		public _003CSetFactories_003Ed__13(int _003C_003E1__state)
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
					// Initialize factories
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
		IsLoading = true;
		StartCoroutine(SetFactories());
		LoadUI();
	}

	[IteratorStateMachine(typeof(_003CSetFactories_003Ed__13))]
	private IEnumerator SetFactories()
	{
		IsLoading = false;
		yield break;
	}

	private void MakeEnterActionQueue()
	{
		EnterActionQueue = new ActionQueue();
	}

	private void SubscribeTutorialCondition()
	{
		// Subscribe to tutorial conditions for factory mode
	}

	public void FocusStorage(Action action)
	{
		if (Storage != null)
		{
			// Focus camera on storage
		}
		action?.Invoke();
	}

	public void FocusOrder(Action action)
	{
		if (OrderBuilding != null)
		{
			// Focus camera on order building
		}
		action?.Invoke();
	}

	public void FocusFactory(int factory, Action action)
	{
		var go = GetFactory(factory);
		if (go != null)
		{
			// Focus camera on factory
		}
		action?.Invoke();
	}

	public GameObject GetFactory(int factoryIdx)
	{
		if (MaterialFactories != null)
		{
			for (int i = 0; i < MaterialFactories.Count; i++)
			{
				if (MaterialFactories[i] != null && MaterialFactories[i].FactoryIdx == factoryIdx)
					return MaterialFactories[i].gameObject;
			}
		}
		if (MakeFactories != null)
		{
			for (int i = 0; i < MakeFactories.Count; i++)
			{
				if (MakeFactories[i] != null && MakeFactories[i].FactoryIdx == factoryIdx)
					return MakeFactories[i].gameObject;
			}
		}
		if (AssembleFactories != null)
		{
			for (int i = 0; i < AssembleFactories.Count; i++)
			{
				if (AssembleFactories[i] != null && AssembleFactories[i].FactoryIdx == factoryIdx)
					return AssembleFactories[i].gameObject;
			}
		}
		return null;
	}

	protected override void LoadUI()
	{
		// Load factory-specific UI elements
		MakeEnterActionQueue();
		SubscribeTutorialCondition();
	}

	public override void UnLoad()
	{
		IsLoading = false;
		if (Tuto_FactoryItem_Disposable != null)
		{
			Tuto_FactoryItem_Disposable.Dispose();
			Tuto_FactoryItem_Disposable = null;
		}
		if (EnterActionWaitCoroutine != null)
		{
			StopCoroutine(EnterActionWaitCoroutine);
			EnterActionWaitCoroutine = null;
		}
	}
}
