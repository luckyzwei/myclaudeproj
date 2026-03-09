using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.Utils;
using UnityEngine;

namespace KWLevels
{
	[HelpURL("http://wiki.kwalee.local/index.php?title=Scene_Handler")]
	public class SceneHandler : MonoSingleton<SceneHandler>
	{
		[CompilerGenerated]
		private sealed class _003CAfterSceneLoadedActions_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action scenarioLoaded;

			public SceneHandler _003C_003E4__this;

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
			public _003CAfterSceneLoadedActions_003Ed__34(int _003C_003E1__state)
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
		private sealed class _003CCleanCoroutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string scenarioId;

			public SceneHandler _003C_003E4__this;

			public Action levelCleanCallback;

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
			public _003CCleanCoroutine_003Ed__26(int _003C_003E1__state)
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
		private sealed class _003CGenerateScenarioInternalAsync_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneHandler _003C_003E4__this;

			public string scenarioId;

			public bool resetPosition;

			public bool keepSamePosition;

			public string[] scenes;

			public Action<float> progressUpdate;

			public Action scenarioLoaded;

			private float _003CtotalProgress_003E5__2;

			private string[] _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private AsyncOperation _003CsceneLoadOperation_003E5__5;

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
			public _003CGenerateScenarioInternalAsync_003Ed__30(int _003C_003E1__state)
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

		public const string MAIN_SCENE_PATH = "Assets/Scenes/MainScene.unity";

		public const string CPI_SCENE_PATH = "Assets/Scenes/CPIScene.unity";

		[SerializeField]
		private Vector3 m_sceneStartOffset;

		[SerializeField]
		private bool m_useOrientation;

		private Vector3 m_nextRootForward;

		private Vector3 m_nextRootPosition;

		private Vector3 m_lastScenarioStartPosition;

		private Dictionary<string, List<string>> m_loadedSceneNames;

		private Dictionary<string, List<SceneRoot>> m_loadedSceneRoots;

		private string m_currentLoadingStage;

		public Vector3 OrientationForNextRoot => default(Vector3);

		public Vector3 PositionForNextRoot => default(Vector3);

		public Vector3 LastScenarioStartPosition => default(Vector3);

		public bool IsUsingOrientation => false;

		protected override void Init()
		{
		}

		public void LoadScenario(string key, string scene, Action sceneLoaded = null, bool resetPosition = false, bool keepSamePos = false)
		{
		}

		public void LoadScenario(string key, string[] scenes, Action scenarioLoaded = null, bool resetPosition = false, bool keepSamePos = false)
		{
		}

		public void LoadScenarioAsync(string key, string scene, Action sceneLoaded = null, bool resetPosition = false, bool keepSamePos = false, Action<float> progressUpdate = null)
		{
		}

		public void LoadScenarioAsync(string key, string[] scenes, Action sceneLoaded = null, bool resetPosition = false, bool keepSamePos = false, Action<float> progressUpdate = null)
		{
		}

		public void UnloadScenario(string key, Action callback = null)
		{
		}

		public void UnloadAll(Action callback = null)
		{
		}

		public List<SceneRoot> GetAllRootsForScenario(string scenarioId)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCleanCoroutine_003Ed__26))]
		private IEnumerator CleanCoroutine(Action levelCleanCallback, string scenarioId)
		{
			return null;
		}

		private void UnloadStage(string scenarioid)
		{
		}

		private void GenerateScenarioInternal(string scenarioId, string[] scenes, Action scenarioLoaded, bool resetPosition, bool keepSamePosition)
		{
		}

		private void ConfigNextPosition(bool resetPosition, bool keepSamePosition)
		{
		}

		[IteratorStateMachine(typeof(_003CGenerateScenarioInternalAsync_003Ed__30))]
		private IEnumerator GenerateScenarioInternalAsync(string scenarioId, string[] scenes, Action scenarioLoaded, bool resetPosition, bool keepSamePosition, Action<float> progressUpdate = null)
		{
			return null;
		}

		private void AddSceneToLoadedDictionary(string sceneName, string scenarioId)
		{
		}

		private void LoadScene(string sceneName, string scenarioId)
		{
		}

		private AsyncOperation LoadSceneAsync(string sceneName, string scenarioId)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAfterSceneLoadedActions_003Ed__34))]
		private IEnumerator AfterSceneLoadedActions(Action scenarioLoaded)
		{
			return null;
		}

		public void RegisterRoot(SceneRoot newSceneRoot)
		{
		}
	}
}
