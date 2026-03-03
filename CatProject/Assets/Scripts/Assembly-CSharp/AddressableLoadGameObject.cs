using System;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableLoadGameObject
{
	public enum E_LoadState
	{
		Ready = 0,
		Loading = 1,
		Loaded = 2
	}

	private AsyncOperationHandle<GameObject> LoadHandle;

	private bool ReleaseFlag;

	public object Key { get; private set; }

	public E_LoadState LoadState { get; private set; }

	public GameObject LoadObject { get; private set; }

	public bool InstantiateAsync(object key, Transform parent = null, bool instantiateInWorldSpace = false, Action<GameObject> onLoad = null)
	{
		return false;
	}

	public bool InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent = null, bool instantiateInWorldSpace = false, Action<GameObject> onLoad = null)
	{
		return false;
	}

	public bool CheckSameKey(object key)
	{
		return false;
	}

	private void OnLoadComp(AsyncOperationHandle<GameObject> handle, Action<GameObject> onLoad)
	{
	}

	public void Release()
	{
	}
}
