using System;
using UnityEngine;

namespace SpriteShadersUltimate
{
	[Serializable]
	public class FloatFaderSSU : BaseFaderSSU
	{
		[Header("Range:")]
		public float fromValue;

		public float toValue;

		public FloatFaderSSU(string newName, float newFrom, float newTo)
		{
		}
	}
}
