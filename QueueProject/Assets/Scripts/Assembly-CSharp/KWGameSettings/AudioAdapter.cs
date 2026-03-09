using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AudioAdapter : Audio
	{
		[SerializeField]
		private bool enableMusic;

		[SerializeField]
		private bool enableSFX;

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
