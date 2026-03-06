using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupGuideMagicalTarot", false, false)]
public class PopupGuideMagicalTarot : UIBase
{
	private enum Tab
	{
		None = 0,
		Normal = 1,
		Special = 2
	}

	[Header("PopupGuideMagicalTarot")]
	[SerializeField]
	private ScrollRect NormalCardScroll;

	[SerializeField]
	private GameObject NormalCardItem;

	[Space(5f)]
	[SerializeField]
	private ScrollRect SpecialCardScroll;

	[SerializeField]
	private GameObject SpecialCardItem;

	[Space(10f)]
	[SerializeField]
	private Toggle NormalTab;

	[SerializeField]
	private Toggle SpecialTab;

	[SerializeField]
	private ItemRatioInfo NormalRewardInfo;

	[SerializeField]
	private ItemRatioInfo SpecialRewardInfo;

	private Tab CurTab;

	protected override void Awake()
	{
		base.Awake();
		if (NormalTab != null) NormalTab.onValueChanged.AddListener(isOn => { if (isOn) OnClickChangeTab(Tab.Normal); });
		if (SpecialTab != null) SpecialTab.onValueChanged.AddListener(isOn => { if (isOn) OnClickChangeTab(Tab.Special); });
	}

	public override void OnShowBefore()
	{
		CurTab = Tab.Normal;
		OnClickChangeTab(CurTab);
	}

	private void OnClickChangeTab(Tab tab)
	{
		CurTab = tab;
		SetCardRatio();
		SetRewardRatio();
	}

	private void SetCardRatio()
	{
	}

	private void SetRewardRatio()
	{
	}
}
