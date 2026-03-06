using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupReservation", false, false)]
public class PopupReservation : UIBase
{
	[SerializeField]
	private Button shareBtn;

	[SerializeField]
	private GameObject shareReward;

	[SerializeField]
	private Button LinkBtn;

	[SerializeField]
	private GameObject LinkRewardObj;

	[SerializeField]
	private Text LinkBtnText;

	[SerializeField]
	private Button CrossPromotionBtn;

	[Header("Dynamic")]
	[SerializeField]
	private List<GameObject> mainObj;

	private InhouseReservationData irData;

	private bool IsOpenURL;

	protected override void Awake()
	{
		base.Awake();
		if (shareBtn != null) shareBtn.onClick.AddListener(OnClickShare);
		if (LinkBtn != null) LinkBtn.onClick.AddListener(OnClickLink);
		if (CrossPromotionBtn != null) CrossPromotionBtn.onClick.AddListener(OnClickCrossPromotion);
	}

	public override void OnRefresh()
	{
		RefreshGemReward();
	}

	public void Init(Config.E_INHOUSE_RESERVATION _irType)
	{
		IsOpenURL = false;

		if (mainObj != null)
		{
			for (int i = 0; i < mainObj.Count; i++)
			{
				if (mainObj[i] != null)
					mainObj[i].SetActive(i == (int)_irType);
			}
		}

		RefreshGemReward();
		Show();
	}

	private void RefreshGemReward()
	{
		if (shareReward != null) shareReward.SetActive(false);
		if (LinkRewardObj != null) LinkRewardObj.SetActive(false);
	}

	private void OnClickLink()
	{
		IsOpenURL = true;
		// Open external link
	}

	private void OnApplicationPause(bool pause)
	{
		if (!pause && IsOpenURL)
		{
			IsOpenURL = false;
			RefreshGemReward();
		}
	}

	private void OnClickShare()
	{
	}

	private void OnClickCrossPromotion()
	{
	}
}
