using KWCore.UI;
using UnityEngine.UI;
using UnityEngine;

public class QueensDailyRewardWidget : MonoBehaviour
{
	private const string ANIM_ANIM_WIDGETHOME_INTRO = "Anim-WidgetHome-Intro";

	[SerializeField]
	private GameObject[] m_lockedGameobjects;

	[SerializeField]
	private GameObject[] m_unlockedGameobjects;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Text m_lockText;

	[SerializeField]
	private string m_unlockTextKey;

	[SerializeField]
	private GameObject m_freeText;

	[SerializeField]
	private bool m_showTimer;

	[SerializeField]
	private GameObject m_timerWidget;

	private bool m_canOpenDailyReward;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void PopupClosed(PopUpBase popUpBase)
	{
	}

	private void OnEnable()
	{
	}

	private void SetupOpenButton()
	{
	}

	public void OpenDailyReward()
	{
	}

	private static void ToggleGameObject(GameObject[] gameObjects, bool toggle)
	{
	}
}
