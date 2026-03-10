using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

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
				this.weight = weight;
				this.waitUntilUnregistered = waitUntilUnregistered;
				this.showLoadingUntilUnregistered = showLoadingUntilUnregistered;
				this.completed = false;
				this.progress = 0f;
			}

			public void MarkAsCompleted()
			{
				completed = true;
				progress = 1f;
			}

			public void SetProgress(float progress)
			{
				this.progress = Mathf.Clamp01(progress);
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
				[DebuggerHidden] get { return _003C_003E2__current; }
			}

			object IEnumerator.Current
			{
				[DebuggerHidden] get { return _003C_003E2__current; }
			}

			[DebuggerHidden]
			public _003CCountdownTimerCoroutine_003Ed__45(int _003C_003E1__state)
			{
				this._003C_003E1__state = _003C_003E1__state;
			}

			[DebuggerHidden]
			void IDisposable.Dispose() { }

			private bool MoveNext()
			{
				switch (_003C_003E1__state)
				{
					case 0:
						_003C_003E1__state = -1;
						_003CtimeRemaining_003E5__2 = timeoutSeconds;
						goto case 1;
					case 1:
						if (_003CtimeRemaining_003E5__2 > 0f)
						{
							_003C_003E2__current = null;
							_003C_003E1__state = 1;
							_003CtimeRemaining_003E5__2 -= Time.deltaTime;
							return true;
						}
						_003C_003E1__state = -1;
						_003C_003E4__this.OnMaxLoadTimeReached();
						return false;
					default:
						return false;
				}
			}

			bool IEnumerator.MoveNext()
			{
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset() { }
		}

		[CompilerGenerated]
		private sealed class _003CHandleLoadingStart_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;
			private object _003C_003E2__current;
			public LoadingManager _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden] get { return _003C_003E2__current; }
			}

			object IEnumerator.Current
			{
				[DebuggerHidden] get { return _003C_003E2__current; }
			}

			[DebuggerHidden]
			public _003CHandleLoadingStart_003Ed__49(int _003C_003E1__state)
			{
				this._003C_003E1__state = _003C_003E1__state;
			}

			[DebuggerHidden]
			void IDisposable.Dispose() { }

			private bool MoveNext()
			{
				switch (_003C_003E1__state)
				{
					case 0:
						_003C_003E1__state = -1;
						_003C_003E4__this.ShowSplashScreen();
						_003C_003E2__current = new WaitForSeconds(LOADING_INVOKE_DELAY);
						_003C_003E1__state = 1;
						return true;
					case 1:
						_003C_003E1__state = -1;
						_003C_003E4__this.LoadScene();
						_003C_003E4__this.StartTimer();
						_OnLoadingStarted?.Invoke();
						return false;
					default:
						return false;
				}
			}

			bool IEnumerator.MoveNext()
			{
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset() { }
		}

		[CompilerGenerated]
		private sealed class _003CLoadSceneAsync_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;
			private object _003C_003E2__current;
			public LoadingManager _003C_003E4__this;
			public string sceneName;
			private AsyncOperation _003Cop_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden] get { return _003C_003E2__current; }
			}

			object IEnumerator.Current
			{
				[DebuggerHidden] get { return _003C_003E2__current; }
			}

			[DebuggerHidden]
			public _003CLoadSceneAsync_003Ed__57(int _003C_003E1__state)
			{
				this._003C_003E1__state = _003C_003E1__state;
			}

			[DebuggerHidden]
			void IDisposable.Dispose() { }

			private bool MoveNext()
			{
				switch (_003C_003E1__state)
				{
					case 0:
						_003C_003E1__state = -1;
						_003Cop_003E5__2 = SceneManager.LoadSceneAsync(sceneName);
						if (_003Cop_003E5__2 == null)
						{
							UnityEngine.Debug.LogError($"[LoadingManager] Failed to load scene: {sceneName}");
							return false;
						}
						_003Cop_003E5__2.allowSceneActivation = true;
						goto case 1;
					case 1:
						if (!_003Cop_003E5__2.isDone)
						{
							_003C_003E4__this.SetProgress(SCENE_LOAD_REGISTER_ID, _003Cop_003E5__2.progress / SCENE_LOADED_THRESHOLD);
							_003C_003E2__current = null;
							_003C_003E1__state = 1;
							return true;
						}
						_003C_003E1__state = -1;
						_003C_003E4__this.Unregister(SCENE_LOAD_REGISTER_ID);
						_003C_003E4__this.m_onBeforeSceneLoadedCallback?.Invoke();
						return false;
					default:
						return false;
				}
			}

			bool IEnumerator.MoveNext()
			{
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset() { }
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

		private static Action _OnLoadingStarted;
		private static Action _OnLoadingCompleted;
		private static Action _OnMaxLoadingTimeExceeded;
		private static Action<float> _OnProgressUpdated;

		public bool IsLoaded => m_hasLoaded;

		public float Progress => m_loadingProgress;

		public long LoadingStartTimestamp { get; private set; }

		public static event Action OnLoadingStarted
		{
			add { _OnLoadingStarted += value; }
			remove { _OnLoadingStarted -= value; }
		}

		public static event Action OnLoadingCompleted
		{
			add { _OnLoadingCompleted += value; }
			remove { _OnLoadingCompleted -= value; }
		}

		public static event Action OnMaxLoadingTimeExceeded
		{
			add { _OnMaxLoadingTimeExceeded += value; }
			remove { _OnMaxLoadingTimeExceeded -= value; }
		}

		public static event Action<float> OnProgressUpdated
		{
			add { _OnProgressUpdated += value; }
			remove { _OnProgressUpdated -= value; }
		}

		public LoadingManager(LoadingInterface loadingInterface, Action onBeforeSceneLoadedCallback)
		{
			m_loadingInterface = loadingInterface;
			m_onBeforeSceneLoadedCallback = onBeforeSceneLoadedCallback;
			m_loadingDependencies = new Dictionary<object, LoadingDependency>();
		}

		public void Initialise()
		{
			LoadingStartTimestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			m_hasLoadingStarted = true;

			if (m_loadingInterface != null)
				CoroutineRunner.Run(HandleLoadingStart());
		}

		public void Register(object obj, float weight = 1f, bool waitUntilUnregistered = false, bool showLoadingUntilUnregistered = false)
		{
			RegisterSync(obj, weight, waitUntilUnregistered, showLoadingUntilUnregistered);
		}

		private void RegisterSync(object obj, float weight, bool waitUntilUnregistered, bool showLoadingUntilUnregistered)
		{
			if (m_loadingDependencies.ContainsKey(obj)) return;
			m_loadingDependencies[obj] = new LoadingDependency(weight, waitUntilUnregistered, showLoadingUntilUnregistered);
		}

		public void Unregister(object obj)
		{
			UnregisterSync(obj);
		}

		private void UnregisterSync(object obj)
		{
			if (m_loadingDependencies.TryGetValue(obj, out var dep))
			{
				dep.MarkAsCompleted();
				if (!dep.waitUntilUnregistered)
					m_loadingDependencies.Remove(obj);
			}
			UpdateLoadingProgress();
			CheckLoadingCompleted();
		}

		public void SetProgress(object obj, float progress)
		{
			if (m_loadingDependencies.TryGetValue(obj, out var dep))
			{
				dep.SetProgress(progress);
				UpdateLoadingProgress();
			}
		}

		private void StartTimer()
		{
			float timeout = m_loadingInterface != null ? m_loadingInterface.maxLoadTimeFirstBootSeconds : 30f;
			if (timeout > 0)
				m_maxLoadTimeReachedCoroutine = CoroutineRunner.Run(CountdownTimerCoroutine(timeout));
		}

		[IteratorStateMachine(typeof(_003CCountdownTimerCoroutine_003Ed__45))]
		private IEnumerator CountdownTimerCoroutine(float timeoutSeconds)
		{
			var d = new _003CCountdownTimerCoroutine_003Ed__45(0);
			d._003C_003E4__this = this;
			d.timeoutSeconds = timeoutSeconds;
			return d;
		}

		private void OnMaxLoadTimeReached()
		{
			m_maxLoadTimeReached = true;
			_OnMaxLoadingTimeExceeded?.Invoke();
			CheckShowLoadedScene();
		}

		private void ShowSplashScreen()
		{
			if (m_loadingInterface != null && m_loadingInterface.splashScreenPrefab != null)
			{
				GameObject.Instantiate(m_loadingInterface.splashScreenPrefab);
			}
		}

		private void ShowLoadingScreen()
		{
			if (m_loadingInterface != null && m_loadingInterface.loadingScreenPrefab != null && m_loadingScreen == null)
			{
				m_loadingScreen = GameObject.Instantiate(m_loadingInterface.loadingScreenPrefab);
			}
		}

		[IteratorStateMachine(typeof(_003CHandleLoadingStart_003Ed__49))]
		private IEnumerator HandleLoadingStart()
		{
			var d = new _003CHandleLoadingStart_003Ed__49(0);
			d._003C_003E4__this = this;
			return d;
		}

		private void CheckShowLoadedScene()
		{
			if (m_hasShownLoadedScene) return;
			if (ShouldShowLoadedScene())
			{
				m_hasShownLoadedScene = true;
				if (m_loadingScreen != null)
				{
					GameObject.Destroy(m_loadingScreen);
					m_loadingScreen = null;
				}
				KWCore.Events.CoreEvents.SendOnSplashScreenCompleted();
			}
		}

		private bool ShouldShowLoadedScene()
		{
			if (!m_maxLoadTimeReached) return false;
			if (ShouldWaitForDependenciesInLoadedScene()) return false;
			if (ShouldWaitForGameplayCanvas()) return false;
			return true;
		}

		private void CheckLoadingCompleted()
		{
			if (m_hasLoaded) return;
			if (!IsLoadedSceneReady()) return;

			CompleteLoading();
		}

		private bool IsLoadedSceneReady()
		{
			foreach (var kv in m_loadingDependencies)
			{
				if (!kv.Value.completed)
					return false;
			}
			return true;
		}

		private bool ShouldWaitForGameplayCanvas()
		{
			return m_loadingInterface != null && m_loadingInterface.waitForGameplayCanvas;
		}

		private bool ShouldWaitForDependenciesInLoadedScene()
		{
			foreach (var kv in m_loadingDependencies)
			{
				if (kv.Value.showLoadingUntilUnregistered && !kv.Value.completed)
					return true;
			}
			return false;
		}

		private void LoadScene()
		{
			if (m_loadingInterface == null || string.IsNullOrEmpty(m_loadingInterface.sceneToLoad))
				return;

			Register(SCENE_LOAD_REGISTER_ID, 1f);
			CoroutineRunner.Run(LoadSceneAsync(m_loadingInterface.sceneToLoad));
		}

		[IteratorStateMachine(typeof(_003CLoadSceneAsync_003Ed__57))]
		private IEnumerator LoadSceneAsync(string sceneName)
		{
			var d = new _003CLoadSceneAsync_003Ed__57(0);
			d._003C_003E4__this = this;
			d.sceneName = sceneName;
			return d;
		}

		private void CompleteLoading()
		{
			m_hasLoaded = true;
			m_loadingProgress = 1f;
			_OnProgressUpdated?.Invoke(1f);
			_OnLoadingCompleted?.Invoke();
			CheckShowLoadedScene();
			SendGameLoadedAnalyticEvent();
		}

		private void UpdateLoadingProgress()
		{
			m_loadingProgress = CalculateLoadingProgress();
			_OnProgressUpdated?.Invoke(m_loadingProgress);
		}

		private float CalculateLoadingProgress()
		{
			if (m_loadingDependencies.Count == 0) return 1f;

			float totalWeight = 0f;
			float completedWeight = 0f;

			foreach (var kv in m_loadingDependencies)
			{
				totalWeight += kv.Value.weight;
				completedWeight += kv.Value.weight * kv.Value.progress;
			}

			return totalWeight > 0f ? completedWeight / totalWeight : 0f;
		}

		private void HandleGameSettingsUpdated()
		{
			m_gameSettingsReceived = true;
		}

		private void SendGameLoadedAnalyticEvent()
		{
			if (m_gameLoadedAnalyticSent) return;
			m_gameLoadedAnalyticSent = true;
		}

		private void TriggerLoadingEvents()
		{
			_OnLoadingStarted?.Invoke();
		}
	}
}
