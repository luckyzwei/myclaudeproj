using UnityEngine;

public class PlayableAreaBlocker : MonoBehaviour
{
	public enum ScreenSide
	{
		TOP = 0,
		TOP_LEFT = 1,
		LEFT = 2,
		BOTTOM_LEFT = 3,
		BOTTOM = 4,
		BOTTOM_RIGHT = 5,
		RIGHT = 6,
		TOP_RIGHT = 7
	}

	[SerializeField]
	private ScreenSide m_side;

	public ScreenSide Side => default(ScreenSide);

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
