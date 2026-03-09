using TMPro;
using UnityEngine;

public class DailyRewardWidget : MonoBehaviour
{
	private const string ANIM_ANIM_WIDGETHOME_INTRO = "Anim-WidgetHome-Intro";

	[SerializeField]
	private GameObject[] m_lockedGameobjects;

	[SerializeField]
	private GameObject[] m_unlockedGameobjects;

	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private TMP_Text m_lockText;

	[SerializeField]
	private string m_unlockTextKey;

	private bool m_canOpenDailyReward;

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
