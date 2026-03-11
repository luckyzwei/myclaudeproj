using Balancy.Models.JigsawPuzzleEvent;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class WidgetPuzzleCollection : MonoBehaviour
{
	[SerializeField]
	private JigsawSeasonWidget m_activeSeasonWidget;

	[SerializeField]
	private JigsawOldSeasonWidget m_oldSeasonWidget;

	[SerializeField]
	private RectTransform m_seasonsParent;

	[SerializeField]
	private RectTransform m_oldSeasonsParent;

	[SerializeField]
	private RectTransform m_content;

	[SerializeField]
	private JigsawSeasonWidget m_firstActiveEvent;

	[SerializeField]
	private GameObject m_noActiveEventsText;

	[SerializeField]
	private GameObject m_lockedGameObject;

	[SerializeField]
	private Text m_unlockAtLevelX;

	[SerializeField]
	private string m_unlockLevelKey;

	[SerializeField]
	private ScrollRect m_scrollRect;

	[SerializeField]
	private Transform m_rewardPosition;

	[SerializeField]
	private JigsawPiecesRewardController m_rewardController;

	[SerializeField]
	private Image m_white;

	[SerializeField]
	private GameObject m_pastEventsDivider;

	private JigsawSeasonWidget m_seasonWidget;

	private int m_activeEventsCount;

	private int m_loadedWidgetsCount;

	private bool m_successfullyLoaded;

	private bool m_waitForTutorial;

	private bool m_isFadingWhite;

	private bool m_showingNewEventStart;

	private bool m_showingEventStart;

	private void Awake()
	{
	}

	private void CoreEvents_PopupShown(PopUpBase popUpBase)
	{
	}

	private void CoreEvents_PopupClosed(PopUpBase popUpBase)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void LoadSeasonWidgets(string eventId = "")
	{
	}

	private void ShowJigsawPuzzleInfo(JigsawEvent jigsawEvent)
	{
	}

	private void OnSeasonCellsLoaded()
	{
	}

	private void HideWhiteOverlay()
	{
	}

	private void OnEnable()
	{
	}

	public void MovePiecesIntoPuzzles(bool reloadPuzzles = false, bool allowRv = true)
	{
	}

	public void ScrollTo(RectTransform targetElement, bool immediately)
	{
	}

	private void GameplayEvents_JigsawRvFinished()
	{
	}
}
