using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class ConnectivityAdapter : Connectivity
	{
		[SerializeField]
		private ForceConnectionPopupAdapter forceConnectionPopup;

		public override ForceConnectionPopup ForceConnectionPopup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
