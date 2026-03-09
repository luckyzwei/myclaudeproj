using UnityEngine;
using UnityEngine.UI;

public class RulesHighlighter : MonoBehaviour
{
	[SerializeField]
	private Image[] m_highlights;

	[SerializeField]
	private float m_maxAlpha;

	[SerializeField]
	private float m_minAlpha;

	[SerializeField]
	private float m_timeToFade;

	[SerializeField]
	private float m_delayBetweenFades;

	[SerializeField]
	private int m_loops;

	private QueensGrid m_queensGrid;

	private LevelData m_levelData;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void GameplayEvents_WrongCellMarked(int cellIndex)
	{
	}

	private bool CheckColour(int cellIndex)
	{
		return false;
	}

	private bool CheckQueensTouching(int cellIndex)
	{
		return false;
	}

	private bool CheckQueensColumnAndRow(int cellIndex)
	{
		return false;
	}

	private void HighlightRule(int index)
	{
	}
}
