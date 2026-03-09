using UnityEngine;

namespace KWCore.UI
{
	[SortingLayer("PopUpForceConnection")]
	public class PopUpForceConnection : PopUpBase
	{
		[SerializeField]
		private bool m_autoCloseWhenConnection;

		private const float CHECK_TIME = 1f;

		private float m_timer;

		private void Update()
		{
		}

		protected override bool AllowHardBackButtonPress()
		{
			return false;
		}
	}
}
