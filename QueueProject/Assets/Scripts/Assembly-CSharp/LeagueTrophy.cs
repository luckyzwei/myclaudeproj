using UnityEngine;
using UnityEngine.UI;

public class LeagueTrophy : MonoBehaviour
{
	[SerializeField]
	private Image m_visibleImage;

	[SerializeField]
	private Image m_hiddenImage;

	[SerializeField]
	private GameObject m_arrowObjectHihlighted;

	[SerializeField]
	private GameObject m_arrowObjectNonHilighted;

	[SerializeField]
	private GameObject m_hilightObject;

	[SerializeField]
	private GameObject m_vfxObject;

	public void Config(int leagueIndex)
	{
	}
}
