using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Balancy;
using Balancy.Data;
using KWAnalytics.Analytics;
using KWCore;
using KWCore.SaveData;
using KWCore.Utils;
using UnityEngine;

public class BalancyServerInterface : ServerInterface, IServer
{
	private class AttributionData
	{
		public string mediaSource;

		public string campaignName;

		public string channel;

		public string creativePack;

		public string campaignID;

		public string status;

		public string adID;
	}

	[CompilerGenerated]
	private sealed class _003CBalancyLocalLoadedCoroutine_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BalancyServerInterface _003C_003E4__this;

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
		public _003CBalancyLocalLoadedCoroutine_003Ed__57(int _003C_003E1__state)
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitUnityGamingServices_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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

	[CompilerGenerated]
	private sealed class _003CResetBalancyData_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BalancyServerInterface _003C_003E4__this;

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
		public _003CResetBalancyData_003Ed__65(int _003C_003E1__state)
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

	private const string BACKEND_NAME = "Balancy";

	private const string PROFILE_VERSION = "PROFILE_VERSION";

	private const string INSTALL_ID = "authInstallId";

	private const string KANGA_PLAYER_ID = "authPlayerId";

	private const string GAME_VERSION = "authGameEditionVersion";

	private const string INSTALLED_VERSION = "INSTALLED_ON_VERSION_KEY";

	public const string FORCE_CLEAR_PROFILE = "force_clear_profile";

	public const string BALANCY_OFFLINE_USER_ID = "LocalUser";

	private const string PLAYER_ID_PREFIX = "P_player_";

	private const string PLATFORM_ID = "android";

	[SerializeField]
	private string m_gameId;

	[SerializeField]
	private string m_publicKey;

	[SerializeField]
	private Constants.Environment m_environment;

	[SerializeField]
	private bool m_keepProfileBetweenReinstalls;

	[SerializeField]
	private CustomProfiles m_profileRegister;

	private bool m_installFlagSet;

	private bool m_documentsReady;

	private bool m_profilesReady;

	private AttributionData m_attributionData;

	public static string BalancyUserID => null;

	public static bool BalancyInitialisedLocal { get; private set; }

	public static bool BalancyInitialisedServer { get; private set; }

	public static int DeployVersion { get; private set; }

	public static Constants.Environment Environment { get; private set; }

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

	private string PreviousKangaId()
	{
		return null;
	}

	public override string GetPlayerID()
	{
		return null;
	}

	private void OnConversionDataSuccess(string conversionData)
	{
	}

	private void TrySetAttributionData(ProfileData profileData)
	{
	}

	public override bool HasPlayer()
	{
		return false;
	}

	public override string GetGameSegmentedSessionId()
	{
		return null;
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

	public override Task LoadFromCloudServer(List<BucketBase> buckets, Dictionary<string, BucketBase> bucketDictionary)
	{
		return null;
	}

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

	private void RegisterProfileDatas()
	{
	}

	[AsyncStateMachine(typeof(_003CInitUnityGamingServices_003Ed__55))]
	private void InitUnityGamingServices()
	{
	}

	public void Initialise(ServerInterface serverInterface, DeviceSettingsManager deviceSettingsManager = null)
	{
	}

	[IteratorStateMachine(typeof(_003CBalancyLocalLoadedCoroutine_003Ed__57))]
	private IEnumerator BalancyLocalLoadedCoroutine()
	{
		return null;
	}

	public void DoOnApplicationPause(bool isPaused)
	{
	}

	public void DoOnApplicationQuit()
	{
	}

	private void CheckClientVersionData()
	{
	}

	private Constants.Platform GetPlatform()
	{
		return default(Constants.Platform);
	}

	private void OnUserProfileLoaded(ParentBaseData userProfile)
	{
	}

	private void CheckForPlayerCreated(ProfileData profileData)
	{
	}

	private void TryFinishLoading()
	{
	}

	[IteratorStateMachine(typeof(_003CResetBalancyData_003Ed__65))]
	private IEnumerator ResetBalancyData()
	{
		return null;
	}

	private void OnProfileReset()
	{
	}

	private void SendABTest()
	{
	}

	public override string GetGameSegmentName()
	{
		return null;
	}

	public override string GetGameSegmentId()
	{
		return null;
	}
}
