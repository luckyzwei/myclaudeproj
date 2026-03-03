using System;
using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAuctionResultWin", false, false)]
public class PopupAuctionResultWin : UIBase
{
	public enum E_GameEndType
	{
		ToTitle = 0,
		Restart = 1
	}

	[Serializable]
	private class Rounds
	{
		public GameObject Root;

		public Text RoundText;

		public Transform StatusRoot;

		public Transform EnemyStatusRoot;
	}

	[SerializeField]
	private Button ConfirmBtn;

	[SerializeField]
	private List<Rounds> RoundObjs;

	[SerializeField]
	private Text TotalWinRound;

	[SerializeField]
	private GameObject AllWinObj;

	[SerializeField]
	private Text AllWinText;

	[SerializeField]
	private Text TipText;

	[SerializeField]
	private Text MyName;

	[SerializeField]
	private Text NpcName;

	[SerializeField]
	private GameObject PassActiveObj;

	[SerializeField]
	private Text PassActiveText;

	[Header("Retry")]
	[SerializeField]
	private Button RestartBtn;

	[SerializeField]
	private Text UseStamina;

	[Header("HUD")]
	[SerializeField]
	private Text StaminaText;

	[SerializeField]
	private Text StaminaRemainTime;

	[SerializeField]
	private GameObject StaminaTimeRoot;

	[SerializeField]
	private Button StaminaShopBtn;

	[SerializeField]
	private Text GemText;

	[SerializeField]
	private Button GemShopBtn;

	[SerializeField]
	private GameObject Point2xTrialNotiObj;

	[SerializeField]
	private Button Point2xTrialBtn;

	private E_GameEndType GameEndType;

	private Action<E_GameEndType> EndAction;

	private CompositeDisposable disposables;

	protected override void Awake()
	{
	}

	public void Set(string npcname, int spycount, Action<E_GameEndType> endAction)
	{
	}

	private void InitHUD()
	{
	}

	private void OnClickRestartAuction()
	{
	}

	private void OnClickStaminaShop()
	{
	}

	private void OnClickGemShop()
	{
	}

	private void OnClickPoint2xTrial()
	{
	}

	public override void OnHideAfter()
	{
	}
}
