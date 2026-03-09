using System;
using UnityEngine;

namespace Queens.UI.Leaderboard
{
	public class QueensLeaderboardPositionChangeAnimator : LeaderboardCellPositionChangeAnimator
	{
		[Header("ScoreTweenParams")]
		[SerializeField]
		private float m_lerpScoreDelay;

		[SerializeField]
		private float m_lerpScoreDuration;

		private const string ANIM_LEADERBOARDCELL_INTRO = "LeaderboardCell-Intro";

		private const string ANIM_LEADERBOARDCELL_OUTRO = "LeaderboardCell-Outro";

		private CurrencyExplosionReceiver[] m_currencyExplosionReceivers;

		private AnimatorHelper m_overlayAnimatorHelper;

		private LeaderboardCellPlayerAdditions m_overlayCellAdditions;

		private bool m_hasMovement;

		private void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void InitialiseOverlayItem(LeaderboardCell sourceItem)
		{
		}

		public override void AnimateItem(int fromIndex, int toIndex, int fromPosition, int toPosition, int fromScore, int toScore, float scrollDuration = -1f, float delay = -1f, Action onComplete = null)
		{
		}

		protected override void ScrollStart()
		{
		}

		private void PlayCellMovementSfx(int movement)
		{
		}

		protected override void AnimateIntro(Action onComplete = null)
		{
		}

		private void PlayCellScaleUpSfx()
		{
		}

		protected override void AnimateOutro(Action onComplete = null)
		{
		}

		private void PlayCellScaleDownSfx()
		{
		}

		protected override void OnIntroFinished()
		{
		}

		protected override void HideTargetCell(LeaderboardCell cell)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
