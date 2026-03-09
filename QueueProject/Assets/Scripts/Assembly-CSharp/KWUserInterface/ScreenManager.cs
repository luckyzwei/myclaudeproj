using System.Collections.Generic;
using KWCore.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace KWUserInterface
{
	public class ScreenManager : MonoSingleton<ScreenManager>
	{
		private Canvas m_canvas;

		private CanvasScaler m_canvasScaler;

		private Stack<Screen> m_screenStack;

		private List<Screen> m_screensToDestory;

		protected override void Init()
		{
			m_screenStack = new Stack<Screen>();
			m_screensToDestory = new List<Screen>();
			m_canvas = GetComponentInChildren<Canvas>();
			if (m_canvas != null)
			{
				m_canvasScaler = m_canvas.GetComponent<CanvasScaler>();
			}
		}

		public Stack<Screen> GetScreenStack()
		{
			return m_screenStack;
		}

		public int GetScreenStackCount()
		{
			return m_screenStack != null ? m_screenStack.Count : 0;
		}

		public Screen GetCurrentScreen()
		{
			if (m_screenStack != null && m_screenStack.Count > 0)
			{
				return m_screenStack.Peek();
			}
			return null;
		}

		private Screen GetScreenModel(string prefabName)
		{
			GameObject prefab = Resources.Load<GameObject>(prefabName);
			if (prefab != null)
			{
				return prefab.GetComponent<Screen>();
			}
			return null;
		}

		public Screen PushScreen(string screenDir, bool pushBehind = true, bool disablePreviousScreen = true)
		{
			Screen screenModel = GetScreenModel(screenDir);
			if (screenModel == null)
			{
				Debug.LogError("ScreenManager: Could not find screen prefab: " + screenDir);
				return null;
			}
			Screen newScreen = Instantiate(screenModel);
			return PushScreen(newScreen, pushBehind, disablePreviousScreen);
		}

		public Screen ReplaceScreen(string screenDir, bool pushBehind = true)
		{
			Screen screenModel = GetScreenModel(screenDir);
			if (screenModel == null)
			{
				Debug.LogError("ScreenManager: Could not find screen prefab: " + screenDir);
				return null;
			}
			Screen newScreen = Instantiate(screenModel);
			return ReplaceScreen(newScreen, pushBehind);
		}

		public Screen ReplaceAllScreens(string screenDir)
		{
			Screen screenModel = GetScreenModel(screenDir);
			if (screenModel == null)
			{
				Debug.LogError("ScreenManager: Could not find screen prefab: " + screenDir);
				return null;
			}
			Screen newScreen = Instantiate(screenModel);
			return ReplaceAllScreens(newScreen);
		}

		public void ReplaceScreenAtStackLevel(string screenDir, int stackLevel)
		{
			Screen screenModel = GetScreenModel(screenDir);
			if (screenModel == null)
			{
				Debug.LogError("ScreenManager: Could not find screen prefab: " + screenDir);
				return;
			}
			Screen newScreen = Instantiate(screenModel);
			ReplaceScreenAtStackLevel(newScreen, stackLevel);
		}

		public Screen PushScreen(Screen screen, bool pushBehind = true, bool disablePreviousScreen = true)
		{
			if (screen == null) return null;

			Screen prevScreen = GetCurrentScreen();

			if (m_canvas != null)
			{
				screen.transform.SetParent(m_canvas.transform, false);
			}

			if (pushBehind && prevScreen != null)
			{
				screen.transform.SetAsLastSibling();
			}

			screen.PreLoad();
			m_screenStack.Push(screen);

			DoScreenSwap(prevScreen, screen, disablePreviousScreen);

			return screen;
		}

		public Screen PopScreen()
		{
			if (m_screenStack == null || m_screenStack.Count == 0)
			{
				return null;
			}

			Screen poppedScreen = m_screenStack.Pop();
			Screen nextScreen = GetCurrentScreen();

			if (nextScreen != null)
			{
				nextScreen.gameObject.SetActive(true);
			}

			poppedScreen.Unload(nextScreen, (s) =>
			{
				Destroy(s.gameObject);
			});

			if (nextScreen != null)
			{
				nextScreen.Load(poppedScreen);
			}

			return nextScreen;
		}

		public Screen ReplaceScreen(Screen screen, bool pushBehind = true)
		{
			if (m_screenStack != null && m_screenStack.Count > 0)
			{
				Screen oldScreen = m_screenStack.Pop();
				oldScreen.Unload(screen, (s) =>
				{
					Destroy(s.gameObject);
				});
			}
			return PushScreen(screen, pushBehind, false);
		}

		public Screen ReplaceScreenAtStackLevel(Screen screen, int stackLevel)
		{
			if (m_screenStack == null || screen == null) return null;

			// Rebuild stack, replacing the screen at the given level
			var tempList = new List<Screen>(m_screenStack);
			tempList.Reverse(); // Stack enumerates top-first, reverse to get bottom-first

			if (stackLevel >= 0 && stackLevel < tempList.Count)
			{
				Screen oldScreen = tempList[stackLevel];
				oldScreen.Unload(screen, (s) =>
				{
					Destroy(s.gameObject);
				});
				tempList[stackLevel] = screen;

				if (m_canvas != null)
				{
					screen.transform.SetParent(m_canvas.transform, false);
				}
				screen.PreLoad();
				screen.Load(null);
			}

			m_screenStack.Clear();
			for (int i = 0; i < tempList.Count; i++)
			{
				m_screenStack.Push(tempList[i]);
			}

			// Re-reverse so top of stack is correct
			var finalList = new List<Screen>(m_screenStack);
			m_screenStack.Clear();
			for (int i = finalList.Count - 1; i >= 0; i--)
			{
				m_screenStack.Push(finalList[i]);
			}

			return screen;
		}

		public Screen ReplaceAllScreens(Screen screen)
		{
			if (m_screenStack != null)
			{
				while (m_screenStack.Count > 0)
				{
					Screen oldScreen = m_screenStack.Pop();
					oldScreen.Unload(screen, (s) =>
					{
						Destroy(s.gameObject);
					});
				}
			}
			return PushScreen(screen, false, false);
		}

		public void SetRootCanvas(Canvas canvas)
		{
			m_canvas = canvas;
			if (m_canvas != null)
			{
				m_canvasScaler = m_canvas.GetComponent<CanvasScaler>();
			}
		}

		private void DoScreenSwap(Screen prevScreen, Screen newScreen, bool disablePreviousScreen = false)
		{
			if (newScreen != null)
			{
				newScreen.Load(prevScreen);
			}

			if (prevScreen != null && disablePreviousScreen)
			{
				prevScreen.gameObject.SetActive(false);
			}
		}

		private bool IsScreenAlreadyPresent(Screen screen)
		{
			if (m_screenStack == null || screen == null) return false;

			foreach (var s in m_screenStack)
			{
				if (s == screen)
					return true;
			}
			return false;
		}

		public Canvas GetCanvas()
		{
			return m_canvas;
		}

		public Vector2 GetCanvasRefResolution()
		{
			if (m_canvasScaler != null)
			{
				return m_canvasScaler.referenceResolution;
			}
			return default(Vector2);
		}

		public Vector2 GetCanvasResolution()
		{
			if (m_canvas != null)
			{
				RectTransform rt = m_canvas.GetComponent<RectTransform>();
				if (rt != null)
				{
					return rt.sizeDelta;
				}
			}
			return default(Vector2);
		}
	}
}
