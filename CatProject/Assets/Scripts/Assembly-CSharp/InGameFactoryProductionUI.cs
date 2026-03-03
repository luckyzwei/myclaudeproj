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
	}

	public void SetMakeProduct(int idx)
	{
	}

	public void SetLack(bool value)
	{
	}

	public void SetFull(bool value)
	{
	}

	private void UpdateStatus()
	{
	}

	public void UpdateValue(float value)
	{
	}
}
