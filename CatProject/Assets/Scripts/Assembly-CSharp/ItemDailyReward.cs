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
		if (Btn != null) Btn.onClick.AddListener(OnClickBtn);
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnClickReward);
	}

	public void Set(int idx)
	{
		Idx = idx;
		UpdateStatus();
	}

	private Sprite SetSprite(int type, int idx, string iconPath = "")
	{
		return null;
	}

	public void UpdateStatus()
	{
		// Update display
	}

	public void ShowParticle()
	{
		if (FocusParticle != null) FocusParticle.SetActive(true);
	}

	private void OnClickBtn()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickReward()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}
}
