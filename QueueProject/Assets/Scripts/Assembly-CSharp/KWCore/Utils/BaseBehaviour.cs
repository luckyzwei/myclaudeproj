using UnityEngine;

namespace KWCore.Utils
{
	public abstract class BaseBehaviour : MonoBehaviour
	{
		protected virtual void OnDestroy()
		{
		}

		protected void CancelRequests()
		{
		}
	}
}
