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
	}

	public void SetValue(int curValue, int minValue, int maxValue, int minLimitValue, int maxLimitValue, int stepValue)
	{
	}

	public void SetValueMinimumAtButtonDeactive(bool isSet)
	{
	}

	public bool IsMinValue()
	{
		return false;
	}

	public bool IsMaxValue()
	{
		return false;
	}

	private void UpdateValueText()
	{
	}

	private void OnClickedMinusButton()
	{
	}

	private void OnClickedPlusButton()
	{
	}

	private void OnClickedMinButton()
	{
	}

	private void OnClickedMaxButton()
	{
	}

	private void OnValueChanged(float value)
	{
	}

	private void SetValueMinimumAtButtonDeactive()
	{
	}
}
