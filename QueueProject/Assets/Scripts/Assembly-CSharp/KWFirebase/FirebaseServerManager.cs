using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KWAnalytics.Analytics;
using KWCore;
using KWCore.SaveData;
using KWCore.Utils;

namespace KWFirebase
{
	public class FirebaseServerManager : ServerInterface, IServer
	{
		private const string BACKEND_NAME = "Firebase";

		private const string AB_GROUP_KEY = "abGroup";

		private const string MIN_VERSION_KEY = "minVersion";

		private const string CONFIGS_RESOURCES_PATH = "FirebaseConfigs";

		private Environment m_environment;

		private bool m_mainSceneLoaded;

		private bool m_forceUpgradeShown;

		private readonly Dictionary<string, FirebaseScriptableObject> m_cachedObjects;

		public void Initialise(ServerInterface serverInterface, DeviceSettingsManager deviceSettingsManager = null)
		{
		}

		public override string GetPlayerID()
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

		private void SetEnvironment()
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

		public bool HasConnected()
		{
			return false;
		}

		public bool GetBool(string key, bool defaultValue = false)
		{
			return false;
		}

		public string GetString(string key, string defaultValue = null)
		{
			return null;
		}

		public double GetDouble(string key, double defaultValue = 0.0)
		{
			return 0.0;
		}

		public long GetLong(string key, long defaultValue = 0L)
		{
			return 0L;
		}

		public T Get<T>(string name, string subDirectory = "", bool keepInMemory = false) where T : FirebaseScriptableObject
		{
			return null;
		}

		public FirebaseScriptableObject Get(string name, Type type, string subDirectory = "", bool keepInMemory = false)
		{
			return null;
		}
	}
}
