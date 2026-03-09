using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;
using KWCore.Utils;

public class NakamaInventory : MonoSingleton<NakamaInventory>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAddItems_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaInventory _003C_003E4__this;

		public string clientID;

		public long count;

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
	private struct _003CRemoveItems_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public NakamaInventory _003C_003E4__this;

		public string clientID;

		public int count;

		private TaskAwaiter<IDictionary<string, IRewardList>> _003C_003Eu__1;

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

	private const string NO_ADS_ID = "no_ads";

	private InventorySystem m_inventorySystem;

	protected override void Init()
	{
	}

	private void NakamaConnected(NakamaSystemsInterface nakamaSystemsInterface)
	{
	}

	private void InventoryUpdated()
	{
	}

	public long GetItemCount(string clientID)
	{
		return 0L;
	}

	[AsyncStateMachine(typeof(_003CRemoveItems_003Ed__6))]
	public Task<bool> RemoveItems(string clientID, int count)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CAddItems_003Ed__7))]
	public Task AddItems(string clientID, long count)
	{
		return null;
	}

	private void CheckIfAdWasPurchased()
	{
	}

	public bool HasPurchasedNoAds()
	{
		return false;
	}

	private IInventoryItem GetItem(string id)
	{
		return null;
	}

	private IInventoryItem GetCodex(string id)
	{
		return null;
	}
}
