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
	}

	public void LoadMoneyTexture(int regionIdx, Action<Texture2D> onComplete)
	{
	}

	public void LoadMoneyMaterial(int regionIdx, Action<Material> onComplete)
	{
	}

	public void ReleaseAllTextures()
	{
	}
}
