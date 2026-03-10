using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using KWGameCore;

namespace KWCore.SaveData
{
	public class SaveDataManager
	{
		public interface IDelegate
		{
			void RegisterProjectBuckets(SaveDataManager saveDataManager);
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitialiseFromServer_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;
			public AsyncVoidMethodBuilder _003C_003Et__builder;
			public SaveDataManager _003C_003E4__this;
			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext() { }
			void IAsyncStateMachine.MoveNext() { this.MoveNext(); }
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine) { }
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine) { this.SetStateMachine(stateMachine); }
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRestoreFromServer_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;
			public AsyncVoidMethodBuilder _003C_003Et__builder;
			public SaveDataManager _003C_003E4__this;
			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext() { }
			void IAsyncStateMachine.MoveNext() { this.MoveNext(); }
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine) { }
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine) { this.SetStateMachine(stateMachine); }
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSaveToServer_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;
			public AsyncVoidMethodBuilder _003C_003Et__builder;
			public SaveDataManager _003C_003E4__this;
			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext() { }
			void IAsyncStateMachine.MoveNext() { this.MoveNext(); }
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine) { }
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine) { this.SetStateMachine(stateMachine); }
		}

		private IDelegate m_delegate;

		private Dictionary<Type, BucketBase> m_bucketDictionary;

		private Dictionary<string, BucketBase> m_bucketDictionaryByKey;

		private List<BucketBase> m_buckets;

		private bool m_doNotSave;

		private ServerInterface m_loadSaveServerInterface;

		private List<ServerInterface> m_serverInterfaces;

		private MarketInterface m_marketInterface;

		private static Action _BucketsUpdated;
		public static event Action BucketsUpdated
		{
			add { _BucketsUpdated += value; }
			remove { _BucketsUpdated -= value; }
		}

		public void RegisterBucket<T>() where T : BucketBase, new()
		{
			var bucket = new T();
			bucket.LoadFromDisk();
			var type = typeof(T);
			if (m_bucketDictionary == null) m_bucketDictionary = new Dictionary<Type, BucketBase>();
			if (m_bucketDictionaryByKey == null) m_bucketDictionaryByKey = new Dictionary<string, BucketBase>();
			if (m_buckets == null) m_buckets = new List<BucketBase>();

			m_bucketDictionary[type] = bucket;
			m_bucketDictionaryByKey[bucket.GetBucketKey()] = bucket;
			m_buckets.Add(bucket);
		}

		public void DoNotSave()
		{
			m_doNotSave = true;
		}

		public T GetBucket<T>() where T : BucketBase
		{
			if (m_bucketDictionary != null && m_bucketDictionary.TryGetValue(typeof(T), out var bucket))
				return bucket as T;
			return null;
		}

		public BucketBase GetBucketForKey(string key)
		{
			if (m_bucketDictionaryByKey != null && m_bucketDictionaryByKey.TryGetValue(key, out var bucket))
				return bucket;
			return null;
		}

		public void Initialise(IDelegate del, List<ServerInterface> serverInterfaces, MarketInterface marketInterface)
		{
			m_delegate = del;
			m_serverInterfaces = serverInterfaces;
			m_marketInterface = marketInterface;

			m_bucketDictionary = new Dictionary<Type, BucketBase>();
			m_bucketDictionaryByKey = new Dictionary<string, BucketBase>();
			m_buckets = new List<BucketBase>();

			CreateCoreBuckets();
			CreateProjectBuckets();
			LoadFromDisk();
		}

		protected virtual void CreateCoreBuckets()
		{
			RegisterBucket<BucketDailyChallenge>();
			RegisterBucket<BucketMissions>();
		}

		protected virtual void CreateProjectBuckets()
		{
			m_delegate?.RegisterProjectBuckets(this);
		}

		public void Save()
		{
			if (m_doNotSave) return;
			SaveToDisk();
		}

		[AsyncStateMachine(typeof(_003CSaveToServer_003Ed__20))]
		private void SaveToServer()
		{
			// Server save - stub
		}

		private void SaveToDisk()
		{
			if (m_buckets == null) return;
			foreach (var bucket in m_buckets)
				bucket.SaveToDisk();
		}

		public void DoOnApplicationPause(bool pause)
		{
			if (pause) Save();
		}

		public void DoOnApplicationQuit()
		{
			Save();
		}

		public void DeleteAll()
		{
			DeleteAllInternal();
		}

		private void DeleteAllInternal()
		{
			if (m_buckets == null) return;
			foreach (var bucket in m_buckets)
				bucket.DeleteAll();
			SaveToDisk();
		}

		protected void RemoveAnyOldKeys()
		{
			if (m_buckets == null) return;
			foreach (var bucket in m_buckets)
				bucket.RemoveAnyOldKeys(this);
		}

		private void LoadFromDisk()
		{
			if (m_buckets == null) return;
			foreach (var bucket in m_buckets)
				bucket.LoadFromDisk();
			_BucketsUpdated?.Invoke();
		}

		[AsyncStateMachine(typeof(_003CInitialiseFromServer_003Ed__28))]
		private void InitialiseFromServer()
		{
			// Server initialization - stub
		}

		[AsyncStateMachine(typeof(_003CRestoreFromServer_003Ed__29))]
		private void RestoreFromServer()
		{
			// Server restore - stub
		}

		protected virtual void TransferAnyDataBetweenBuckets()
		{
		}
	}
}
