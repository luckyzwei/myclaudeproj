using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using KWAnalytics.Analytics;
using KWCore;
using KWCore.SaveData;
using KWCore.Utils;
using Nakama;
using UnityEngine;

public class NakamaServerInterface : ServerInterface, IServer
{
	private enum Environment
	{
		LOCAL = 0,
		DEVELOPMENT = 1,
		PRODUCTION = 2
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadFromCloudServer_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaServerInterface _003C_003E4__this;

		public List<BucketBase> buckets;

		public Dictionary<string, BucketBase> bucketDictionary;

		private TaskAwaiter<IApiStorageObjects> _003C_003Eu__1;

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
	private struct _003CSaveOnCloudServer_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public NakamaServerInterface _003C_003E4__this;

		public List<BucketBase> buckets;

		public bool init;

		public Dictionary<string, BucketBase> bucketDictionary;

		private TaskAwaiter<IApiStorageObjectAcks> _003C_003Eu__1;

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

	private const string COLLECTION_ID_BUCKETS = "Buckets";

	[Header("Connectivity")]
	[Tooltip("The game will keep loading until a connection with Nakama is established.")]
	[SerializeField]
	private bool m_waitForConnectionIndefinitely;

	[Space(10f)]
	[Header("Hiro Connection Settings")]
	[SerializeField]
	private HiroConnectionScriptable m_localConnectionSettings;

	[SerializeField]
	private HiroConnectionScriptable m_devConnectionSettings;

	[SerializeField]
	private HiroConnectionScriptable m_prodConnectionSettings;

	[SerializeField]
	private Environment m_environment;

	private float m_lastTriedToConnect;

	private bool m_partialInitialized;

	private bool m_serverOperationInProgress;

	private bool m_safeToSaveSession;

	private HiroConnectionScriptable m_connectionSettings;

	public void Awake()
	{
	}

	private void UpdateConnectionSettings()
	{
	}

	public void Initialise(ServerInterface serverInterface, DeviceSettingsManager deviceSettingsManager = null)
	{
	}

	public void DoOnApplicationPause(bool isPaused)
	{
	}

	public void DoOnApplicationQuit()
	{
	}

	public override IServer GetServer()
	{
		return null;
	}

	public override string GetBackendName()
	{
		return null;
	}

	public override string GetBackendEnvironmentName()
	{
		return null;
	}

	public override string GetPlayerID()
	{
		return null;
	}

	public override string GetGameSegmentName()
	{
		return null;
	}

	public override string GetGameSegmentId()
	{
		return null;
	}

	public override bool HasPlayer()
	{
		return false;
	}

	public override void UpdateGDPRConsentRecord(string consentID, bool agreed, long timeStamp)
	{
	}

	public override void RegisterBuckets(SaveDataManager saveDataManager)
	{
	}

	public override void AddCustomAnalyticsParams(BaseSchema schema)
	{
	}

	public override string GetGameSegmentedSessionId()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoadFromCloudServer_003Ed__28))]
	public override Task LoadFromCloudServer(List<BucketBase> buckets, Dictionary<string, BucketBase> bucketDictionary)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSaveOnCloudServer_003Ed__29))]
	public override Task SaveOnCloudServer(List<BucketBase> buckets, Dictionary<string, BucketBase> bucketDictionary, bool init = false)
	{
		return null;
	}

	public override void RegisterInitialisationCallback(Action callback)
	{
	}

	public override void RegisterRestoreCallback(Action callback)
	{
	}
}
