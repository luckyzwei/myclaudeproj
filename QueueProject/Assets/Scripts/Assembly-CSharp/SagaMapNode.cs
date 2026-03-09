using System;
using KWLocalisation.Localisation;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SagaMapNode : MonoBehaviour
{
	public enum NodeState
	{
		DISABLED = 0,
		CURRENT = 1,
		COMPLETE = 2
	}

	private const string ANIM_DISABLED = "Disabled";

	private const string ANIM_COMPLETE = "Complete";

	private const string ANIM_CURRENT = "Current";

	private const string ANIM_COMPLETEFIRSTTRY = "CompleteFirstTry";

	[Header("Animator")]
	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[Header("Text")]
	[SerializeField]
	private TextWrapper m_levelText;

	[Header("Text")]
	[SerializeField]
	[Autohook]
	private Button m_button;

	private int m_assignedLevel;

	private float m_totalHeight;

	private UnityEvent<int> m_onPressedCallback;

	public int Level => 0;

	public float TotalHeight => 0f;

	public RectTransform RectTransform => null;

	public void Configure(NodeState state, int level)
	{
	}

	public void ListenToPress(UnityEvent<int> onSagaMapButtonPressed)
	{
	}

	private void RegisterButtonPress()
	{
	}

	protected virtual void OnSagaMapButtonPressed()
	{
	}

	public void SetCompleted(Action animCompleteCallback, float startTime = 0f)
	{
	}

	public void SetAsCurrent()
	{
	}

	private void CalculateTotalHeight()
	{
	}
}
