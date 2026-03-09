using System;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public abstract class AddressableLoaderBase : ILoadingInterface
{
	protected Action m_loaderCompleteCallback;

	public AddressableLoaderBase(Action loaderCompleteCallback = null)
	{
	}

	public abstract float GetProgress();

	public abstract string GetLoadingDescription();

	public abstract bool IsDone();

	public abstract void Release();

	protected virtual void OnLoadingComplete(AsyncOperationHandle handle)
	{
	}

	protected void ConvertToLocationsAndLoad(IList<string> addresses, Action<IList<string>> locationCallback, Addressables.MergeMode mergeMode)
	{
	}

	protected void ConvertToLocationsAndLoad(string address, Action<IList<string>> locationCallback)
	{
	}
}
