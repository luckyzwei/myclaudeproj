using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/OutGame/ParkingOpenUI", true)]
[FloatingDepth(12)]
public class InGameParkingOpenUI : InGameFloatingUI
{
	[Header("NeedHouse")]
	[SerializeField]
	private Image NeedHouseIcon;

	[SerializeField]
	private GameObject EnableUpgradeObj;

	[SerializeField]
	private Button Btn;

	private int NeedHouseIdx;

	private void Awake()
	{
	}

	public override void Init(Transform parent, GameType type = GameType.House)
	{
	}

	public void SetNeedHouse(int needHouse)
	{
	}

	private void UpdateUI()
	{
	}

	private void OnClickBtn()
	{
	}
}
