using TMPro;
using UnityEngine;

public class QueensEventGameplayButton : QueensEventLevelCompleteButton
{
	private const string ANIM_ANIM_EVENTBUTTON_HIT = "Anim-EventButton-Hit";

	[SerializeField]
	private TextMeshProUGUI m_gemCountText;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	private QueensGrid m_grid;

	private int m_gems;

	private void Awake()
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClaimedAllTreasureEventRewards()
	{
	}

	private void UpdateGems(int gemsCount)
	{
	}

	protected override bool IsQueensEventActive()
	{
		return false;
	}

	public override void OnPressed()
	{
	}
}
