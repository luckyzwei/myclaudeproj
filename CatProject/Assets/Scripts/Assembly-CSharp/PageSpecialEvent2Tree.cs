using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageSpecialEvent2Tree", false, false)]
public class PageSpecialEvent2Tree : UIBase, ILocalizeRefresh
{
	[Header("[PageSpecialEvent2Tree]")]
	[Header("Top")]
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Text TitleText;

	[SerializeField]
	private Text RemainTimeText;

	[Header("Deco")]
	[SerializeField]
	private ItemSpecialEvent2[] DecoItemList;

	[Header("Reward")]
	[SerializeField]
	private ItemArticle[] RewardItemList;

	[SerializeField]
	private Button GetItemBtn;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private Button PassBtn;

	[SerializeField]
	private GameObject Point2xNotiObj;

	private CompositeDisposable disposables;

	private string TitleName;

	protected override void Awake()
	{
		base.Awake();
		disposables = new CompositeDisposable();

		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
		if (GetItemBtn != null) GetItemBtn.onClick.AddListener(OnClickGetItem);
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnClickReward);
		if (PassBtn != null) PassBtn.onClick.AddListener(OnClickPass);
	}

	public override void OnShowBefore()
	{
		InitPage();
	}

	public override void OnRefresh()
	{
		InitPage();
	}

	private void InitPage()
	{
		SetTitleText();
		UpdateDeco(false);
		if (Point2xNotiObj != null) Point2xNotiObj.SetActive(false);
	}

	private void SetTitleText()
	{
		if (TitleText != null) TitleText.text = TitleName ?? "";
	}

	public void UpdateDeco(bool showEffect = false)
	{
		if (DecoItemList == null) return;
		for (int i = 0; i < DecoItemList.Length; i++)
		{
			// Update deco item state
		}
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupMiniGameOpen>();
	}

	private void OnClickGetItem()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickReward()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickPass()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	public void RefreshText()
	{
		SetTitleText();
	}
}
