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

	public int CellIndex => m_cellIndex;

	public Vector2Int Coords => m_coords;

	public BoxCollider2D BoxCollider2D => m_boxCollider2D;

	public int Value => m_value;

	public bool IsCornerCell => m_isCornerCell;

	public int Colour => m_colourIndex;

	public void Configure(int cellIndex, int colorIndex, int x, int y)
	{
		m_cellIndex = cellIndex;
		m_colourIndex = colorIndex;
		m_coords = new Vector2Int(x, y);
		m_value = QueensGrid.NONE;
		m_dontAcceptX = false;
		SetColour();
	}

	private void OnDestroy()
	{
		m_queenTileMaterial = null;
	}

	private void SetSkin()
	{
		// Apply queen skin from player profile
	}

	private void SetCrossSprite()
	{
		// Apply X marker sprite
	}

	private void SetFlourishCrownSprite(Sprite sprite)
	{
		if (m_flourishCrownSprite != null)
			m_flourishCrownSprite.sprite = sprite;
	}

	private void SetBaseCrownSprite(Sprite sprite)
	{
		if (m_baseCrownSprite != null)
			m_baseCrownSprite.sprite = sprite;
	}

	private void SetColour()
	{
		Color color = CellColour(m_colourIndex);
		if (m_backColour != null)
			m_backColour.color = color;
		if (m_queenColour != null)
			m_queenColour.color = color;
	}

	public void ReColour(int colorIndex)
	{
		m_colourIndex = colorIndex;
		SetColour();
	}

	public void SetAsQueen(bool animate = true)
	{
		m_value = QueensGrid.QUEEN;
		if (m_queenAnimator != null && animate)
			m_queenAnimator.Play(ANIM_ANIM_TILE_QUEEN_VISIBLE);
		if (m_cellAnimator != null && animate)
			m_cellAnimator.Play(ANIM_IN);
	}

	public void SetAsX(bool hint, bool sound, float pitch)
	{
		if (m_dontAcceptX) return;
		m_value = QueensGrid.X;
		if (m_xAnimator != null)
			m_xAnimator.Play(ANIM_ANIM_X);
		if (m_markerAnimator != null)
			m_markerAnimator.Play(hint ? ANIM_HINT : ANIM_MARKER_IN);
	}

	public void SetAsLoseLife()
	{
		if (m_cellAnimator != null)
			m_cellAnimator.Play(ANIM_LIFELOST);
	}

	public void SetAsLoseLifeFTUE()
	{
		if (m_cellAnimator != null)
			m_cellAnimator.Play(ANIM_LIFELOST_FTUE);
	}

	public void Celebrate(bool left)
	{
		if (m_cellAnimator != null)
			m_cellAnimator.Play(left ? ANIM_OUT_L : ANIM_OUT_R);
	}

	public void Flip(bool x, bool y)
	{
		if (m_content == null) return;
		Vector3 scale = m_content.localScale;
		if (x) scale.x = -scale.x;
		if (y) scale.y = -scale.y;
		m_content.localScale = scale;
	}

	public Vector3 GetFlipValue()
	{
		if (m_content == null) return Vector3.one;
		return m_content.localScale;
	}

	public void Clear(float pitch = 1f, bool playSound = true)
	{
		m_value = QueensGrid.NONE;
		if (m_markerAnimator != null)
			m_markerAnimator.Play(ANIM_MARKER_OUT);
		if (m_queenAnimator != null)
			m_queenAnimator.Play(ANIM_ANIM_TILE_QUEEN_OUT);
	}

	public void Highlight(bool highlight)
	{
		if (m_whiteBg != null)
			m_whiteBg.enabled = highlight;
	}

	public void ShowHintHighlight(bool highlight)
	{
		if (m_hintHighlight != null)
			m_hintHighlight.SetActive(highlight);
	}

	private Color CellColour(int colourIndex)
	{
		// Default color palette
		Color[] palette = new Color[]
		{
			new Color(0.95f, 0.55f, 0.55f), // red
			new Color(0.55f, 0.75f, 0.95f), // blue
			new Color(0.55f, 0.90f, 0.55f), // green
			new Color(0.95f, 0.85f, 0.45f), // yellow
			new Color(0.75f, 0.55f, 0.95f), // purple
			new Color(0.95f, 0.70f, 0.40f), // orange
			new Color(0.55f, 0.90f, 0.85f), // teal
			new Color(0.90f, 0.55f, 0.80f), // pink
			new Color(0.70f, 0.70f, 0.70f), // gray
		};
		if (colourIndex >= 0 && colourIndex < palette.Length)
			return palette[colourIndex];
		return Color.white;
	}

	public void PlayFade()
	{
		m_isPlayingFade = true;
		if (m_cellAnimator != null)
			m_cellAnimator.Play(ANIM_FADE);
	}

	public void StopFade()
	{
		m_isPlayingFade = false;
		if (m_cellAnimator != null)
			m_cellAnimator.Play(ANIM_IDLE);
	}

	public void SetColliderEnabled(bool active)
	{
		if (m_boxCollider2D != null)
			m_boxCollider2D.enabled = active;
	}

	public void DontAcceptX(bool dontAcceptX = true)
	{
		m_dontAcceptX = dontAcceptX;
	}

	private void SetupOutline()
	{
		// Setup outline/border visuals based on adjacent cells
	}
}
