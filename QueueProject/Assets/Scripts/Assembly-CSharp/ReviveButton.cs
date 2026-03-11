using UnityEngine.UI;
using UnityEngine;

public class ReviveButton : MonoBehaviour
{
	[SerializeField]
	private GameObject m_playOn;

	[SerializeField]
	private GameObject m_threeHearts;

	[SerializeField]
	private Text m_livesText;

	private void Awake()
	{
	}
}
