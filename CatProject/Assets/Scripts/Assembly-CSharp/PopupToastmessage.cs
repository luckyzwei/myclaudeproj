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
		// Static toast open - uses UI system to show toast popup
	}

	public static void OpenToast(string _descKey, bool isShowImmediately = true)
	{
		// Static toast open with localized key
	}

	public static void OpenToast(string _descKey, bool isShowImmediately = true, params object[] args)
	{
		// Static toast open with localized key and format args
	}

	public static void OpenToastByString(string descStr, bool isShowImmediately = true)
	{
		// Static toast open with raw string
	}

	public static void OpenToast_ZoneOpen(int zoneIdx, string localizeKey)
	{
		// Toast for zone unlock notification
	}

	public static void OpenToast_PurchaseFail(bool bShowImmediately = true)
	{
		// Toast for purchase failure
	}

	public void Show(string _title, string _desc)
	{
		if (title != null) title.text = _title;
		if (desc != null) desc.text = _desc;
		if (icon != null) icon.gameObject.SetActive(false);
		if (RewardObj != null) RewardObj.SetActive(false);
		base.Show();
	}

	public void Show(string _title, string _desc, string _renovateImgName)
	{
		if (title != null) title.text = _title;
		if (desc != null) desc.text = _desc;
		if (icon != null && !string.IsNullOrEmpty(_renovateImgName))
		{
			Sprite sprite = Resources.Load<Sprite>(_renovateImgName);
			if (sprite != null)
			{
				icon.sprite = sprite;
				icon.gameObject.SetActive(true);
			}
		}
		if (RewardObj != null) RewardObj.SetActive(false);
		base.Show();
	}

	public void ShowWithAtlasIcon(string _title, string _desc, string _renovateImgName, Config.AtlasType atlasType)
	{
		Show(_title, _desc, _renovateImgName);
	}

	public void SetText(string _descKey)
	{
		if (desc != null) desc.text = _descKey;
	}

	public void SetText(string _descKey, params object[] args)
	{
		if (desc != null) desc.text = string.Format(_descKey, args);
	}

	public override void OnHideAfter()
	{
		RewardType = 0;
		RewardIdx = 0;
		RewardRegion = 0;
		RewardCount = 0;
	}
}
