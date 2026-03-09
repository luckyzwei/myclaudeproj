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
		}

		public Stack<Screen> GetScreenStack()
		{
			return null;
		}

		public int GetScreenStackCount()
		{
			return 0;
		}

		public Screen GetCurrentScreen()
		{
			return null;
		}

		private Screen GetScreenModel(string prefabName)
		{
			return null;
		}

		public Screen PushScreen(string screenDir, bool pushBehind = true, bool disablePreviousScreen = true)
		{
			return null;
		}

		public Screen ReplaceScreen(string screenDir, bool pushBehind = true)
		{
			return null;
		}

		public Screen ReplaceAllScreens(string screenDir)
		{
			return null;
		}

		public void ReplaceScreenAtStackLevel(string screenDir, int stackLevel)
		{
		}

		public Screen PushScreen(Screen screen, bool pushBehind = true, bool disablePreviousScreen = true)
		{
			return null;
		}

		public Screen PopScreen()
		{
			return null;
		}

		public Screen ReplaceScreen(Screen screen, bool pushBehind = true)
		{
			return null;
		}

		public Screen ReplaceScreenAtStackLevel(Screen screen, int stackLevel)
		{
			return null;
		}

		public Screen ReplaceAllScreens(Screen screen)
		{
			return null;
		}

		public void SetRootCanvas(Canvas canvas)
		{
		}

		private void DoScreenSwap(Screen prevScreen, Screen newScreen, bool disablePreviousScreen = false)
		{
		}

		private bool IsScreenAlreadyPresent(Screen screen)
		{
			return false;
		}

		public Canvas GetCanvas()
		{
			return null;
		}

		public Vector2 GetCanvasRefResolution()
		{
			return default(Vector2);
		}

		public Vector2 GetCanvasResolution()
		{
			return default(Vector2);
		}
	}
}
