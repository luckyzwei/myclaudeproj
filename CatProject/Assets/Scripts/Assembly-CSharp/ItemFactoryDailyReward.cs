using UnityEngine;
using UnityEngine.UI;

public class ItemFactoryDailyReward : MonoBehaviour
{
	[Header("ItemFactoryDailyReward")]
	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private GameObject RewardActiveObj;

	[SerializeField]
	private GameObject RewardAfterObj;

	[SerializeField]
	private Image[] RewardIcons;

	[SerializeField]
	private Text RewardOrderText;

	[SerializeField]
	private Text RewardCountText;

	private RewardItemData RewardItem;

	private bool IsContentsOpen;

	private bool IsStageOpen;

	public int CurOrder { get; private set; }

	private void Awake()
	{
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnClickReward);
	}

	public void Set(int order)
	{
		CurOrder = order;
		UpdateItem();
	}

	public void UpdateItem(bool isRewarded = false)
	{
		if (RewardActiveObj != null) RewardActiveObj.SetActive(!isRewarded);
		if (RewardAfterObj != null) RewardAfterObj.SetActive(isRewarded);
	}

	private void UpdateReward(bool isContentsOpen, bool isStageOpen)
	{
		IsContentsOpen = isContentsOpen;
		IsStageOpen = isStageOpen;
	}

	private void OnClickReward()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
