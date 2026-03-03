using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class GameObjectPool : MonoBehaviour
{
	private class PoolData
	{
		public Queue<GameObject> AvailableObjects;

		public HashSet<GameObject> UsedObjects;

		public AssetReference AssetRef;

		public Transform Parent;
	}

	private class EmptyDisposable : IDisposable
	{
		public static EmptyDisposable Instance;

		private EmptyDisposable()
		{
		}

		public void Dispose()
		{
		}
	}

	private class ReturnObservable<T> : IObservable<T>
	{
		private readonly T value;

		public ReturnObservable(T value)
		{
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CBarrow_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<GameObject> _003C_003Et__builder;

		public AssetReference assetRef;

		public GameObjectPool _003C_003E4__this;

		private string _003CpoolName_003E5__2;

		private PoolData _003Cpool_003E5__3;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
	private struct _003CCreateNewInstance_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<GameObject> _003C_003Et__builder;

		public PoolData pool;

		private AsyncOperationHandle<GameObject> _003Chandle_003E5__2;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private struct _003CFire_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public UniTask<GameObject> task;

		public AsyncSubject<GameObject> subject;

		public GameObjectPool _003C_003E4__this;

		private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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

	private Dictionary<string, PoolData> pools;

	private Dictionary<int, string> poolObjectToken;

	[SerializeField]
	public float cleanupInterval;

	private float lastCleanupTime;

	private void Start()
	{
	}

	private void OnLowMemory()
	{
	}

	private void Update()
	{
	}

	private PoolData RegisterPrefabInternal(AssetReference assetRef)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CBarrow_003Ed__9))]
	public UniTask<GameObject> Barrow(AssetReference assetRef)
	{
		return default(UniTask<GameObject>);
	}

	[AsyncStateMachine(typeof(_003CFire_003Ed__12))]
	private UniTaskVoid Fire(AsyncSubject<GameObject> subject, UniTask<GameObject> task)
	{
		return default(UniTaskVoid);
	}

	public IObservable<GameObject> BarrowAsObservable(AssetReference assetReference)
	{
		return null;
	}

	public void Return(Component instance)
	{
	}

	public void Return(GameObject instance)
	{
	}

	public static GameObjectPool From(Component component)
	{
		return null;
	}

	public static GameObjectPool From(GameObject gameObject)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CCreateNewInstance_003Ed__18))]
	private UniTask<GameObject> CreateNewInstance(PoolData pool)
	{
		return default(UniTask<GameObject>);
	}

	private void CleanupPools()
	{
	}

	private void CleanupPool(PoolData pool)
	{
	}

	private int GetLargestPowerOfTwo(int n)
	{
		return 0;
	}

	private void OnDestroy()
	{
	}
}
