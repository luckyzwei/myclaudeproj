using System.Collections.Generic;
using Crosstales.Common.Model.Enum;
using UnityEngine;

namespace Crosstales.Common.Util
{
	public class PlatformController : MonoBehaviour
	{
		[Header("Configuration")]
		[Tooltip("Selected platforms for the controller.")]
		public List<Platform> Platforms;

		[Tooltip("Enable or disable the 'Objects' for the selected 'Platforms' (default: true).")]
		public bool Active;

		[Header("GameObjects")]
		[Tooltip("Selected objects for the controller.")]
		public GameObject[] Objects;

		[Header("MonoBehaviour Scripts")]
		[Tooltip("Selected scripts for the controller.")]
		public MonoBehaviour[] Scripts;

		protected Platform _currentPlatform;

		protected virtual void Awake()
		{
		}

		private void Start()
		{
		}

		protected void selectPlatform()
		{
		}

		protected void activateGameObjects()
		{
		}

		protected void activateScripts()
		{
		}
	}
}
