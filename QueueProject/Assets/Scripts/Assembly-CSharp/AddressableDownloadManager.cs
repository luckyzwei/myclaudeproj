using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.Utils;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

public class AddressableDownloadManager : MonoSingleton<AddressableDownloadManager>
{
	[CompilerGenerated]
	private sealed class _003CQueue_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddressableDownloadManager _003C_003E4__this;

		private AddressableDownloadData _003CaddressableDownloadData_003E5__2;

		private IList<IResourceLocation> _003Clocations_003E5__3;

		private AsyncOperationHandle _003CdownloadDependenciesAsync_003E5__4;

		private List<string>.Enumerator _003C_003E7__wrap4;

		private AsyncOperationHandle<IList<IResourceLocation>> _003CresourceLocationsAsync_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CQueue_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpdateCatalogsCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AddressableDownloadManager _003C_003E4__this;

		public Action callback;

		private AsyncOperationHandle<List<IResourceLocator>> _003CupdateHandle_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateCatalogsCoroutine_003Ed__17(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private Dictionary<string, AddressableDownloadData> m_queue;

	private List<string> m_catalogsToUpdate;

	private AddressableLoadingScreen m_loadingScreen;

	protected override void Init()
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void RegExceptionHandler(Action<AsyncOperationHandle, Exception> exAction)
	{
	}

	public void DeregExceptionHandler(Action<AsyncOperationHandle, Exception> exAction)
	{
	}

	private void AddressableExceptionHandler(AsyncOperationHandle handle, Exception exception)
	{
	}

	[IteratorStateMachine(typeof(_003CQueue_003Ed__9))]
	private IEnumerator Queue()
	{
		return null;
	}

	public void AddToQueue(AddressableDownloadData data)
	{
	}

	public void AddToQueue(List<AddressableDownloadData> data)
	{
	}

	public bool IsAssetInQueue(string path)
	{
		return false;
	}

	public void IsAssetDownloaded(string path, Action<bool> callback)
	{
	}

	private void GetDownloadSize(string path, Action<long> callback)
	{
	}

	public void ShowLoadingScreen(Action callbackWhenQueueEmpty = null)
	{
	}

	public void CheckCatalogsToUpdate(bool autoUpdate, Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateCatalogsCoroutine_003Ed__17))]
	private IEnumerator UpdateCatalogsCoroutine(Action callback = null)
	{
		return null;
	}

	public void NukeCache()
	{
	}
}
