using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;
using KWCore.Utils;

public class NakamaStats : MonoSingleton<NakamaStats>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAwardStat_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string clientID;

		public long amount;

		public NakamaStats _003C_003E4__this;

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
	private struct _003COverrideStatAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaStats _003C_003E4__this;

		public string clientID;

		public long amount;

		private TaskAwaiter<IStat> _003C_003Eu__1;

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

	private StatsSystem m_statsSystem;

	protected override void Init()
	{
	}

	private void NakamaConnected(NakamaSystemsInterface nakamaSystemsInterface)
	{
	}

	private void StatsUpdated()
	{
	}

	public long GetStatValue(string clientID)
	{
		return 0L;
	}

	[AsyncStateMachine(typeof(_003CAwardStat_003Ed__5))]
	public void AwardStat(string clientID, long amount)
	{
	}

	private IStat GetStat(string id)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003COverrideStatAsync_003Ed__7))]
	public Task OverrideStatAsync(string clientID, long amount)
	{
		return null;
	}
}
