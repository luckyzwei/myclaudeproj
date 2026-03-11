using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Balancy.Models.SmartObjects;
using Hiro;
using Hiro.Unity;
using KWCore.Utils;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class NakamaMarket : MonoSingleton<NakamaMarket>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CPurchase_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaMarket _003C_003E4__this;

		public IEconomyListStoreItem product;

		public Action<bool> onProductPurchased;

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
	private struct _003CPurchase_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaMarket _003C_003E4__this;

		public string productClientId;

		public Action<bool> onProductPurchased;

		private bool _003Csuccess_003E5__2;

		private TaskAwaiter<PurchaseEventArgs> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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
	private struct _003CPurchaseSoft_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NakamaMarket _003C_003E4__this;

		public IEconomyListStoreItem product;

		public Action<bool> onProductPurchased;

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
	private struct _003CPurchaseSoft_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaMarket _003C_003E4__this;

		public string productId;

		public Action<bool> onProductPurchased;

		private bool _003Csuccess_003E5__2;

		private TaskAwaiter<IEconomyPurchaseAck> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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

	[CompilerGenerated]
	private sealed class _003CSetProductPrice_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Text textTMP;

		public NakamaMarket _003C_003E4__this;

		public string productID;

		private float _003Ctimer_003E5__2;

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
		public _003CSetProductPrice_003Ed__11(int _003C_003E1__state)
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

	public EconomySystem EconomySystem { get; private set; }

	public UnityPurchasingSystem PurchasingSystem { get; private set; }

	protected override void Init()
	{
	}

	private void NakamaConnected(NakamaSystemsInterface nakamaSystemsInterface)
	{
	}

	public IEconomyListStoreItem GetStoreItem(string clientID)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSetProductPrice_003Ed__11))]
	public IEnumerator SetProductPrice(Text textTMP, string productID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CPurchase_003Ed__12))]
	public void Purchase(IEconomyListStoreItem product, Action<bool> onProductPurchased)
	{
	}

	[AsyncStateMachine(typeof(_003CPurchase_003Ed__13))]
	public Task Purchase(string productClientId, Action<bool> onProductPurchased)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CPurchaseSoft_003Ed__14))]
	public void PurchaseSoft(IEconomyListStoreItem product, Action<bool> onProductPurchased)
	{
	}

	[AsyncStateMachine(typeof(_003CPurchaseSoft_003Ed__15))]
	public Task PurchaseSoft(string productId, Action<bool> onProductPurchased)
	{
		return null;
	}

	public bool IsItemOwned(string productClientId)
	{
		return false;
	}

	private void SendFireBaseIAPAnalytics(Product product, StoreItem storeItem)
	{
	}

	private static void SendIAPFailedEvents(string productCode, string currencyCode, float price, string error)
	{
	}

	private static void SendIAPCompletedEvents(string productCode, string currencyCode, float price, bool isRestore)
	{
	}
}
