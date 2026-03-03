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
	}

	public override void OnShowBefore()
	{
	}

	public override void OnRefresh()
	{
	}

	private void InitPage()
	{
	}

	private void SetTitleText()
	{
	}

	public void UpdateDeco(bool showEffect = false)
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickGetItem()
	{
	}

	private void OnClickReward()
	{
	}

	private void OnClickPass()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void RefreshText()
	{
	}
}
