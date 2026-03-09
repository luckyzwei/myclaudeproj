using UnityEngine;
using UnityEngine.UI;

public class FadeOverlayWidget : MonoBehaviour
{
	[SerializeField]
	private Image m_image;

	[Space]
	[SerializeField]
	private float m_startAlpha;

	[SerializeField]
	private float m_targetAlpha;

	[Space]
	[SerializeField]
	private float m_delay;

	[SerializeField]
	private float m_duration;

	private void OnEnable()
	{
	}
}
