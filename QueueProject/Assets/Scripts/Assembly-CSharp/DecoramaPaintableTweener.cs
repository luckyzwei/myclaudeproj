using System;
using UnityEngine;

public class DecoramaPaintableTweener : MonoBehaviour
{
	private const float PUNCH_SCALE_MULTI = 0.25f;

	private const float PUNCH_DURATION = 0.1f;

	private const float COMPLETE_SQUASH_MULTIPLIER_Y = 0.5f;

	private const float COMPLETE_SQUASH_JUMP_MULTIPLIER_Y = 1.25f;

	private const float COMPLETE_SQUASH_MULTIPLIER_X = 0.75f;

	private const float COMPLETE_SQUASH_DURATION = 0.2f;

	private const float COMPLETE_JUMP_DURATION = 0.3f;

	private const float COMPLETE_RESET_DURATION = 0.2f;

	private const float COMPLETE_JUMP_AMOUNT = 1f;

	private const float REVEAL_MAX_SCALE_MULTI = 1.3f;

	private const float REVEAL_MAX_SCALE_TIME = 0.25f;

	private const float REVEAL_ORIGINAL_SCALE_TIME = 0.5f;

	private float m_lastPunchTime;

	public void TryPunch(Renderer[] renderersToPunch)
	{
	}

	public void RevealTween(Renderer[] renderersToReveal)
	{
	}

	[ContextMenu("CompleteTween")]
	public void CompleteTween(Renderer[] renderersToReveal, Action onComplete)
	{
	}
}
