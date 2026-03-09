using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KWAnalytics.Analytics;
using KWCore.SaveData;
using UnityEngine;
using UnityEngine.Serialization;

namespace KWCore
{
	public abstract class ServerInterface : MonoBehaviour
	{
		[Header("Player")]
		[Tooltip("Set to true if this is the main game server (handles the player ID and game settings)")]
		[FormerlySerializedAs("HandlePlayer")]
		public bool IsMainServer;

		[Header("Buckets")]
		public bool RemoteBuckets;

		public abstract IServer GetServer();

		public abstract string GetBackendName();

		public abstract string GetBackendEnvironmentName();

		public abstract string GetPlayerID();

		public abstract string GetGameSegmentName();

		public abstract string GetGameSegmentId();

		public abstract bool HasPlayer();

		public abstract void UpdateGDPRConsentRecord(string consentID, bool agreed, long timeStamp);

		public abstract void RegisterBuckets(SaveDataManager saveDataManager);

		public abstract void AddCustomAnalyticsParams(BaseSchema schema);

		public abstract string GetGameSegmentedSessionId();

		public abstract Task LoadFromCloudServer(List<BucketBase> buckets, Dictionary<string, BucketBase> bucketDictionary);

		public abstract Task SaveOnCloudServer(List<BucketBase> buckets, Dictionary<string, BucketBase> bucketDictionary, bool init = false);

		public abstract void RegisterInitialisationCallback(Action callback);

		public abstract void RegisterRestoreCallback(Action callback);
	}
}
