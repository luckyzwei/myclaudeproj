using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemCarMarket : MonoBehaviour
{
	[SerializeField]
	private Image CarImg;

	[SerializeField]
	private Image CarLogo;

	[SerializeField]
	private Text CarName;

	[SerializeField]
	private Text CarDesc;

	[SerializeField]
	private Text PointRewardCount;

	[SerializeField]
	private Image PriceIcon;

	[SerializeField]
	private Text Price;

	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private Button OwnBtn;

	[SerializeField]
	private GameObject OwnObj;

	[Header("ManagerKey")]
	[SerializeField]
	private GameObject ManagerKeyObj;

	[SerializeField]
	private Image ManagerKeyIcon;

	[SerializeField]
	private Text ManagerKeyText;

	[Header("UnlockCompany")]
	[SerializeField]
	private GameObject UnlockCompanyObj;

	[SerializeField]
	private Image UnlockCompanyImage;

	[Header("Buff")]
	[SerializeField]
	private GameObject BuffObj;

	[SerializeField]
	private Image BuffIcon;

	[SerializeField]
	private Text BuffText;

	private int CarIdx;

	private Action<int> BuyCarCallback;

	private void Awake()
	{
	}

	public void Set(int carIdx, Action<int> buyCarCallback = null)
	{
	}

	private void SetUnlockComponyBubble(int carIdx, bool isNew)
	{
	}

	private void OnClickPurchase()
	{
	}

	private void OnClickGotoHouse()
	{
	}
}
