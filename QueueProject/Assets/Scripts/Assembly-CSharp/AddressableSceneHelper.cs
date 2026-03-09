using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.Utils;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class AddressableSceneHelper : MonoSingleton<AddressableSceneHelper>
{
	[CompilerGenerated]
	private sealed class _003CLoadScene_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AsyncOperationHandle<SceneInstance> asyncOperationHandle;

		public Action<float> progressCallback;

		public AddressableSceneHelper _003C_003E4__this;

		public Action finishedCallback;

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
		public _003CLoadScene_003Ed__6(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CUnloadScene_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AsyncOperationHandle<SceneInstance> asyncOperationHandle;

		public AddressableSceneHelper _003C_003E4__this;

		public string scenePath;

		public Action finishedCallback;

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
		public _003CUnloadScene_003Ed__7(int _003C_003E1__state)
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

	private Dictionary<string, SceneInstance> m_loadedLevels;

	private void Awake()
	{
	}

	protected override void Init()
	{
	}

	public void LoadScene(string scenePath, LoadSceneMode loadSceneMode = LoadSceneMode.Additive, Action finishedCallback = null, Action<float> progressCallback = null)
	{
	}

	public void UnloadScene(string scenePath, Action finishedCallback = null)
	{
	}

	public void UnloadAllScenes(Action finishedCallback = null)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadScene_003Ed__6))]
	private IEnumerator LoadScene(AsyncOperationHandle<SceneInstance> asyncOperationHandle, Action finishedCallback, Action<float> progressCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CUnloadScene_003Ed__7))]
	private IEnumerator UnloadScene(string scenePath, AsyncOperationHandle<SceneInstance> asyncOperationHandle, Action finishedCallback)
	{
		return null;
	}
}
