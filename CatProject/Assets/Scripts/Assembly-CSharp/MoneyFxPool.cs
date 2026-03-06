using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class MoneyFxPool : MonoBehaviour
{
	private enum E_LoadState
	{
		Ready = 0,
		Loading = 1,
		Loaded = 2
	}

	private class LoadData<T>
	{
		public E_LoadState LoadState;

		public T LoadedCache;

		public List<Action<T>> CompleteCallbacks;

		public AsyncOperationHandle<T> LoadHandle;
	}

	private static readonly string ADDRESSABLE_TEXTURE_PREFIX;

	private static readonly string ADDRESSABLE_MATERIAL_PREFIX;

	private Dictionary<int, LoadData<Texture2D>> LoadTextureMap;

	private Dictionary<int, LoadData<Material>> LoadMaterialMap;

	private void OnDestroy()
	{
		ReleaseAllTextures();
	}

	public void LoadMoneyTexture(int regionIdx, Action<Texture2D> onComplete)
	{
		if (LoadTextureMap == null)
			LoadTextureMap = new Dictionary<int, LoadData<Texture2D>>();

		if (LoadTextureMap.TryGetValue(regionIdx, out var data))
		{
			if (data.LoadState == E_LoadState.Loaded)
			{
				onComplete?.Invoke(data.LoadedCache);
				return;
			}
			if (data.LoadState == E_LoadState.Loading)
			{
				if (data.CompleteCallbacks == null)
					data.CompleteCallbacks = new List<Action<Texture2D>>();
				data.CompleteCallbacks.Add(onComplete);
				return;
			}
		}

		var loadData = new LoadData<Texture2D>();
		loadData.LoadState = E_LoadState.Loading;
		loadData.CompleteCallbacks = new List<Action<Texture2D>> { onComplete };
		LoadTextureMap[regionIdx] = loadData;

		string address = ADDRESSABLE_TEXTURE_PREFIX + regionIdx;
		var handle = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<Texture2D>(address);
		loadData.LoadHandle = handle;
		handle.Completed += (op) =>
		{
			loadData.LoadedCache = op.Result;
			loadData.LoadState = E_LoadState.Loaded;
			if (loadData.CompleteCallbacks != null)
			{
				foreach (var cb in loadData.CompleteCallbacks)
					cb?.Invoke(op.Result);
				loadData.CompleteCallbacks.Clear();
			}
		};
	}

	public void LoadMoneyMaterial(int regionIdx, Action<Material> onComplete)
	{
		if (LoadMaterialMap == null)
			LoadMaterialMap = new Dictionary<int, LoadData<Material>>();

		if (LoadMaterialMap.TryGetValue(regionIdx, out var data))
		{
			if (data.LoadState == E_LoadState.Loaded)
			{
				onComplete?.Invoke(data.LoadedCache);
				return;
			}
			if (data.LoadState == E_LoadState.Loading)
			{
				if (data.CompleteCallbacks == null)
					data.CompleteCallbacks = new List<Action<Material>>();
				data.CompleteCallbacks.Add(onComplete);
				return;
			}
		}

		var loadData = new LoadData<Material>();
		loadData.LoadState = E_LoadState.Loading;
		loadData.CompleteCallbacks = new List<Action<Material>> { onComplete };
		LoadMaterialMap[regionIdx] = loadData;

		string address = ADDRESSABLE_MATERIAL_PREFIX + regionIdx;
		var handle = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<Material>(address);
		loadData.LoadHandle = handle;
		handle.Completed += (op) =>
		{
			loadData.LoadedCache = op.Result;
			loadData.LoadState = E_LoadState.Loaded;
			if (loadData.CompleteCallbacks != null)
			{
				foreach (var cb in loadData.CompleteCallbacks)
					cb?.Invoke(op.Result);
				loadData.CompleteCallbacks.Clear();
			}
		};
	}

	public void ReleaseAllTextures()
	{
		if (LoadTextureMap != null)
		{
			foreach (var kvp in LoadTextureMap)
			{
				if (kvp.Value != null && kvp.Value.LoadHandle.IsValid())
					UnityEngine.AddressableAssets.Addressables.Release(kvp.Value.LoadHandle);
			}
			LoadTextureMap.Clear();
		}
		if (LoadMaterialMap != null)
		{
			foreach (var kvp in LoadMaterialMap)
			{
				if (kvp.Value != null && kvp.Value.LoadHandle.IsValid())
					UnityEngine.AddressableAssets.Addressables.Release(kvp.Value.LoadHandle);
			}
			LoadMaterialMap.Clear();
		}
	}
}
