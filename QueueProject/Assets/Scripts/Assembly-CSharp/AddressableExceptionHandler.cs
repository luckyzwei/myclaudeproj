using System;
using System.Collections.Generic;
using KWCore.Utils;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableExceptionHandler : MonoSingleton<AddressableExceptionHandler>
{
	private List<AddressableLoaderBase> m_loaders;

	protected override void Init()
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void HandleAddressableException(AsyncOperationHandle handle, Exception exception)
	{
	}

	public void RegExceptionHandler(Action<AsyncOperationHandle, Exception> exAction)
	{
	}

	public void DeregExceptionHandler(Action<AsyncOperationHandle, Exception> exAction)
	{
	}
}
