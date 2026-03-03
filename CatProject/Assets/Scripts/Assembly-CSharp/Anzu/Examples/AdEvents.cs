using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using anzu;

namespace Anzu.Examples
{
	public class AdEvents : MonoBehaviour
	{
		public AnzuAd _anzuAd;

		public Slider _playbackSlider;

		public Slider _impressionSlider;

		[Header("Ad Data")]
		public int _totalEmpties;

		public int _totalImpressions;

		public float _playbackFullness;

		public float _impressionFullness;

		public double _currentAngleScore;

		public double _currentVisibilityScore;

		public double _currentViewabilityScore;

		public List<GameObject> _interferingColliders;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnPlaybackEmpty()
		{
		}

		private void OnPlaybackStarted()
		{
		}

		private void OnPlaybackCompleted()
		{
		}

		private void OnPlaybackInitiated()
		{
		}
	}
}
