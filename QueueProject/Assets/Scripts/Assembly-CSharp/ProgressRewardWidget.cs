using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ProgressRewardWidget : MonoBehaviour
{
	[SerializeField]
	protected string m_widgetID;

	[SerializeField]
	protected MilestoneCell m_milestoneCellPrefab;

	[SerializeField]
	protected Transform m_milestoneCellParent;

	[SerializeField]
	protected Image m_fillBarImage;

	[SerializeField]
	protected Text m_fillCounterText;

	[SerializeField]
	protected Image m_progressRequiredIcon;

	[Space(10f)]
	[Header("Timings - for tween of the fill bar")]
	[SerializeField]
	protected float m_fillBarStartDelay;

	[SerializeField]
	protected float m_fillBarSpeed;

	[SerializeField]
	protected float m_fillBarResetDelay;

	[Space(10f)]
	[Header("Milestone Namings")]
	[SerializeField]
	protected string m_prefix;

	[SerializeField]
	protected string m_suffix;

	[Space(10f)]
	[Header("interactable button")]
	[Tooltip("Buttons which will get disabled while the progress bar is animating/tweening)")]
	[SerializeField]
	protected Button[] m_progressInteractableButtons;

	[Header("Reward")]
	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	protected PrefabReference m_rewardPopUp;

	[PrefabReferenceRequiredComponent(typeof(RewardPopupBase))]
	[SerializeField]
	protected PrefabReference m_rewardBoxPopUp;

	[SerializeField]
	private float m_delayAfterCellAnim;

	protected List<MilestoneCell> m_milestoneCells;

	protected List<int> m_remainingToOpenMilestoneIndexes;

	protected int m_totalProgressRequired;

	protected bool m_tweenPaused;

	protected int m_fillTo;

	protected float m_fillValue;

	protected bool m_hasFinishedFlow;

	protected bool m_doFakeProgress;

	protected int m_fakeStartProgress;

	protected int m_fakeTargetProgress;

	public string WidgetID => null;

	protected virtual void OnEnable()
	{
	}

	public virtual void RefreshWidget()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void TryUpdateProgressReward()
	{
	}

	protected virtual void UpdateProgressReward()
	{
	}

	protected virtual void TryCheckProgressComplete()
	{
	}

	protected virtual void UnlockRewardFlow(long progressValue, Tween tween)
	{
	}

	protected virtual void OnFillingComplete()
	{
	}

	protected virtual void OnRewardFlowComplete()
	{
	}

	protected virtual void SpawnMilestoneRewards()
	{
	}

	protected virtual void UpdateWidgetVisuals()
	{
	}

	protected virtual void CompleteTrophyRewards()
	{
	}

	private void UpdateFillCounterText(long progressValue)
	{
	}

	protected virtual void CalculateTotalProgressRequirement()
	{
	}

	public void ToggleProgressButtonsInteractable(bool interactable)
	{
	}

	protected Vector3 GetWorldPositionOnFillBar(float fill)
	{
		return default(Vector3);
	}

	public Vector3 GetCurrentWorldPositionOnFillBar()
	{
		return default(Vector3);
	}

	public void FakeProgress(int startProgress, int targetProgress)
	{
	}
}
