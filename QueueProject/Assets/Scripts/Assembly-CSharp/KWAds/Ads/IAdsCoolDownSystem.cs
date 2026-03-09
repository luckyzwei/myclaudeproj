namespace KWAds.Ads
{
	public interface IAdsCoolDownSystem
	{
		bool CheckIntLocationAndCoolDown(string location, out bool canShowAdBreakPopup, out string rejectionCause, bool isConsecutiveAd, double impressionRevenue = 0.0, bool isProviderNoFill = false, bool skipCooldown = false, bool isCrossAdCall = false);

		void Dispose();
	}
}
