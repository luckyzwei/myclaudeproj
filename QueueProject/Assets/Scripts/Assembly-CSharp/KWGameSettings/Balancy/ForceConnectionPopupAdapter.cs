using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class ForceConnectionPopupAdapter : ForceConnectionPopup
	{
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
