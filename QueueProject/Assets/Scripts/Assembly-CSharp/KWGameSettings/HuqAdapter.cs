using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class HuqAdapter : Huq
	{
		[SerializeField]
		private bool enabled;

		[SerializeField]
		private string[] huqCountries;

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

		public override string[] HuqCountries
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
