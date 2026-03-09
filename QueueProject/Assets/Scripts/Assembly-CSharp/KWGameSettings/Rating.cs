using System;

namespace KWGameSettings
{
	[Serializable]
	public abstract class Rating
	{
		public abstract bool Enabled { get; set; }

		public abstract int RatingReviewThreshold { get; set; }

		public abstract int ShowAfterXGames { get; set; }

		public abstract string AppstoreAndroidURL { get; set; }

		public abstract string AppstoreIOSURL { get; set; }
	}
}
