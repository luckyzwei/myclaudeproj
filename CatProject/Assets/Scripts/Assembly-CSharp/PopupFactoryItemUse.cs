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
		base.Awake();
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
	}

	private void OnDisable()
	{
	}

	public void Set(int factory)
	{
		FactoryIdx = factory;
		UpdateList();
		Show();
	}

	private void UpdateList()
	{
		InitBatteryItemList();
		InitTimeWarpItemList();
	}

	private void RefreshList()
	{
		UpdateList();
	}

	private void InitBatteryItemList()
	{
		if (BatteryRoot == null) return;
		// Instantiate battery items for factory
	}

	private void InitTimeWarpItemList()
	{
		if (TimeWarpRoot == null) return;
		// Instantiate time warp items for factory
	}

	private void OnClickInfo()
	{
		// Show factory item info popup
	}

	private void UseItem(int itemIdx, ItemFactoryUseItem item)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.FactorySystem == null) return;
		// Apply item effect to factory
		RefreshList();
	}
}
