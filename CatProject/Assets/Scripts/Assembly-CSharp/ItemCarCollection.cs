using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemCarCollection : MonoBehaviour
{
	[SerializeField]
	private Button ItemBtn;

	[SerializeField]
	private Image BrandIcon;

	[SerializeField]
	private Text BrandName;

	[SerializeField]
	private Slider OwnProgress;

	[SerializeField]
	private Text OwnCount;

	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private GameObject RewardOnObj;

	[SerializeField]
	private Image BuffIcon;

	[SerializeField]
	private Text BuffText;

	[SerializeField]
	private GameObject BuffOnObj;

	[SerializeField]
	private GameObject BuffRoot;

	private int BrandIdx;

	public Action<int> ClickAction;

	private void Awake()
	{
		if (ItemBtn != null)
			ItemBtn.onClick.AddListener(OnItemBtnClick);
	}

	public void SetBrand(int brandIdx)
	{
		BrandIdx = brandIdx;
	}

	private void OnItemBtnClick()
	{
		ClickAction?.Invoke(BrandIdx);
	}
}
