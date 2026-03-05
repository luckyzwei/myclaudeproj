using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class ObjectPool<T> : IPool<T> where T : MonoBehaviour
{
	private AssetReference assetRef;

	private Queue<T> poolQueue;

	private int loadWaitCnt;

	private Action LoadComplete;

	private Transform parent;

	public void Init(AssetReference _ref, Transform _parent, int size, Action _loadComp = null)
	{
		assetRef = _ref;
		parent = _parent;
		poolQueue = new Queue<T>();
		LoadComplete = _loadComp;
		loadWaitCnt = size;
		Create(size);
	}

	public void Create(int size)
	{
		for (int i = 0; i < size; i++)
		{
			if (assetRef != null)
				assetRef.InstantiateAsync(parent).Completed += OnAssetLoadComp;
		}
	}

	private void OnAssetLoadComp(AsyncOperationHandle<GameObject> handle)
	{
		if (handle.Status == AsyncOperationStatus.Succeeded && handle.Result != null)
		{
			var comp = handle.Result.GetComponent<T>();
			if (comp != null)
			{
				comp.gameObject.SetActive(false);
				poolQueue.Enqueue(comp);
			}
		}
		loadWaitCnt--;
		if (loadWaitCnt <= 0)
			LoadComplete?.Invoke();
	}

	public void Get(Action<T> onLoad)
	{
		if (poolQueue != null && poolQueue.Count > 0)
		{
			var obj = poolQueue.Dequeue();
			if (obj != null) obj.gameObject.SetActive(true);
			onLoad?.Invoke(obj);
		}
		else
		{
			loadWaitCnt = 1;
			LoadComplete = () => { Get(onLoad); };
			Create(1);
		}
	}

	public void Return(T obj)
	{
		if (obj == null) return;
		obj.gameObject.SetActive(false);
		if (poolQueue != null)
			poolQueue.Enqueue(obj);
	}

	public void Clear()
	{
		if (poolQueue != null)
		{
			while (poolQueue.Count > 0)
			{
				var obj = poolQueue.Dequeue();
				if (obj != null)
					UnityEngine.Object.Destroy(obj.gameObject);
			}
		}
	}
}
