using System.Collections.Generic;
using KWCore.UI;
using UnityEngine;
using UnityEngine.Serialization;

namespace KWCore.Interface
{
	public class CoreUIInterface : MonoBehaviour, CoreUI.IDelegate
	{
		[SerializeField]
		private GameObject m_prefabInfoPopUp;

		[SerializeField]
		private GameObject m_prefabForceConnectionPopUp;

		[SerializeField]
		private GameObject m_prefabForceUpgradePopUp;

		[SerializeField]
		private GameObject m_prefabTermsOfUsePopup;

		[SerializeField]
		private GameObject m_socialFollowPopup;

		[SerializeField]
		private GameObject m_noAdsPopup;

		[FormerlySerializedAs("m_canvas")]
		[SerializeField]
		private Canvas m_coreCanvas;

		[Space]
		[SerializeField]
		[EventsQueueReadOnlyPriority]
		private List<string> m_queuePriorityOrder;

		private Canvas m_gameplayCanvas;

		public virtual GameObject GetInfoPopUp()
		{
			return null;
		}

		public virtual Canvas GetCoreCanvas()
		{
			return null;
		}

		public virtual Canvas GetGameplayCanvas()
		{
			return null;
		}

		public virtual void SetGameplayCanvas(Canvas canvas)
		{
		}

		public virtual GameObject GetForceConnectionPopUp()
		{
			return null;
		}

		public GameObject GetForceUpgradePopUp()
		{
			return null;
		}

		public List<string> GetQueuePriorityOrder()
		{
			return null;
		}

		public GameObject GetKwlaeeTermsOfUsePopup()
		{
			return null;
		}

		public GameObject GetSocialFollowPopup()
		{
			return null;
		}

		public GameObject GetNoAdsPopup()
		{
			return null;
		}
	}
}
