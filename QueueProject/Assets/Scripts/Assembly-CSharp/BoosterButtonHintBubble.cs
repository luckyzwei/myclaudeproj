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

	private bool m_active;

	public void Activate(Action finishCallback = null)
	{
		m_finishCallback = finishCallback;
		m_time = 0f;
		m_active = true;
		gameObject.SetActive(true);
	}

	private void Update()
	{
		if (!m_active) return;
		m_time += Time.deltaTime;
		if (m_time >= m_maxTimeToStay)
			Deactivate();
	}

	private void Deactivate()
	{
		m_active = false;
		if (m_animatorHelper != null)
		{
			m_animatorHelper.Play(ANIM_ANIM_LEVELINFO_OUTRO, () =>
			{
				gameObject.SetActive(false);
				m_finishCallback?.Invoke();
			});
		}
		else
		{
			gameObject.SetActive(false);
			m_finishCallback?.Invoke();
		}
	}
}
