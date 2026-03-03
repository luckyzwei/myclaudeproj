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
	}

	public void Create(int size)
	{
	}

	private void OnAssetLoadComp(AsyncOperationHandle<GameObject> handle)
	{
	}

	public void Get(Action<T> onLoad)
	{
	}

	public void Return(T obj)
	{
	}

	public void Clear()
	{
	}
}
