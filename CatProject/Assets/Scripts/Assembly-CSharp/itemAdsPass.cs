using UnityEngine;
using UnityEngine.UI;

public class itemAdsPass : MonoBehaviour
{
	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardText;

	[SerializeField]
	private Text ViewCountText;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject EarnObj;

	private int Idx;

	private void Awake()
	{
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnRewardBtnClick);
	}

	public void Set(int idx)
	{
		Idx = idx;
		UpdateGetReward();
	}

	private void UpdateGetReward()
	{
	}

	private void OnRewardBtnClick()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
