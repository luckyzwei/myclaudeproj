using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupToastmessage", false, false)]
public class PopupToastmessage : UIBase
{
	[SerializeField]
	private Text title;

	[SerializeField]
	private Text desc;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private GameObject RewardObj;

	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardValue;

	private int RewardType;

	private int RewardIdx;

	private int RewardRegion;

	private int RewardCount;

	public static void OpenToast(string _title, string _desc)
	{
	}

	public static void OpenToast(string _descKey, bool isShowImmediately = true)
	{
	}

	public static void OpenToast(string _descKey, bool isShowImmediately = true, params object[] args)
	{
	}

	public static void OpenToastByString(string descStr, bool isShowImmediately = true)
	{
	}

	public static void OpenToast_ZoneOpen(int zoneIdx, string localizeKey)
	{
	}

	public static void OpenToast_PurchaseFail(bool bShowImmediately = true)
	{
	}

	public void Show(string _title, string _desc)
	{
	}

	public void Show(string _title, string _desc, string _renovateImgName)
	{
	}

	public void ShowWithAtlasIcon(string _title, string _desc, string _renovateImgName, Config.AtlasType atlasType)
	{
	}

	public void SetText(string _descKey)
	{
	}

	public void SetText(string _descKey, params object[] args)
	{
	}

	public override void OnHideAfter()
	{
	}
}
