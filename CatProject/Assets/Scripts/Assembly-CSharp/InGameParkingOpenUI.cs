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
		if (Btn != null)
			Btn.onClick.AddListener(OnClickBtn);
	}

	public override void Init(Transform parent, GameType type = GameType.House)
	{
		base.Init(parent, type);
	}

	public void SetNeedHouse(int needHouse)
	{
		NeedHouseIdx = needHouse;
		UpdateUI();
	}

	private void UpdateUI()
	{
		if (EnableUpgradeObj != null)
			EnableUpgradeObj.SetActive(NeedHouseIdx <= 0);
	}

	private void OnClickBtn()
	{
		// Handle click
	}
}
