using Balancy.Models;
using UnityEngine;

public class JigsawTimerNavBarController : MonoBehaviour
{
	private const long TWO_DAYS_S = 172800L;

	[SerializeField]
	private JigsawEventTimerWidget m_jigsawEventTimerWidget;

	private JigsawPuzzleGameEvent m_puzzleGameEvent;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void TabChanged(int tab, bool immediately)
	{
	}

	private void CanShowTimer()
	{
	}
}
