using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class AudioAdapter : Audio
	{
		public override bool EnableMusic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool EnableSFX
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
