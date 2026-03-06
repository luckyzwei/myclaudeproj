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
		Disposables = new CompositeDisposable();
		if (RefreshButton != null)
			RefreshButton.onClick.AddListener(OnClickRefreshBtn);
		if (ShortCutButton != null)
			ShortCutButton.onClick.AddListener(OnClickShortCutBtn);
		if (ClaimButton != null)
			ClaimButton.onClick.AddListener(OnClickClaimBtn);
	}

	private void OnDisable()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = new CompositeDisposable();
		}
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public void Init(SingleMissionBase mission)
	{
		MissionData = mission;
		if (MissionData == null) return;
		if (DescriptionText != null)
			DescriptionText.text = MissionData.GetMissionDescriptionText();
		UpdateProgressInfo();
		SubscribeEvents();
		bool isCompleted = MissionData.IsCompleted != null && MissionData.IsCompleted.Value;
		bool isRewarded = MissionData.IsRewarded != null && MissionData.IsRewarded.Value;
		UpdateLayout(isCompleted, isRewarded);
	}

	private void SubscribeEvents()
	{
		if (MissionData == null) return;
		if (MissionData.CurrentValue != null)
		{
			MissionData.CurrentValue.Subscribe(_ => UpdateProgressInfo()).AddTo(Disposables);
		}
		if (MissionData.IsCompleted != null)
		{
			MissionData.IsCompleted.Subscribe(v => UpdateLayout(v, MissionData.IsRewarded != null && MissionData.IsRewarded.Value)).AddTo(Disposables);
		}
		if (MissionData.IsRewarded != null)
		{
			MissionData.IsRewarded.Subscribe(v => UpdateLayout(MissionData.IsCompleted != null && MissionData.IsCompleted.Value, v)).AddTo(Disposables);
		}
	}

	private void UpdateLayout(bool isCompleted, bool isRewarded)
	{
		if (ProgressObj != null) ProgressObj.SetActive(!isCompleted && !isRewarded);
		if (NotCompleteObj != null) NotCompleteObj.SetActive(!isCompleted && !isRewarded);
		if (CompleteObj != null) CompleteObj.SetActive(isCompleted && !isRewarded);
		if (RewardedObj != null) RewardedObj.SetActive(isRewarded);
		if (ClaimBtnObj != null) ClaimBtnObj.SetActive(isCompleted && !isRewarded);
		if (ShortCutBtnObj != null) ShortCutBtnObj.SetActive(!isCompleted && !isRewarded);
		if (LayoutElement != null)
			LayoutElement.preferredHeight = isRewarded ? RewardedHeight : NormalHeight;
	}

	private void UpdateProgressInfo()
	{
		if (MissionData == null) return;
		string progressText = MissionData.GetMissionProgressText();
		if (ProgressSlider != null && MissionData.TargetValue > 0)
		{
			float cur = MissionData.CurrentValue != null ? (float)(double)MissionData.CurrentValue.Value : 0f;
			ProgressSlider.value = Mathf.Clamp01(cur / MissionData.TargetValue);
		}
	}

	private void OnClickRefreshBtn()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}

	private void OnClickShortCutBtn()
	{
		if (IsReqShortCut) return;
		IsReqShortCut = true;
	}

	private void OnClickClaimBtn()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		UpdateLayout(true, true);
	}
}
