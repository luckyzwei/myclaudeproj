using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupEventExchange", false, false)]
public class PopupEventExchange : UIBase
{
	[SerializeField]
	private Item1stEventShop ItemShop;

	[SerializeField]
	private Slider CountSlider;

	[SerializeField]
	private Text SliderValueText;

	[SerializeField]
	private Button ExchangeButton;

	[SerializeField]
	private Text CostValueText;

	[SerializeField]
	private Image CostIconImage;

	[SerializeField]
	private Button MaxValueButton;

	private int ItemCostValue;

	private int ItemRemainCount;

	private int BuyableCount;

	private Action<int> OnExchangeButtonClickEvent;

	protected override void Awake()
	{
	}

	public void Init(int evenShopIdx, Action<int> onExchangeButtonClickEvent)
	{
	}

	private void SetCostValueText(int value)
	{
	}

	private void SetCostIconImage(int type, int idx, int region)
	{
	}

	private void SetSliderValueText(int value)
	{
	}

	private void OnExchangeButtonClick()
	{
	}

	private void OnMaxValueButtonClick()
	{
	}

	private void OnCountSliderValueChanged(float value)
	{
	}
}
