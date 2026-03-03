using System;
using UnityEngine;

namespace SpriteShadersUltimate
{
	[Serializable]
	public class ColorFaderSSU : BaseFaderSSU
	{
		[Header("Range:")]
		[ColorUsage(true, true)]
		public Color fromValue;

		[ColorUsage(true, true)]
		public Color toValue;

		public ColorFaderSSU(string newName, Color newFrom, Color newTo)
		{
		}
	}
}
