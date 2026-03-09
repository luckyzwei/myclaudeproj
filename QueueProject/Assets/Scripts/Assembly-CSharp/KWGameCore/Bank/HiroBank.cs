using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;

namespace KWGameCore.Bank
{
	public class HiroBank : BaseBank
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddMoneyAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string currencyId;

			public HiroBank _003C_003E4__this;

			public long money;

			private long _003Ccurrency_003E5__2;

			private EconomySystem _003CeconomySystem_003E5__3;

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
		private struct _003COverrideMoneyAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string currencyId;

			public HiroBank _003C_003E4__this;

			public long money;

			private long _003CcurrencyAmount_003E5__2;

			private EconomySystem _003CeconomySystem_003E5__3;

			private long _003CamountDiff_003E5__4;

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
		private struct _003CPurchaseAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string currencyId;

			public HiroBank _003C_003E4__this;

			public long cost;

			private long _003CavailableMoney_003E5__2;

			private EconomySystem _003CeconomySystem_003E5__3;

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

		private IReadOnlyDictionary<string, long> Currencies => null;

		public override void InitialiseBank(IDelegate del)
		{
		}

		public override void Dispose()
		{
		}

		private void OnCoreLoadingCompleted()
		{
		}

		public override void AddMoney(long money, string context = "none", string rewardType = "collect", string currencyID = null)
		{
		}

		[AsyncStateMachine(typeof(_003CAddMoneyAsync_003Ed__6))]
		private Task AddMoneyAsync(long money, string context = "none", string rewardType = "collect", string currencyId = null)
		{
			return null;
		}

		public override void OverrideMoney(long money, string currencyId = null)
		{
		}

		[AsyncStateMachine(typeof(_003COverrideMoneyAsync_003Ed__8))]
		private Task OverrideMoneyAsync(long money, string currencyId = null)
		{
			return null;
		}

		public override bool Purchase(long cost, string description = null, string currencyId = null)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CPurchaseAsync_003Ed__10))]
		private Task PurchaseAsync(long cost, string currencyId = null)
		{
			return null;
		}

		public override long FetchCurrentMoney(string currencyID = null)
		{
			return 0L;
		}

		public void RefreshBank()
		{
		}
	}
}
