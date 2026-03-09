using Balancy.Models.SmartObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyMissionWidget : MonoBehaviour
{
	private const string ANIM_ANIM_DAILYMISSIONS_MISSONACTIVE = "Anim-DailyMissions-MissonActive";

	private const string ANIM_ANIM_DAILYMISSIONS_MISSONALLCOMPLETE = "Anim-DailyMissions-MissonAllComplete";

	private const string ANIM_ANIM_DAILYMISSIONS_CLAIMREWARD = "Anim-DailyMissions-ClaimReward";

	[SerializeField]
	private bool m_getNewMissionIfCurrentMissionComplete;

	[Space]
	[SerializeField]
	protected AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Image[] m_bars;

	[SerializeField]
	private TextMeshProUGUI m_progressText;

	[SerializeField]
	protected GameObject m_check;

	[SerializeField]
	protected DailyMissionTimerWidget m_timer;

	[Header("Reward Widget")]
	[SerializeField]
	private RewardWidget m_rewardWidget;

	[SerializeField]
	private GameObject m_rewardContainer;

	[Header("Texts")]
	[SerializeField]
	private TMP_Text m_text;

	[SerializeField]
	private TMP_Text m_headerText;

	[Header("Buttons")]
	[SerializeField]
	private Button m_rewardButton;

	[SerializeField]
	private Button m_swapButton;

	private BaseMission m_mission;

	private bool m_isRewardOpen;

	protected virtual void Awake()
	{
	}

	protected virtual void SetupWidget()
	{
	}

	private void OnSwapClicked()
	{
	}

	public virtual void Config()
	{
	}

	public virtual void Config(BaseMission mission, Reward reward)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnProgress(bool isCompleted)
	{
	}

	protected void DisplayProgress(float overrideProgress = -1f)
	{
	}

	protected virtual void OnRewardClicked()
	{
	}

	private void Update()
	{
	}

	public void Refresh()
	{
	}
}
