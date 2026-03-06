using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/Factory/ProductionUI", true)]
[FloatingDepth(2)]
public class InGameFactoryProductionUI : InGameFloatingUI
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Slider Progress;

	[SerializeField]
	private Image ProgressFill;

	[SerializeField]
	private GameObject FullObj;

	[SerializeField]
	private GameObject LackObj;

	[SerializeField]
	private GameObject SleepObj;

	private bool isFull;

	private bool isLack;

	public override void Init(Transform parent, GameType type = GameType.Factory)
	{
		base.Init(parent, type);
		isFull = false;
		isLack = false;
	}

	public void SetMakeProduct(int idx)
	{
		// Set product icon and progress
		if (Progress != null) Progress.value = 0f;
		UpdateStatus();
	}

	public void SetLack(bool value)
	{
		isLack = value;
		UpdateStatus();
	}

	public void SetFull(bool value)
	{
		isFull = value;
		UpdateStatus();
	}

	private void UpdateStatus()
	{
		if (FullObj != null) FullObj.SetActive(isFull);
		if (LackObj != null) LackObj.SetActive(isLack && !isFull);
		if (SleepObj != null) SleepObj.SetActive(!isFull && !isLack);
	}

	public void UpdateValue(float value)
	{
		if (Progress != null) Progress.value = Mathf.Clamp01(value);
	}
}
