using UnityEngine;

public class QueensGridCell : MonoBehaviour
{
	private const string ANIM_MOVE_DOWN = "Move-Down";

	private const string ANIM_MOVE_UP = "Move-Up";

	private const string ANIM_MOVE_RIGHT = "Move-Right";

	private const string ANIM_MOVE_LEFT = "Move-Left";

	private const string ANIM_OUTLINE_HIGHLIGHT = "Outline-Highlight";

	private const string ANIM_IN = "In";

	private const string ANIM_OUT_L = "Out-L";

	private const string ANIM_OUT_R = "Out-R";

	private const string ANIM_ANIM_TILE_QUEEN_OUT = "Anim-Tile-Queen-Out";

	private const string ANIM_ANIM_TILE_QUEEN_VISIBLE = "Anim-Tile-Queen-Visible";

	private const string ANIM_MARKER_IN = "Marker-In";

	private const string ANIM_MARKER_IN_OTHER_SHAPES = "Marker-In-Other";

	private const string ANIM_OUT = "Out";

	private const string ANIM_IDLE = "Idle";

	private const string ANIM_LIFELOST = "LifeLost";

	private const string ANIM_HINT = "Hint";

	private const string ANIM_MARKER_OUT = "Marker-Out";

	private const string ANIM_LIFELOST_HEART = "LifeLost-Heart";

	private const string ANIM_LIFELOST_FTUE = "LifeLost-FTUE";

	private const string ANIM_FADE = "Fade";

	private const string ANIM_ANIM_X = "Anim-X";

	private const float TIME_TO_FADE_OUT = 0.25f;

	[SerializeField]
	private Transform m_content;

	[SerializeField]
	private SpriteRenderer m_backColour;

	[SerializeField]
	private SpriteRenderer m_whiteBg;

	[SerializeField]
	private SpriteRenderer m_queenColour;

	[SerializeField]
	private SpriteRenderer m_flourishCrownSprite;

	[SerializeField]
	private SpriteRenderer m_baseCrownSprite;

	[SerializeField]
	private SpriteRenderer m_markerSpriteRenderer;

	[SerializeField]
	private AnimatorHelper m_cellAnimator;

	[SerializeField]
	private AnimatorHelper m_markerAnimator;

	[SerializeField]
	private AnimatorHelper m_queenAnimator;

	[SerializeField]
	private AnimatorHelper m_xAnimator;

	[SerializeField]
	private Vector3 m_punchScale;

	[SerializeField]
	private float m_punchTime;

	[SerializeField]
	private BoxCollider2D m_boxCollider2D;

	[SerializeField]
	private GameObject m_hintHighlight;

	[SerializeField]
	private bool m_isCornerCell;

	private int m_cellIndex;

	private Vector2Int m_coords;

	private int m_colourIndex;

	private Material m_queenTileMaterial;

	private int m_value;

	private bool m_dontAcceptX;

	private bool m_isPlayingFade;

	public int CellIndex => 0;

	public Vector2Int Coords => default(Vector2Int);

	public BoxCollider2D BoxCollider2D => null;

	public int Value => 0;

	public bool IsCornerCell => false;

	public int Colour => 0;

	public void Configure(int cellIndex, int colorIndex, int x, int y)
	{
	}

	private void OnDestroy()
	{
	}

	private void SetSkin()
	{
	}

	private void SetCrossSprite()
	{
	}

	private void SetFlourishCrownSprite(Sprite sprite)
	{
	}

	private void SetBaseCrownSprite(Sprite sprite)
	{
	}

	private void SetColour()
	{
	}

	public void ReColour(int colorIndex)
	{
	}

	public void SetAsQueen(bool animate = true)
	{
	}

	public void SetAsX(bool hint, bool sound, float pitch)
	{
	}

	public void SetAsLoseLife()
	{
	}

	public void SetAsLoseLifeFTUE()
	{
	}

	public void Celebrate(bool left)
	{
	}

	public void Flip(bool x, bool y)
	{
	}

	public Vector3 GetFlipValue()
	{
		return default(Vector3);
	}

	public void Clear(float pitch = 1f, bool playSound = true)
	{
	}

	public void Highlight(bool highlight)
	{
	}

	public void ShowHintHighlight(bool highlight)
	{
	}

	private Color CellColour(int colourIndex)
	{
		return default(Color);
	}

	public void PlayFade()
	{
	}

	public void StopFade()
	{
	}

	public void SetColliderEnabled(bool active)
	{
	}

	public void DontAcceptX(bool dontAcceptX = true)
	{
	}

	private void SetupOutline()
	{
	}
}
