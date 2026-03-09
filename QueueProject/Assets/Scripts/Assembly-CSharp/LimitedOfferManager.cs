using Balancy.Models;
using KWCore.Utils;

public class LimitedOfferManager : Singleton<LimitedOfferManager>
{
	protected override void Init()
	{
	}

	public LimitedOffer GetActiveOffer(GameLocation location, bool ignoreTrial = false)
	{
		return null;
	}

	private LimitedOfferGameEvent GetLimitedOfferEvent(string clientId)
	{
		return null;
	}

	public PopupSpecialOffer TryToShowLimitedOffer(GameLocation location, bool forceShow = false, bool userRequested = false)
	{
		return null;
	}

	private bool IsTrialActive(LimitedOffer offer)
	{
		return false;
	}

	public bool ShouldShowWidget(string offerId)
	{
		return false;
	}

	private bool HasTrial(LimitedOffer offer)
	{
		return false;
	}

	private bool IsTrialSeen(LimitedOffer offer)
	{
		return false;
	}

	public PopupSpecialOffer ShowPopup(LimitedOffer offer, bool userRequested = false)
	{
		return null;
	}

	private void SetLimitedOfferAsSeen(string clientId)
	{
	}

	public void SetLastLevelSeen(LimitedOffer offer, int level)
	{
	}

	public LimitedOfferGameEvent GetAssociatedActiveGameEvent(LimitedOffer offer)
	{
		return null;
	}

	public bool IsOfferActiveForTrial(FeatureTrial trial)
	{
		return false;
	}

	public LimitedOffer GetLimitedOfferForTrial(FeatureTrial trial)
	{
		return null;
	}
}
