using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Hiro;
using KWCore.Utils;
using UnityEngine;

public class NakamaEnergy : MonoSingleton<NakamaEnergy>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAddEnergyAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string id;

		public int amountToAdd;

		public Action onCompleteCallback;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRefreshSystemAsync_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Action onCompleteCallback;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRemoveEnergyAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string id;

		public int amountToRemove;

		public Action onCompleteCallback;

		private TaskAwaiter<IEnergySpendReward> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private List<string> m_modifierOperators;

	private bool m_isInitialised;

	private Dictionary<string, TimerDisposable> m_timerDataDict;

	public bool IsInitialised => false;

	protected override void Init()
	{
	}

	private void OnNakamaConnected(NakamaSystemsInterface nakamaSystemsInterface)
	{
	}

	private void Initialise(NakamaSystemsInterface nakamaSystemsInterface)
	{
	}

	private void EnergiesUpdated()
	{
	}

	public IEnergy GetEnergy(string id)
	{
		return null;
	}

	public void RefreshSystem(Action onCompleteCallback = null)
	{
	}

	public void AddEnergy(string id, int amountToAdd = 1, Action onCompleteCallback = null)
	{
	}

	public void RemoveEnergy(string id, int amountToRemove = 1, Action onCompleteCallback = null)
	{
	}

	[AsyncStateMachine(typeof(_003CRefreshSystemAsync_003Ed__13))]
	private static void RefreshSystemAsync(Action onCompleteCallback)
	{
	}

	[AsyncStateMachine(typeof(_003CAddEnergyAsync_003Ed__14))]
	private static void AddEnergyAsync(string id, int amountToAdd, Action onCompleteCallback)
	{
	}

	[AsyncStateMachine(typeof(_003CRemoveEnergyAsync_003Ed__15))]
	private static void RemoveEnergyAsync(string id, int amountToRemove, Action onCompleteCallback)
	{
	}

	private void InitialiseModifierTimers()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void TryStartAllTimers()
	{
	}

	private void TryStopAllTimers()
	{
	}

	private void TryStartModifierTimer(IEnergy energy)
	{
	}

	private void TryStartModifierTimer(IEnergy energy, string operatorId, TimerDisposable.TimerEvents timerEvents)
	{
	}

	private void TryStopModifierTimer(IEnergy energyId)
	{
	}

	private TimerDisposable GetTimer(string energyId, string operatorId)
	{
		return null;
	}

	protected override void OnDestroy()
	{
	}

	private void DisposeAllTimers()
	{
	}
}
