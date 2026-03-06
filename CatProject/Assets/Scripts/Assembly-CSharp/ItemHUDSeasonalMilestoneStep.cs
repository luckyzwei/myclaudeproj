using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemHUDSeasonalMilestoneStep : MonoBehaviour
{
	[SerializeField]
	private ItemArticle MilestoneStepRewardItemArticle;

	[SerializeField]
	private Text MilestoneStepRewardText;

	[SerializeField]
	private GameObject StepRewardObj;

	[SerializeField]
	private GameObject StepAchieveCheckObj;

	[SerializeField]
	private GameObject GlowFxObj;

	private int MilestoneRewardStep;

	private int MilestoneRewardIdx;

	private CompositeDisposable Disposables;

	public void Init(int milestoneRewardStep)
	{
		// Initialize
	}

	private void OnDestroy()
	{
		// Cleanup
	}
}
