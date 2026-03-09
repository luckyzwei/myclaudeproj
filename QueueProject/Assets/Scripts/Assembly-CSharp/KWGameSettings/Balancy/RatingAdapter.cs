using System;

namespace KWGameSettings.Balancy
{
	[Serializable]
	public class RatingAdapter : Rating
	{
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
