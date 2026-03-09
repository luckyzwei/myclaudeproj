using System.Collections.Generic;
using KWCore.Interface;
using KWCore.UI;
using UnityEngine;

namespace KWCore.Input
{
	public class KWInputController : MonoBehaviour
	{
		private bool[] m_mouseDown;

		private bool[] m_mouseDownThisFrame;

		private bool[] m_mouseUpThisFrame;

		private bool m_interstitialShowing;

		private List<PopUpBase> m_showingPopUps;

		private int m_maxFingerCount;

		private bool m_stopInputDuringAds;

		private List<PopUpBase> m_popUpsToStopInput;

		private Dictionary<int, int> m_fingerIdToIndexMap;

		private Queue<int> m_indexPool;

		public void Initialise(CoreInputInterface inputInterface)
		{
		}

		public Vector3 GetMousePosition(int finger)
		{
			return default(Vector3);
		}

		private void CoreEventsPopupShown(PopUpBase popUpShown)
		{
		}

		private void CoreEventsPopupClosed(PopUpBase popUp)
		{
		}

		private void AdEventsAboutToShow()
		{
		}

		private void AdEventsAdShown(string location)
		{
		}

		private void AdEventsAdFailedShow()
		{
		}

		private void Update()
		{
		}

		private bool AllowInput(bool[] buttonArray, int button)
		{
			return false;
		}

		private bool ShowingPopUp()
		{
			return false;
		}

		private void OnDestroy()
		{
		}

		public int GetAnyMouseButtonDown()
		{
			return 0;
		}

		public bool GetMouseButtonDown(int fingerIndex)
		{
			return false;
		}

		public int GetAnyMouseButtonUp()
		{
			return 0;
		}

		public bool GetMouseButtonUp(int fingerIndex)
		{
			return false;
		}

		public int GetAnyMouseButton()
		{
			return 0;
		}

		public bool GetMouseButton(int fingerIndex)
		{
			return false;
		}
	}
}
