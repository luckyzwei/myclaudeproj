using UnityEngine;
using UnityEngine.UI;

namespace Anzu.Examples
{
	public class Hold : InteractBase
	{
		public float _holdDuration;

		public Image _progressIndicator;

		public Vector3 _indicatorOffset;

		private float _holdProgressTime;

		private bool _isHoldComplete;

		private bool _isHoldingActive;

		protected override void HandleClickLogic()
		{
		}

		private void StartHold()
		{
		}

		private void UpdateProgress()
		{
		}

		private void CompleteHold()
		{
		}

		private void ResetHold()
		{
		}

		private void CancelHold()
		{
		}
	}
}
