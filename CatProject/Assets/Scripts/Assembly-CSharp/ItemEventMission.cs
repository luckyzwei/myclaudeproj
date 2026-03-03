using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemEventMission : MonoBehaviour
{
	[SerializeField]
	private Text DescriptionText;

	[SerializeField]
	private Text RefreshCostText;

	[SerializeField]
	private ItemArticle RewardItem;

	[SerializeField]
	private Slider ProgressSlider;

	[SerializeField]
	private ProgressText ProgressText;

	[Header("Button")]
	[SerializeField]
	private Button RefreshButton;

	[SerializeField]
	private Button ShortCutButton;

	[SerializeField]
	private Button ClaimButton;

	[Header("State Obj")]
	[SerializeField]
	private GameObject ProgressObj;

	[SerializeField]
	private GameObject ButtonObj;

	[SerializeField]
	private GameObject ShortCutBtnObj;

	[SerializeField]
	private GameObject ClaimBtnObj;

	[SerializeField]
	private GameObject NotCompleteObj;

	[SerializeField]
	private GameObject CompleteObj;

	[SerializeField]
	private GameObject RewardedObj;

	[SerializeField]
	private GameObject ResetFxObj;

	[Header("LayoutSizeInfo")]
	[SerializeField]
	private LayoutElement LayoutElement;

	[SerializeField]
	private float NormalHeight;

	[SerializeField]
	private float RewardedHeight;

	private SingleMissionBase MissionData;

	private int RefreshCost;

	private bool IsReqShortCut;

	private CompositeDisposable Disposables;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(SingleMissionBase mission)
	{
	}

	private void SubscribeEvents()
	{
	}

	private void UpdateLayout(bool isCompleted, bool isRewarded)
	{
	}

	private void UpdateProgressInfo()
	{
	}

	private void OnClickRefreshBtn()
	{
	}

	private void OnClickShortCutBtn()
	{
	}

	private void OnClickClaimBtn()
	{
	}
}
