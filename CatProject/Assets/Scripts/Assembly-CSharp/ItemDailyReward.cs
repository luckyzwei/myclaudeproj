using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemDailyReward : MonoBehaviour
{
	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Image BtnIcon;

	[SerializeField]
	private Text NeedCount;

	[SerializeField]
	private GameObject FocusParticle;

	[Header("Reward")]
	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardCount;

	[SerializeField]
	private GameObject InfoBtnObj;

	[Header("Receive")]
	[SerializeField]
	private GameObject ReceiveObj;

	[SerializeField]
	private Image ReceiveIcon;

	private int Idx;

	private DailyQuestRewardData Info;

	private bool isWeek;

	private int NeedPoint;

	private void Awake()
	{
	}

	public void Set(int idx)
	{
	}

	private Sprite SetSprite(int type, int idx, string iconPath = "")
	{
		return null;
	}

	public void UpdateStatus()
	{
	}

	public void ShowParticle()
	{
	}

	private void OnClickBtn()
	{
	}

	private void OnClickReward()
	{
	}
}
