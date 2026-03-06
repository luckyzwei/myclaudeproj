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
		if (BuyBtn != null) BuyBtn.onClick.AddListener(OnClickBtn);
	}

	public virtual void Init(int idx)
	{
		Idx = idx;
		if (SaleRoot != null) SaleRoot.SetActive(false);
	}

	public void SetRewardInfo(int[] rewardType, int[] rewardIdx, int[] rewardRegion, int[] rewardValue)
	{
		if (listItems == null) return;
		for (int i = 0; i < listItems.Count; i++)
		{
			if (listItems[i] != null)
				listItems[i].gameObject.SetActive(i < rewardType.Length);
		}
	}

	public void OnClickBtn()
	{
		ClickCb?.Invoke(Idx);
	}
}
