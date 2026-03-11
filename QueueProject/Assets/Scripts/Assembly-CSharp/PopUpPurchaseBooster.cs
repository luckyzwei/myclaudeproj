using System;
using Balancy;
using Balancy.Models.SmartObjects;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopUpPurchaseBooster : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/PopUps/Popup-PurchaseBooster";

	private const string REWARD_POPUP = "Prefabs/KWReward/Popup-AutoReward";

	[SerializeField]
	private Text m_boosterNameText;

	[SerializeField]
	private Text m_descText;

	[SerializeField]
	private Text m_priceText;

	[SerializeField]
	private Image[] m_boosterIconImages;

	[SerializeField]
	private Text[] m_packCountTexts;

	[SerializeField]
	private GameObject[] m_panels;

	[SerializeField]
	private BoosterPurchaseButton[] m_buttons;

	private Action m_successCallback;

	private Action m_vfxFinishCallback;

	private string m_boosterClientID;

	public void Config(ItemWithAmount[] unitPrice, string clientID, UnnyObject sprite, Action successCallback, Action vfxFinishCallback)
	{
	}

	public void OnButtonClicked(PriceType priceType, int price, int count)
	{
	}

	private void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private int RoundUp(int price, int round)
	{
		return 0;
	}

	public void BuyWithRvClicked(int count)
	{
	}

	public void BuyWithCoinClicked(int price, int count)
	{
	}

	private void GiveReward(int price, int count, bool rvUsed)
	{
	}

	public void ClosePurchaseBooster()
	{
	}
}
