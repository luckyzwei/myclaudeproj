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
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupToastmessage>((popup) =>
		{
			if (popup != null) popup.Show(_title, _desc);
		});
	}

	public static void OpenToast(string _descKey, bool isShowImmediately = true)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupToastmessage>((popup) =>
		{
			if (popup != null) popup.SetText(_descKey);
		});
	}

	public static void OpenToast(string _descKey, bool isShowImmediately = true, params object[] args)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupToastmessage>((popup) =>
		{
			if (popup != null) popup.SetText(_descKey, args);
		});
	}

	public static void OpenToastByString(string descStr, bool isShowImmediately = true)
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupToastmessage>((popup) =>
		{
			if (popup != null) popup.SetText(descStr);
		});
	}

	public static void OpenToast_ZoneOpen(int zoneIdx, string localizeKey)
	{
		OpenToast(localizeKey);
	}

	public static void OpenToast_PurchaseFail(bool bShowImmediately = true)
	{
		OpenToast("purchase_fail", bShowImmediately);
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
