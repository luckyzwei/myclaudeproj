using UnityEngine;
using UnityEngine.UI;

public class JigsawHomeWidget : MonoBehaviour
{
	private const int JIGSAW_TAB_INDEX = 4;

	[SerializeField]
	private Image m_poster;

	[SerializeField]
	private Text m_text;

	[SerializeField]
	private TabToolbar m_tabToolbar;

	[SerializeField]
	private GameObject m_lockOverlay;

	[SerializeField]
	private Text m_lockText;

	[SerializeField]
	private string m_lockFormatKey;

	[SerializeField]
	private JigsawEventTimerWidget m_timer;

	private bool m_isLocked;

	private void Start()
	{
	}

	public void Clicked()
	{
	}
}
