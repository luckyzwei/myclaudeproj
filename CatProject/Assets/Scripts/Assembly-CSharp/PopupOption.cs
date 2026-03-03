using System.Collections.Generic;
using Treeplla;
using UnityEngine;
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
	}

	public override void OnShowBefore()
	{
	}

	private void OnClickCoupon()
	{
	}

	private void OnClickVibration(bool isOn)
	{
	}

	private void OnClickEffect(bool isOn)
	{
	}

	private void OnClickBGM(bool isOn)
	{
	}

	private void OnClickSlowGraphic(bool isOn)
	{
	}

	private void OnClickRestore()
	{
	}

	private void SetLang()
	{
	}

	private void OnClickSelectLang(int index)
	{
	}

	private void OnClickDataSave()
	{
	}

	private void OnClickFAQ()
	{
	}

	private void OnClickMail()
	{
	}

	private void OnClickInvite()
	{
	}

	public void RefreshFreeGem()
	{
	}

	private void SendMail()
	{
	}

	private string EscapeURL(string url)
	{
		return null;
	}

	private void OnClickReservation(Config.E_INHOUSE_RESERVATION ir)
	{
	}
}
