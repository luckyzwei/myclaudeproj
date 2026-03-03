using UnityEngine;
using anzu;

namespace Anzu.Examples
{
	public abstract class InteractBase : MonoBehaviour
	{
		public MeshRenderer _frameRenderer;

		protected AnzuAd _anzuAd;

		protected readonly Color _activeColor;

		protected readonly Color _inactiveColor;

		protected abstract void HandleClickLogic();

		protected void Awake()
		{
		}

		protected void Update()
		{
		}

		protected bool DidHitObject()
		{
			return false;
		}
	}
}
