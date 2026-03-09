using System;
using UnityEngine;

public class BoosterButtonHintBubble : MonoBehaviour
{
	private const string ANIM_ANIM_LEVELINFO_OUTRO = "Anim-LevelInfo-Outro";

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private float m_minTimeToStay;

	[SerializeField]
	private float m_maxTimeToStay;

	private Action m_finishCallback;

	private float m_time;

	public void Activate(Action finishCallback = null)
	{
	}

	private void Update()
	{
	}

	private void Deactivate()
	{
	}
}
