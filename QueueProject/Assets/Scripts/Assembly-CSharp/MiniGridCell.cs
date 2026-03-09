using UnityEngine;
using UnityEngine.UI;

public class MiniGridCell : MonoBehaviour
{
	[SerializeField]
	private Image m_background;

	[SerializeField]
	private Image m_queen;

	[SerializeField]
	private Image m_cross;

	private Color m_normalCrossColor;

	private Color m_wrongCrossColor;

	private bool m_isPlayingFlourish;

	private bool m_isLeftSide;

	private Vector3 m_crossDefaultScale;

	private bool m_alreadyAnimating;

	public void Config(Color color, Sprite queenSprite, Sprite crossSprite, Color wrongCrossColor, bool isLeft)
	{
	}

	public void SetValue(UserActionType value, bool animate = true)
	{
	}

	private void ShowCross(bool visible, bool animate, bool debug = false)
	{
	}

	public void Flip(bool flipX, bool flipY)
	{
	}

	public void PlayFlourish()
	{
	}
}
