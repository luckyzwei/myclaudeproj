using System;
using Balancy.Models.SmartObjects;
using KWCore.UI;

public abstract class RewardPopupBase : PopUpBase
{
	public abstract void Configure(Reward reward, Action rewardGivenCallback, object[] metaData);
}
