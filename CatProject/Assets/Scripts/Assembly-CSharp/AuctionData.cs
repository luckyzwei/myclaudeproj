using System;
using System.Collections.Generic;

public class AuctionData : IClientData
{
	public int EventIdx;

	public int Stamina;

	public DateTime StaminaChargingTime;

	public DateTime FreeStaminaTime;

	public DateTime AdStaminaTime;

	public int StaminaAdViewCount;

	public bool AuctionPassActive;

	public int AuctionScore;

	public List<int> ReceivePassReward;

	public List<int> ReceivePremiumPassReward;

	public bool PassPremiumBonusReceived;

	public Dictionary<int, int> OrganizeManager;

	public Dictionary<int, int> OrganizeCoin;

	public int EnemyIdx;

	public List<int> Enemys;

	public int Level;

	public int Tier;

	public int UseCoin;

	public bool FirstGuideView;

	public bool FirstGuideView2;

	public void Create()
	{
	}
}
