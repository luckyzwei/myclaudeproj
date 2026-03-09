using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class Audio
	{
		public abstract bool EnableMusic { get; set; }

		public abstract bool EnableSFX { get; set; }
	}
}
