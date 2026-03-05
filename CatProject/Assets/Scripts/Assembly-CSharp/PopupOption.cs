using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupOption", false, false)]
public class PopupOption : UIBase
{
	[SerializeField]
	private ToggleController VibToggle;

	[SerializeField]
	private ToggleController SoundToggle;

	[SerializeField]
	private ToggleController MusicToggle;

	[Header("Lang")]
	[SerializeField]
	private Dropdown langDropdown;

	[Header("Restore")]
	[SerializeField]
	private Button restoreBtn;

	[Header("Coupon")]
	[SerializeField]
	private Button couponBtn;

	[Header("DataSave")]
	[SerializeField]
	private Button saveBtn;

	[SerializeField]
	private Button faqBtn;

	[Header("Version Info")]
	[SerializeField]
	private Text versionInfo;

	[Header("Recommend Friend")]
	[SerializeField]
	private Button recommendBtn;

	[SerializeField]
	private GameObject freeGemObj;

	[Header("Inhouse Banner")]
	[SerializeField]
	private List<Inhouse> inhouseList;

	private bool refusal;

	protected override void Awake()
	{
		base.Awake();
		refusal = false;

		if (VibToggle != null) VibToggle.setToggleListener(OnClickVibration);
		if (SoundToggle != null) SoundToggle.setToggleListener(OnClickEffect);
		if (MusicToggle != null) MusicToggle.setToggleListener(OnClickBGM);
		if (couponBtn != null) couponBtn.onClick.AddListener(OnClickCoupon);
		if (restoreBtn != null) restoreBtn.onClick.AddListener(OnClickRestore);
		if (saveBtn != null) saveBtn.onClick.AddListener(OnClickDataSave);
		if (faqBtn != null) faqBtn.onClick.AddListener(OnClickFAQ);
		if (recommendBtn != null) recommendBtn.onClick.AddListener(OnClickInvite);

		if (inhouseList != null)
		{
			for (int i = 0; i < inhouseList.Count; i++)
			{
				if (inhouseList[i] != null && inhouseList[i].btn != null)
				{
					var ir = inhouseList[i].ir;
					inhouseList[i].btn.onClick.AddListener(() => OnClickReservation(ir));
				}
			}
		}
	}

	public override void OnShowBefore()
	{
		SetLang();
		RefreshFreeGem();

		if (versionInfo != null) versionInfo.text = "v" + Application.version;
	}

	private void OnClickCoupon()
	{
		// Open coupon input popup
	}

	private void OnClickVibration(bool isOn)
	{
		// Save vibration setting
	}

	private void OnClickEffect(bool isOn)
	{
		// Save sound effect setting
	}

	private void OnClickBGM(bool isOn)
	{
		// Save BGM setting
	}

	private void OnClickSlowGraphic(bool isOn)
	{
		// Save slow graphic setting
	}

	private void OnClickRestore()
	{
		// Restore purchases
	}

	private void SetLang()
	{
		if (langDropdown == null) return;
		langDropdown.onValueChanged.RemoveAllListeners();
		langDropdown.onValueChanged.AddListener(OnClickSelectLang);
	}

	private void OnClickSelectLang(int index)
	{
		// Change language and refresh localization
	}

	private void OnClickDataSave()
	{
		// Open data save/cloud save popup
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}

	private void OnClickFAQ()
	{
		Application.OpenURL("https://help.treeplla.com");
	}

	private void OnClickMail()
	{
		SendMail();
	}

	private void OnClickInvite()
	{
		// Share invite link
		RefreshFreeGem();
	}

	public void RefreshFreeGem()
	{
		if (freeGemObj != null) freeGemObj.SetActive(false);
	}

	private void SendMail()
	{
		string subject = EscapeURL("Feedback - " + Application.productName + " v" + Application.version);
		string body = EscapeURL("");
		Application.OpenURL("mailto:support@treeplla.com?subject=" + subject + "&body=" + body);
	}

	private string EscapeURL(string url)
	{
		return UnityEngine.Networking.UnityWebRequest.EscapeURL(url);
	}

	private void OnClickReservation(Config.E_INHOUSE_RESERVATION ir)
	{
		// Open cross-promotion / reservation popup for the given inhouse type
	}
}
