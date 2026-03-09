using System.Collections.Generic;
using KWCore.UI;
using UnityEngine;

namespace KWCore.Interface
{
	public class CoreInputInterface : MonoBehaviour
	{
		[SerializeField]
		private int m_maxFingerCount;

		[SerializeField]
		private bool m_stopInputDuringAds;

		[SerializeField]
		private List<PopUpBase> m_popUpsToStopInput;

		public int GetMaxFingerCount()
		{
			return 0;
		}

		public bool GetStopInputDuringAds()
		{
			return false;
		}

		public List<PopUpBase> GetPopUpsToStopInput()
		{
			return null;
		}
	}
}
