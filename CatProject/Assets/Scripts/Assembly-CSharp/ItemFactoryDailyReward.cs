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
	}

	public void Set(int order)
	{
	}

	public void UpdateItem(bool isRewarded = false)
	{
	}

	private void UpdateReward(bool isContentsOpen, bool isStageOpen)
	{
	}

	private void OnClickReward()
	{
	}
}
