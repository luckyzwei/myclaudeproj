using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class ForceConnectionPopupAdapter : ForceConnectionPopup
	{
		[SerializeField]
		private int showAfterXBoots;

		[SerializeField]
		private int showAfterXSessions;

		[SerializeField]
		private int showAfterXGames;

		[SerializeField]
		private bool enabled;

		public override int ShowAfterXBoots
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int ShowAfterXSessions
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int ShowAfterXGames
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
