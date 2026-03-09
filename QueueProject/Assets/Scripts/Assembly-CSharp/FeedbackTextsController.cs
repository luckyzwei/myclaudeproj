using System.Collections.Generic;
using UnityEngine;

public class FeedbackTextsController : MonoBehaviour
{
	[SerializeField]
	private string[] m_textKeys;

	[SerializeField]
	private int m_startLevel;

	private FeedbackText[] m_feedbackTexts;

	private string[] m_textsLocalized;

	private float m_lastQueenFoundTime;

	private List<int> m_availableIndexes;

	private int m_lastIndex;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnQueenFound(int queenNumber, bool isLastOne, bool isBoosterUsed)
	{
	}

	private void OnMistakeMade(int obj)
	{
	}

	private void OnCrossMarked(int obj)
	{
	}

	private void ShowFeedbackText()
	{
	}
}
