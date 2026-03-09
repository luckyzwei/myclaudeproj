using System;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressablePreLoader : AddressableLoaderBase
{
	private AsyncOperationHandle m_preloadAsyncOperation;

	public AddressablePreLoader(List<string> toPreload, Addressables.MergeMode mergeMode, Action completeCallback)
	{
	}

	public AddressablePreLoader(string toPreload, Action completeCallback)
	{
	}

	private void OnLocationsGeneratedCallback(IList<string> locations)
	{
	}

	private void DownloadDependencies(IList<string> locations)
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
}
