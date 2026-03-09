using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KWCore.Loading
{
	public class LoadingManager
	{
		private class LoadingDependency
		{
			public float weight;

			public bool waitUntilUnregistered;

			public bool showLoadingUntilUnregistered;

			public bool completed;

			public float progress;

			public LoadingDependency(float weight, bool waitUntilUnregistered, bool showLoadingUntilUnregistered)
			{
			}

			public void MarkAsCompleted()
			{
			}

			public void SetProgress(float progress)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCountdownTimerCoroutine_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float timeoutSeconds;

			public LoadingManager _003C_003E4__this;

			private float _003CtimeRemaining_003E5__2;

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
			public _003CCountdownTimerCoroutine_003Ed__45(int _003C_003E1__state)
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
		private sealed class _003CHandleLoadingStart_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadingManager _003C_003E4__this;

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
			public _003CHandleLoadingStart_003Ed__49(int _003C_003E1__state)
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
		private sealed class _003CLoadSceneAsync_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadingManager _003C_003E4__this;

			public string sceneName;

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
			public _003CLoadSceneAsync_003Ed__57(int _003C_003E1__state)
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

		private const float SCENE_LOADED_THRESHOLD = 0.9f;

		private const string SCENE_LOAD_REGISTER_ID = "SceneLoadingAsync";

		private const float MAX_LOAD_TIME_SUBSEQUENT_BOOT_SECONDS = 1f;

		private const float LOADING_INVOKE_DELAY = 1f;

		private readonly LoadingInterface m_loadingInterface;

		private readonly Action m_onBeforeSceneLoadedCallback;

		private readonly Dictionary<object, LoadingDependency> m_loadingDependencies;

		private bool m_hasLoadingStarted;

		private bool m_maxLoadTimeReached;

		private bool m_hasShownLoadedScene;

		private bool m_hasLoaded;

		private float m_loadingProgress;

		private bool m_gameSettingsReceived;

		private bool m_gameLoadedAnalyticSent;

		private GameObject m_loadingScreen;

		private Coroutine m_maxLoadTimeReachedCoroutine;

		public bool IsLoaded => false;

		public float Progress => 0f;

		public long LoadingStartTimestamp { get; private set; }

		public static event Action OnLoadingStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnLoadingCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action OnMaxLoadingTimeExceeded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<float> OnProgressUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public LoadingManager(LoadingInterface loadingInterface, Action onBeforeSceneLoadedCallback)
		{
		}

		public void Initialise()
		{
		}

		public void Register(object obj, float weight = 1f, bool waitUntilUnregistered = false, bool showLoadingUntilUnregistered = false)
		{
		}

		private void RegisterSync(object obj, float weight, bool waitUntilUnregistered, bool showLoadingUntilUnregistered)
		{
		}

		public void Unregister(object obj)
		{
		}

		private void UnregisterSync(object obj)
		{
		}

		public void SetProgress(object obj, float progress)
		{
		}

		private void StartTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CCountdownTimerCoroutine_003Ed__45))]
		private IEnumerator CountdownTimerCoroutine(float timeoutSeconds)
		{
			return null;
		}

		private void OnMaxLoadTimeReached()
		{
		}

		private void ShowSplashScreen()
		{
		}

		private void ShowLoadingScreen()
		{
		}

		[IteratorStateMachine(typeof(_003CHandleLoadingStart_003Ed__49))]
		private IEnumerator HandleLoadingStart()
		{
			return null;
		}

		private void CheckShowLoadedScene()
		{
		}

		private bool ShouldShowLoadedScene()
		{
			return false;
		}

		private void CheckLoadingCompleted()
		{
		}

		private bool IsLoadedSceneReady()
		{
			return false;
		}

		private bool ShouldWaitForGameplayCanvas()
		{
			return false;
		}

		private bool ShouldWaitForDependenciesInLoadedScene()
		{
			return false;
		}

		private void LoadScene()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadSceneAsync_003Ed__57))]
		private IEnumerator LoadSceneAsync(string sceneName)
		{
			return null;
		}

		private void CompleteLoading()
		{
		}

		private void UpdateLoadingProgress()
		{
		}

		private float CalculateLoadingProgress()
		{
			return 0f;
		}

		private void HandleGameSettingsUpdated()
		{
		}

		private void SendGameLoadedAnalyticEvent()
		{
		}

		private void TriggerLoadingEvents()
		{
		}
	}
}
