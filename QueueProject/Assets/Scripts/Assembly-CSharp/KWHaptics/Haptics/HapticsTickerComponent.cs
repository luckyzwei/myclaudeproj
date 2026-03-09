using UnityEngine;

namespace KWHaptics.Haptics
{
	public class HapticsTickerComponent : MonoBehaviour
	{
		[SerializeField]
		private float m_minHapticGap;

		[SerializeField]
		private HapticsManager.HapticType m_hapticType;

		private float m_lastHapticTimeMS;

		public void PlayTickerHaptics()
		{
		}
	}
}
