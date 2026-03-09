using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class RatingAdapter : Rating
	{
		[SerializeField]
		private bool enabled;

		[SerializeField]
		private int ratingReviewThreshold;

		[SerializeField]
		private int showAfterXGames;

		[SerializeField]
		private string appstoreAndroidURL;

		[SerializeField]
		private string appstoreIOSURL;

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

		public override int RatingReviewThreshold
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

		public override string AppstoreAndroidURL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AppstoreIOSURL
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
