using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopSpecialBanner : MonoBehaviour
{
	[SerializeField]
	private GameObject SaleRoot;

	[SerializeField]
	private Text SaleText;

	[SerializeField]
	private Text SalePrice;

	[SerializeField]
	private Text Price;

	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private List<ItemArticle> listItems;

	[SerializeField]
	private Text TitleText;

	public Action<int> ClickCb;

	public Action HideCb;

	public int Idx { get; private set; }

	private void Awake()
	{
	}

	public virtual void Init(int idx)
	{
	}

	public void SetRewardInfo(int[] rewardType, int[] rewardIdx, int[] rewardRegion, int[] rewardValue)
	{
	}

	public void OnClickBtn()
	{
	}
}
