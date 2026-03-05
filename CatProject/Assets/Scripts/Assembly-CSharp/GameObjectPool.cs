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
		public static EmptyDisposable Instance = new EmptyDisposable();

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
			this.value = value;
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			observer.OnNext(value);
			observer.OnCompleted();
			return EmptyDisposable.Instance;
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
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
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
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
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
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
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
		pools = new Dictionary<string, PoolData>();
		poolObjectToken = new Dictionary<int, string>();
		lastCleanupTime = Time.time;
	}

	private void OnLowMemory()
	{
		CleanupPools();
	}

	private void Update()
	{
		if (cleanupInterval > 0f && Time.time - lastCleanupTime >= cleanupInterval)
		{
			CleanupPools();
			lastCleanupTime = Time.time;
		}
	}

	private PoolData RegisterPrefabInternal(AssetReference assetRef)
	{
		if (assetRef == null) return null;
		string key = assetRef.RuntimeKey.ToString();
		if (pools.TryGetValue(key, out var existing))
			return existing;
		var pool = new PoolData
		{
			AvailableObjects = new Queue<GameObject>(),
			UsedObjects = new HashSet<GameObject>(),
			AssetRef = assetRef,
			Parent = transform
		};
		pools[key] = pool;
		return pool;
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
		var subject = new AsyncSubject<GameObject>();
		Fire(subject, Barrow(assetReference));
		return subject;
	}

	public void Return(Component instance)
	{
		if (instance != null)
			Return(instance.gameObject);
	}

	public void Return(GameObject instance)
	{
		if (instance == null) return;
		int id = instance.GetInstanceID();
		if (poolObjectToken.TryGetValue(id, out var poolKey))
		{
			if (pools.TryGetValue(poolKey, out var pool))
			{
				pool.UsedObjects.Remove(instance);
				instance.SetActive(false);
				instance.transform.SetParent(pool.Parent);
				pool.AvailableObjects.Enqueue(instance);
			}
			poolObjectToken.Remove(id);
		}
		else
		{
			Destroy(instance);
		}
	}

	public static GameObjectPool From(Component component)
	{
		if (component == null) return null;
		return component.GetComponentInParent<GameObjectPool>();
	}

	public static GameObjectPool From(GameObject gameObject)
	{
		if (gameObject == null) return null;
		return gameObject.GetComponentInParent<GameObjectPool>();
	}

	[AsyncStateMachine(typeof(_003CCreateNewInstance_003Ed__18))]
	private UniTask<GameObject> CreateNewInstance(PoolData pool)
	{
		return default(UniTask<GameObject>);
	}

	private void CleanupPools()
	{
		if (pools == null) return;
		foreach (var kvp in pools)
		{
			CleanupPool(kvp.Value);
		}
	}

	private void CleanupPool(PoolData pool)
	{
		if (pool == null || pool.AvailableObjects == null) return;
		int targetSize = GetLargestPowerOfTwo(pool.UsedObjects != null ? pool.UsedObjects.Count : 0);
		while (pool.AvailableObjects.Count > targetSize)
		{
			var obj = pool.AvailableObjects.Dequeue();
			if (obj != null)
				Destroy(obj);
		}
	}

	private int GetLargestPowerOfTwo(int n)
	{
		if (n <= 0) return 1;
		int result = 1;
		while (result <= n)
			result <<= 1;
		return result;
	}

	private void OnDestroy()
	{
		if (pools != null)
		{
			foreach (var kvp in pools)
			{
				var pool = kvp.Value;
				if (pool == null) continue;
				if (pool.AvailableObjects != null)
				{
					while (pool.AvailableObjects.Count > 0)
					{
						var obj = pool.AvailableObjects.Dequeue();
						if (obj != null) Destroy(obj);
					}
				}
			}
			pools.Clear();
		}
		poolObjectToken?.Clear();
	}
}
