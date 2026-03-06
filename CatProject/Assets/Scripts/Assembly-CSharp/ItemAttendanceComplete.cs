using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemAttendanceComplete : MonoBehaviour
{
	[SerializeField]
	private ItemArticle CompleteRewardItem;

	[SerializeField]
	private Text CompleteStepText;

	[SerializeField]
	private Slider CompleteStepSlider;

	[SerializeField]
	private GameObject PossibleClaimObject;

	[SerializeField]
	private GameObject ClaimedObject;

	[SerializeField]
	private Button ClaimButton;

	[SerializeField]
	private Button ItemInfoButton;

	private E_AttendanceEventType EventType;

	private CompositeDisposable Disposables;

	private void Awake()
	{
		Disposables = new CompositeDisposable();
		if (ClaimButton != null) ClaimButton.onClick.AddListener(OnClaimButtonClick);
		if (ItemInfoButton != null) ItemInfoButton.onClick.AddListener(() => Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>());
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public void Init(E_AttendanceEventType eventType)
	{
		EventType = eventType;
		UpdateProgress();
	}

	private void UpdateProgress()
	{
		// Update display
	}

	private void OnClaimButtonClick()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
