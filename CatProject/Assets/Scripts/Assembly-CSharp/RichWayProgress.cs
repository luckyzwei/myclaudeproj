using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class RichWayProgress : MonoBehaviour, ILocalizeRefresh
{
	[SerializeField]
	private Animator ShowAnim;

	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Text DescText;

	[SerializeField]
	private Button NaviBtn;

	[SerializeField]
	private Slider curPointProgress;

	[SerializeField]
	private Image OriginPointFillImg;

	[SerializeField]
	private Text curPointText;

	[SerializeField]
	private Image rewardIcon;

	[SerializeField]
	private Text rewardCountText;

	[SerializeField]
	private Text rewardBtnText;

	[SerializeField]
	private GameObject Reddot;

	[SerializeField]
	private GameObject RichHUDRoot;

	[SerializeField]
	private GameObject GetPointEffectObj;

	[SerializeField]
	private GameObject EnableClearObj;

	private CompositeDisposable disposables;

	private int mission_ad_reward_multiple;

	private bool isNoAds;

	public void Init()
	{
		disposables = new CompositeDisposable();
		mission_ad_reward_multiple = 2;
		isNoAds = false;

		if (Btn != null)
			Btn.onClick.AddListener(OnClickGetReward);
		if (NaviBtn != null)
			NaviBtn.onClick.AddListener(OnClickNavi);

		SubscribeContentOpen();
		UpdateProgress();
		UpdateActive();
	}

	private void SubscribeContentOpen()
	{
		// TODO
	}

	public void RefreshText()
	{
		UpdateProgress();
	}

	public void UpdateNoAds()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ShopSystem == null) return;
		isNoAds = root.ShopSystem.NoAds;
	}

	private void UpdateContentsOpen()
	{
		UpdateActive();
	}

	private void UpdateProgress()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;

		if (curPointProgress != null)
			curPointProgress.value = 0f;
		if (curPointText != null)
			curPointText.text = "0";
	}

	private void UpdateLevel()
	{
		UpdateProgress();
		if (Reddot != null)
			Reddot.SetActive(false);
		if (EnableClearObj != null)
			EnableClearObj.SetActive(false);
	}

	public void UpdateActive()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ContentsOpenSystem == null)
		{
			if (RichHUDRoot != null) RichHUDRoot.SetActive(false);
			return;
		}
		if (RichHUDRoot != null) RichHUDRoot.SetActive(true);
	}

	public void Clear()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}

	private void GetReward(int double_value)
	{
		// TODO
	}

	private void OnClickGetReward()
	{
		GetReward(1);
	}

	private void OnClickNavi()
	{
		// Handle click
	}

	public void StartPointProgress(int startPoint, int getPoint)
	{
		if (GetPointEffectObj != null)
			GetPointEffectObj.SetActive(true);
		if (ShowAnim != null)
			ShowAnim.SetTrigger("Show");
		UpdateProgress();
	}
}
