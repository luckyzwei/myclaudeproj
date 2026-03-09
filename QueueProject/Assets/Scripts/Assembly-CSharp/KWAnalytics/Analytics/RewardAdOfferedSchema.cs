using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class RewardAdOfferedSchema : OpenSchema
	{
		public int OfferedCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override bool RequiresJoinKey()
		{
			return false;
		}

		protected override string GetUniqueKeyForJoin()
		{
			return null;
		}
	}
}
