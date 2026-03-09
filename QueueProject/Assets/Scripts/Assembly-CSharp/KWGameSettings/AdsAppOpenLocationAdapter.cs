using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsAppOpenLocationAdapter : OpenAdLocation
	{
		[SerializeField]
		private string location;

		[SerializeField]
		private bool canShow;

		[SerializeField]
		private float probability;

		public override string Location
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool CanShow
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override float Probability
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
