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
	}

	public override void OnRefresh()
	{
	}

	public void Init(Config.E_INHOUSE_RESERVATION _irType)
	{
	}

	private void RefreshGemReward()
	{
	}

	private void OnClickLink()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnClickShare()
	{
	}

	private void OnClickCrossPromotion()
	{
	}
}
