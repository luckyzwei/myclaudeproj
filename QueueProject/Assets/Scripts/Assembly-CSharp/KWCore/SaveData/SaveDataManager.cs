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
		private struct _003CRestoreFromServer_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SaveDataManager _003C_003E4__this;

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
		private struct _003CSaveToServer_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SaveDataManager _003C_003E4__this;

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

		private IDelegate m_delegate;

		private Dictionary<Type, BucketBase> m_bucketDictionary;

		private Dictionary<string, BucketBase> m_bucketDictionaryByKey;

		private List<BucketBase> m_buckets;

		private bool m_doNotSave;

		private ServerInterface m_loadSaveServerInterface;

		private List<ServerInterface> m_serverInterfaces;

		private MarketInterface m_marketInterface;

		public static event Action BucketsUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void RegisterBucket<T>() where T : BucketBase, new()
		{
		}

		public void DoNotSave()
		{
		}

		public T GetBucket<T>() where T : BucketBase
		{
			return null;
		}

		public BucketBase GetBucketForKey(string key)
		{
			return null;
		}

		public void Initialise(IDelegate del, List<ServerInterface> serverInterfaces, MarketInterface marketInterface)
		{
		}

		protected virtual void CreateCoreBuckets()
		{
		}

		protected virtual void CreateProjectBuckets()
		{
		}

		public void Save()
		{
		}

		[AsyncStateMachine(typeof(_003CSaveToServer_003Ed__20))]
		private void SaveToServer()
		{
		}

		private void SaveToDisk()
		{
		}

		public void DoOnApplicationPause(bool pause)
		{
		}

		public void DoOnApplicationQuit()
		{
		}

		public void DeleteAll()
		{
		}

		private void DeleteAllInternal()
		{
		}

		protected void RemoveAnyOldKeys()
		{
		}

		private void LoadFromDisk()
		{
		}

		[AsyncStateMachine(typeof(_003CInitialiseFromServer_003Ed__28))]
		private void InitialiseFromServer()
		{
		}

		[AsyncStateMachine(typeof(_003CRestoreFromServer_003Ed__29))]
		private void RestoreFromServer()
		{
		}

		protected virtual void TransferAnyDataBetweenBuckets()
		{
		}
	}
}
