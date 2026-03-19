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
		if (key == null) return false;
		Key = key;
		LoadState = E_LoadState.Loading;

		// Try to load via AddressableShim (Editor-friendly direct asset loading)
		GameObject prefab = AddressableShim.LoadAsset<GameObject>(key.ToString());
		if (prefab != null)
		{
			GameObject instance = UnityEngine.Object.Instantiate(prefab, parent, instantiateInWorldSpace);
			LoadObject = instance;
			LoadState = E_LoadState.Loaded;
			onLoad?.Invoke(instance);
			return true;
		}

		Debug.LogWarning($"[AddressableLoad] Failed to load: {key}");
		LoadState = E_LoadState.Ready;
		onLoad?.Invoke(null);
		return false;
	}

	public bool InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent = null, bool instantiateInWorldSpace = false, Action<GameObject> onLoad = null)
	{
		if (key == null) return false;
		Key = key;
		LoadState = E_LoadState.Loading;

		GameObject prefab = AddressableShim.LoadAsset<GameObject>(key.ToString());
		if (prefab != null)
		{
			GameObject instance = UnityEngine.Object.Instantiate(prefab, position, rotation, parent);
			LoadObject = instance;
			LoadState = E_LoadState.Loaded;
			onLoad?.Invoke(instance);
			return true;
		}

		LoadState = E_LoadState.Ready;
		onLoad?.Invoke(null);
		return false;
	}

	public bool CheckSameKey(object key)
	{
		if (Key == null || key == null) return false;
		return Key.ToString() == key.ToString();
	}

	private void OnLoadComp(AsyncOperationHandle<GameObject> handle, Action<GameObject> onLoad)
	{
		if (handle.Status == AsyncOperationStatus.Succeeded)
		{
			LoadObject = handle.Result;
			LoadState = E_LoadState.Loaded;
			onLoad?.Invoke(handle.Result);
		}
		else
		{
			LoadState = E_LoadState.Ready;
			onLoad?.Invoke(null);
		}
	}

	public void Release()
	{
		if (LoadObject != null)
		{
			UnityEngine.Object.Destroy(LoadObject);
			LoadObject = null;
		}
		LoadState = E_LoadState.Ready;
		Key = null;
	}
}
