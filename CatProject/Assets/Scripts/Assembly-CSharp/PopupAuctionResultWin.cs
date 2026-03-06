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
		base.Awake();
		disposables = new CompositeDisposable();

		if (ConfirmBtn != null) ConfirmBtn.onClick.AddListener(() => { GameEndType = E_GameEndType.ToTitle; Hide(); });
		if (RestartBtn != null) RestartBtn.onClick.AddListener(OnClickRestartAuction);
		if (StaminaShopBtn != null) StaminaShopBtn.onClick.AddListener(OnClickStaminaShop);
		if (GemShopBtn != null) GemShopBtn.onClick.AddListener(OnClickGemShop);
		if (Point2xTrialBtn != null) Point2xTrialBtn.onClick.AddListener(OnClickPoint2xTrial);
	}

	public void Set(string npcname, int spycount, Action<E_GameEndType> endAction)
	{
		EndAction = endAction;
		GameEndType = E_GameEndType.ToTitle;

		if (NpcName != null) NpcName.text = npcname;
		if (AllWinObj != null) AllWinObj.SetActive(false);
		if (Point2xTrialNotiObj != null) Point2xTrialNotiObj.SetActive(false);

		InitHUD();
		Show();
	}

	private void InitHUD()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (StaminaTimeRoot != null) StaminaTimeRoot.SetActive(false);
	}

	private void OnClickRestartAuction()
	{
		GameEndType = E_GameEndType.Restart;
		Hide();
	}

	private void OnClickStaminaShop()
	{
		// Open stamina shop
	}

	private void OnClickGemShop()
	{
		// Open gem shop
	}

	private void OnClickPoint2xTrial()
	{
		// Activate 2x point trial
	}

	public override void OnHideAfter()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
		EndAction?.Invoke(GameEndType);
		EndAction = null;
	}
}
