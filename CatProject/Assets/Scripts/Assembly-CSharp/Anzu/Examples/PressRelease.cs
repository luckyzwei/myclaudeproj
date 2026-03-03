using UnityEngine;

namespace Anzu.Examples
{
	public class PressRelease : InteractBase
	{
		public float _distanceRadius;

		public float _releaseTimeout;

		private float _timeoutTimer;

		private bool _clickInProgress;

		private Vector2 _clickPosition;

		protected override void HandleClickLogic()
		{
		}

		private void RestClick()
		{
		}
	}
}
