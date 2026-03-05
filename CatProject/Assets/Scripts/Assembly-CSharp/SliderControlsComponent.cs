using System;
using UnityEngine;
using UnityEngine.UI;

public class SliderControlsComponent : MonoBehaviour
{
	public enum E_LimitType
	{
		Min = 0,
		Max = 1
	}

	[SerializeField]
	private Slider GaugeSlider;

	[SerializeField]
	private Text GaugeValueText;

	[SerializeField]
	private Button MinusButton;

	[SerializeField]
	private Button PlusButton;

	[SerializeField]
	private Button MinButton;

	[SerializeField]
	private Button MaxButton;

	private int MinGaugeValue;

	private int MaxGaugeValue;

	private int MinLimitValue;

	private int MaxLimitValue;

	private int StepValue;

	private bool IsMinValueAtButtonDeactive;

	private bool IsInitProcess;

	public Action<int> OnValueChangedEvent;

	public Action<E_LimitType> OnValueLimitEvent;

	private void Awake()
	{
		if (MinusButton != null) MinusButton.onClick.AddListener(OnClickedMinusButton);
		if (PlusButton != null) PlusButton.onClick.AddListener(OnClickedPlusButton);
		if (MinButton != null) MinButton.onClick.AddListener(OnClickedMinButton);
		if (MaxButton != null) MaxButton.onClick.AddListener(OnClickedMaxButton);
		if (GaugeSlider != null) GaugeSlider.onValueChanged.AddListener(OnValueChanged);
	}

	public void SetValue(int curValue, int minValue, int maxValue, int minLimitValue, int maxLimitValue, int stepValue)
	{
		IsInitProcess = true;
		MinGaugeValue = minValue;
		MaxGaugeValue = maxValue;
		MinLimitValue = minLimitValue;
		MaxLimitValue = maxLimitValue;
		StepValue = stepValue > 0 ? stepValue : 1;
		if (GaugeSlider != null)
		{
			GaugeSlider.minValue = minValue;
			GaugeSlider.maxValue = maxValue;
			GaugeSlider.wholeNumbers = true;
			GaugeSlider.value = curValue;
		}
		UpdateValueText();
		SetValueMinimumAtButtonDeactive();
		IsInitProcess = false;
	}

	public void SetValueMinimumAtButtonDeactive(bool isSet)
	{
		IsMinValueAtButtonDeactive = isSet;
		SetValueMinimumAtButtonDeactive();
	}

	public bool IsMinValue()
	{
		return GaugeSlider != null && (int)GaugeSlider.value <= MinLimitValue;
	}

	public bool IsMaxValue()
	{
		return GaugeSlider != null && (int)GaugeSlider.value >= MaxLimitValue;
	}

	private void UpdateValueText()
	{
		if (GaugeValueText != null && GaugeSlider != null)
			GaugeValueText.text = ((int)GaugeSlider.value).ToString();
	}

	private void OnClickedMinusButton()
	{
		if (GaugeSlider == null) return;
		int newVal = (int)GaugeSlider.value - StepValue;
		if (newVal < MinLimitValue) newVal = MinLimitValue;
		GaugeSlider.value = newVal;
	}

	private void OnClickedPlusButton()
	{
		if (GaugeSlider == null) return;
		int newVal = (int)GaugeSlider.value + StepValue;
		if (newVal > MaxLimitValue) newVal = MaxLimitValue;
		GaugeSlider.value = newVal;
	}

	private void OnClickedMinButton()
	{
		if (GaugeSlider == null) return;
		GaugeSlider.value = MinLimitValue;
	}

	private void OnClickedMaxButton()
	{
		if (GaugeSlider == null) return;
		GaugeSlider.value = MaxLimitValue;
	}

	private void OnValueChanged(float value)
	{
		UpdateValueText();
		SetValueMinimumAtButtonDeactive();
		if (!IsInitProcess)
		{
			int intVal = (int)value;
			OnValueChangedEvent?.Invoke(intVal);
			if (intVal <= MinLimitValue) OnValueLimitEvent?.Invoke(E_LimitType.Min);
			else if (intVal >= MaxLimitValue) OnValueLimitEvent?.Invoke(E_LimitType.Max);
		}
	}

	private void SetValueMinimumAtButtonDeactive()
	{
		if (!IsMinValueAtButtonDeactive) return;
		if (MinusButton != null) MinusButton.interactable = !IsMinValue();
		if (PlusButton != null) PlusButton.interactable = !IsMaxValue();
		if (MinButton != null) MinButton.interactable = !IsMinValue();
		if (MaxButton != null) MaxButton.interactable = !IsMaxValue();
	}
}
