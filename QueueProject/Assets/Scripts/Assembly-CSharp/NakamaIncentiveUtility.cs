using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;

public static class NakamaIncentiveUtility
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public string incentiveId;

		internal bool _003CGetIncentive_003Eb__0(IIncentive incentive)
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetIncentive_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IIncentive> _003C_003Et__builder;

		public string incentiveId;

		public IncentiveSystem updatedIncentiveSystem;

		private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

		private TaskAwaiter<IList<IIncentive>> _003C_003Eu__1;

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

	[AsyncStateMachine(typeof(_003CGetIncentive_003Ed__0))]
	public static Task<IIncentive> GetIncentive(string incentiveId, IncentiveSystem updatedIncentiveSystem = null)
	{
		return null;
	}

	public static IIncentive GetSentIncentive(string incentiveId, IncentiveSystem updatedIncentiveSystem = null)
	{
		return null;
	}

	public static IIncentive GetReceivedIncentive(string incentiveId, IncentiveSystem updatedIncentiveSystem = null)
	{
		return null;
	}

	private static IIncentive GetIncentiveUsingId(string id, IDictionary<string, IIncentive> incentives)
	{
		return null;
	}

	public static long GetMaxClaims(this IIncentive incentive)
	{
		return 0L;
	}

	public static long GetClaimedCount(this IIncentive incentive)
	{
		return 0L;
	}
}
