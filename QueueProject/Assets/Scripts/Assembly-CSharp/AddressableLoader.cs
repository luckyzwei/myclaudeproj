using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableLoader : AddressableLoaderBase
{
	private AsyncOperationHandle m_loadingAsyncOperation;

	private Action<UnityEngine.Object> m_singleItemLoadedCallback;

	private List<UnityEngine.Object> m_loadedObjects;

	public AddressableLoader(List<string> toLoad, Addressables.MergeMode mergeMode, Action<UnityEngine.Object> individualObjectLoadedCallback, Action loadingCompleteCallback)
	{
	}

	public AddressableLoader(string toLoad, Action<UnityEngine.Object> loadingCompleteCallback)
	{
	}

	private void OnLocationsGeneratedCallback(IList<string> locations)
	{
	}

	private void Load(IList<string> locations)
	{
	}

	private void OnLoadingComplete(AsyncOperationHandle<IList<UnityEngine.Object>> handle)
	{
	}

	protected override void OnLoadingComplete(AsyncOperationHandle handle)
	{
	}

	public override float GetProgress()
	{
		return 0f;
	}

	public override string GetLoadingDescription()
	{
		return null;
	}

	public override bool IsDone()
	{
		return false;
	}

	public override void Release()
	{
	}

	public UnityEngine.Object GetLoadedObject()
	{
		return null;
	}

	public IList<UnityEngine.Object> GetLoadedObjects()
	{
		return null;
	}
}
