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
	}

	private void OnDisable()
	{
	}

	public void Init(E_AttendanceEventType eventType)
	{
	}

	private void UpdateProgress()
	{
	}

	private void OnClaimButtonClick()
	{
	}
}
