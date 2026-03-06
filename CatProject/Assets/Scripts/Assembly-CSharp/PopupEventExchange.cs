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
		base.Awake();
		if (ExchangeButton != null) ExchangeButton.onClick.AddListener(OnExchangeButtonClick);
		if (MaxValueButton != null) MaxValueButton.onClick.AddListener(OnMaxValueButtonClick);
		if (CountSlider != null) CountSlider.onValueChanged.AddListener(OnCountSliderValueChanged);
	}

	public void Init(int evenShopIdx, Action<int> onExchangeButtonClickEvent)
	{
		OnExchangeButtonClickEvent = onExchangeButtonClickEvent;
		ItemCostValue = 0;
		ItemRemainCount = 0;
		BuyableCount = 0;

		if (CountSlider != null)
		{
			CountSlider.minValue = 1;
			CountSlider.maxValue = 1;
			CountSlider.value = 1;
		}

		SetSliderValueText(1);
		Show();
	}

	private void SetCostValueText(int value)
	{
		if (CostValueText != null) CostValueText.text = value.ToString();
	}

	private void SetCostIconImage(int type, int idx, int region)
	{
	}

	private void SetSliderValueText(int value)
	{
		if (SliderValueText != null) SliderValueText.text = value.ToString();
	}

	private void OnExchangeButtonClick()
	{
		int count = CountSlider != null ? (int)CountSlider.value : 1;
		OnExchangeButtonClickEvent?.Invoke(count);
		Hide();
	}

	private void OnMaxValueButtonClick()
	{
		if (CountSlider == null) return;
		CountSlider.value = CountSlider.maxValue;
	}

	private void OnCountSliderValueChanged(float value)
	{
		int count = (int)value;
		SetSliderValueText(count);
		SetCostValueText(count * ItemCostValue);
	}
}
