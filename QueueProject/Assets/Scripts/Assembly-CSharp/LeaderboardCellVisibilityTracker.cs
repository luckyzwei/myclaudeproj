using System.Collections.Generic;
using UnityEngine;

public class LeaderboardCellVisibilityTracker : ScrollItemVisibilityTracker<LeaderboardCell>
{
	[SerializeField]
	private List<RectTransform> m_clampPoints;

	[SerializeField]
	private LeaderboardCell m_clampedCell;

	public LeaderboardCell GetClampedCell()
	{
		return null;
	}

	protected override void OnScrollItemVisible()
	{
	}

	protected override void OnScrollItemInvisible()
	{
	}

	private void UpdateClampedCellParent(RectTransform newParent)
	{
	}

	private RectTransform GetNearestClampPoint(RectTransform rt)
	{
		return null;
	}
}
