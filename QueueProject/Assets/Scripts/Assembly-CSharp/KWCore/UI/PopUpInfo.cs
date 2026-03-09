using KWLocalisation.Localisation;
using UnityEngine;

namespace KWCore.UI
{
	[SortingLayer("PopUpInfo")]
	public class PopUpInfo : PopUpBase
	{
		[SerializeField]
		private TextMeshProWrapper m_bodyText;

		public virtual void Init(string bodyTextOverride)
		{
		}
	}
}
