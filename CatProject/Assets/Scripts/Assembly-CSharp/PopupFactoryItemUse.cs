using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupFactoryItemUse", false, false)]
public class PopupFactoryItemUse : UIBase
{
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Transform BatteryRoot;

	[SerializeField]
	private Transform TimeWarpRoot;

	[SerializeField]
	private GameObject FactoryBuffItem;

	private int FactoryIdx;

	protected override void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void Set(int factory)
	{
	}

	private void UpdateList()
	{
	}

	private void RefreshList()
	{
	}

	private void InitBatteryItemList()
	{
	}

	private void InitTimeWarpItemList()
	{
	}

	private void OnClickInfo()
	{
	}

	private void UseItem(int itemIdx, ItemFactoryUseItem item)
	{
	}
}
