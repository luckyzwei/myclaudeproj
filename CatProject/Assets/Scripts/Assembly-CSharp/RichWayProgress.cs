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
	}

	private void SubscribeContentOpen()
	{
	}

	public void RefreshText()
	{
	}

	public void UpdateNoAds()
	{
	}

	private void UpdateContentsOpen()
	{
	}

	private void UpdateProgress()
	{
	}

	private void UpdateLevel()
	{
	}

	public void UpdateActive()
	{
	}

	public void Clear()
	{
	}

	private void GetReward(int double_value)
	{
	}

	private void OnClickGetReward()
	{
	}

	private void OnClickNavi()
	{
	}

	public void StartPointProgress(int startPoint, int getPoint)
	{
	}
}
