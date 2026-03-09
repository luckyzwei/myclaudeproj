using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class FacebookSettingsAdapter : FacebookSettings
	{
		[SerializeField]
		private FacebookCustomEventsAdapter[] customEventsAdapter;

		public override FacebookCustomEventSettings[] CustomEvents
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
