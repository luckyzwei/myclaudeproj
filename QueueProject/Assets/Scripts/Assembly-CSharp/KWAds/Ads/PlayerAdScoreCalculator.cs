using System.Collections.Generic;
using KWCore.Stats;
using KWGameSettings;

namespace KWAds.Ads
{
	public static class PlayerAdScoreCalculator
	{
		public static double CalculatePlayerAdScore(AdsPlayerAdScore playerAdScoreSettings, double impressionRevenue)
		{
			return 0.0;
		}

		private static double CalculateMetricAdScore(AdsScoreCoeficient coefficient, double weightsSum, double impressionRevenue, long maxAdTimeCompensation)
		{
			return 0.0;
		}

		private static double CalculateMetricRatio(AdsScoreCoeficient coefficient, long maxAdTimeCompensation, double impressionRevenue)
		{
			return 0.0;
		}

		private static double CalculateAdPlayRatio(long windowLength, long maxAdTimeCompensation)
		{
			return 0.0;
		}

		private static double CalculateRewardAdPlayRatio(long windowLength)
		{
			return 0.0;
		}

		private static double CalculateLoadedAdRelativeValueRatio(double impressionRevenue, double relativeWeight)
		{
			return 0.0;
		}

		private static long GetEventTotalDuration(List<TimeEvent> eventsTimeline, TimeEventType evenType, long windowStartTime, long windowEndTime)
		{
			return 0L;
		}
	}
}
