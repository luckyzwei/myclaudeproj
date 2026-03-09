using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Hiro;
using Nakama;
using UnityEngine;

public class NakamaStabilityChecker : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CTestConnection_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaStabilityChecker _003C_003E4__this;

		public Action<bool, float, float> onResult;

		private int _003Cfailed_003E5__2;

		private List<float> _003Clatencies_003E5__3;

		private NakamaSystem _003CnakamaSystem_003E5__4;

		private int _003Ci_003E5__5;

		private float _003CstartTime_003E5__6;

		private TaskAwaiter<IApiRpc> _003C_003Eu__1;

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

	public int sampleCount;

	public float timeoutSeconds;

	public float latencyThreshold;

	public float failureRateThreshold;

	private const string RPC_HEALTH_CHECK = "rpc_id_health_check";

	private static string EVENT_NAME;

	private static void SendAnalyticEvent(bool stable, float latency, float failureRate)
	{
	}

	private void Start()
	{
	}

	[AsyncStateMachine(typeof(_003CTestConnection_003Ed__8))]
	public Task TestConnection(Action<bool, float, float> onResult)
	{
		return null;
	}

	private float GetAverage(List<float> values)
	{
		return 0f;
	}
}
