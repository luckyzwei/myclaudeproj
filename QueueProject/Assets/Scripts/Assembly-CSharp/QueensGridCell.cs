using DG.Tweening;
using UnityEngine;

public class QueensGridCell : MonoBehaviour
{
	private const string ANIM_MOVE_DOWN = "Move-Down";

	private const string ANIM_MOVE_UP = "Move-Up";

	private const string ANIM_MOVE_RIGHT = "Move-Right";

	private const string ANIM_MOVE_LEFT = "Move-Left";

	private const string ANIM_OUTLINE_HIGHLIGHT = "Outline-Highlight";

	private const string ANIM_CELEBRATE_L = "Celebrate-L";

	private const string ANIM_CELEBRATE_R = "Celebrate-R";

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

	private Vector3 m_flipScale = Vector3.one;

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

	private GameObject m_vfxCelebrate;

	private SpriteRenderer m_queenBackground;

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
		SetSkin();

		// Hide queen crown GameObjects initially (animations control m_IsActive, not SpriteRenderer.enabled)
		if (m_flourishCrownSprite != null)
			m_flourishCrownSprite.gameObject.SetActive(false);
		if (m_baseCrownSprite != null)
			m_baseCrownSprite.gameObject.SetActive(false);

		// Cache VFX-Celebrate reference (including inactive objects)
		CacheVFXCelebrate();
	}

	private void CacheVFXCelebrate()
	{
		// Find VFX-Celebrate and queen Background under Tile-Queen-Base
		Transform queenBase = m_queenAnimator != null ? m_queenAnimator.transform : null;
		if (queenBase != null)
		{
			for (int i = 0; i < queenBase.childCount; i++)
			{
				var child = queenBase.GetChild(i);
				if (child.name == "Background")
					m_queenBackground = child.GetComponent<SpriteRenderer>();
			}
		}

		var allTransforms = GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < allTransforms.Length; i++)
		{
			if (allTransforms[i].name == "VFX-Celebrate")
			{
				m_vfxCelebrate = allTransforms[i].gameObject;
				break;
			}
		}
	}

	private void OnDestroy()
	{
		m_queenTileMaterial = null;
	}

	private static Sprite s_defaultCrownSprite;
	private static bool s_crownSpriteLoaded;

	private void SetSkin()
	{
		// Load default crown sprite (Tile-Queen-Crown) as fallback for skin-A
		if (!s_crownSpriteLoaded)
		{
			s_crownSpriteLoaded = true;
			s_defaultCrownSprite = Resources.Load<Sprite>("sprites/Tile-Queen-Crown");
			if (s_defaultCrownSprite == null)
				UnityEngine.Debug.LogWarning("[GridCell] Could not load Tile-Queen-Crown from Resources");
		}
		if (s_defaultCrownSprite != null)
		{
			SetFlourishCrownSprite(s_defaultCrownSprite);
			SetBaseCrownSprite(s_defaultCrownSprite);
		}
	}

	private void SetCrossSprite()
	{
		// X marker sprite is already assigned in prefab (Tex-Xdrawn_11)
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
		if (m_queenBackground != null)
			m_queenBackground.color = color;
	}

	public void ReColour(int colorIndex)
	{
		m_colourIndex = colorIndex;
		SetColour();
	}

	public void SetAsQueen(bool animate = true)
	{
		m_value = QueensGrid.QUEEN;

		// Set crown scale (prefab default is 0.28, too small)
		float crownScale = 0.76f;
		if (m_flourishCrownSprite != null)
			m_flourishCrownSprite.transform.localScale = new Vector3(crownScale, crownScale, crownScale);
		if (m_baseCrownSprite != null)
			m_baseCrownSprite.transform.localScale = new Vector3(crownScale, crownScale, crownScale);

		if (animate)
		{
			// Punch scale the whole cell (use m_content to avoid Animator overriding root scale)
			if (m_content != null)
			{
				m_content.DOKill();
				m_content.localScale = m_flipScale;
				m_content.DOPunchScale(m_punchScale, m_punchTime, 6, 0.5f);
			}

			// "In" animation on AC-Tile: queen spins in with rotation, scale bounce,
			// glow effect, crown management, and haptic feedback (~1.32s)
			if (m_queenAnimator != null)
				m_queenAnimator.Play(ANIM_IN);
			PlayQueenVFX();
			PlayQueenSound();
		}
		else
		{
			// "Anim-Tile-Queen-Visible": quick scale punch 0→1.2→1.0 (0.3s),
			// enables Queen SpriteRenderer, activates both crowns
			if (m_queenAnimator != null)
				m_queenAnimator.Play(ANIM_ANIM_TILE_QUEEN_VISIBLE);
			// Hide BaseCrown to avoid two overlapping crowns (Visible activates both)
			if (m_baseCrownSprite != null)
				m_baseCrownSprite.gameObject.SetActive(false);
		}
	}

	private void PlayQueenVFX()
	{
		// Use cached reference instead of searching each time
		if (m_vfxCelebrate != null)
		{
			m_vfxCelebrate.SetActive(true);
			var ps = m_vfxCelebrate.GetComponent<ParticleSystem>();
			if (ps != null) ps.Play(true);
		}
	}

	private void StopQueenVFX()
	{
		if (m_vfxCelebrate != null)
		{
			var ps = m_vfxCelebrate.GetComponent<ParticleSystem>();
			if (ps != null) ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
			m_vfxCelebrate.SetActive(false);
		}
	}

	private void PlayQueenSound()
	{
		var sfx = QueensGameController.CurrentSFX;
		if (sfx == null || sfx.QueenGood == null || sfx.QueenGood.audioClip == null) return;
		AudioSource.PlayClipAtPoint(sfx.QueenGood.audioClip, Camera.main != null ? Camera.main.transform.position : Vector3.zero, sfx.QueenGood.volume > 0f ? sfx.QueenGood.volume : 1f);
	}

	public void SetAsX(bool hint, bool sound, float pitch)
	{
		if (m_dontAcceptX) return;
		m_value = QueensGrid.X;
		// Activate marker container (starts inactive in prefab)
		if (m_markerAnimator != null && !m_markerAnimator.gameObject.activeSelf)
			m_markerAnimator.gameObject.SetActive(true);
		if (m_xAnimator != null)
			m_xAnimator.Play(ANIM_ANIM_X);
		if (m_markerAnimator != null)
			m_markerAnimator.Play(hint ? ANIM_HINT : ANIM_MARKER_IN);
		// Play X mark sound effect
		if (sound)
			PlayXSound(pitch);
	}

	private void PlayXSound(float pitch)
	{
		var sfx = QueensGameController.CurrentSFX;
		if (sfx == null || sfx.X == null || sfx.X.Length == 0) return;
		var clipRef = sfx.X[UnityEngine.Random.Range(0, sfx.X.Length)];
		if (clipRef == null || clipRef.audioClip == null) return;
		AudioSource.PlayClipAtPoint(clipRef.audioClip, Camera.main != null ? Camera.main.transform.position : Vector3.zero, clipRef.volume > 0f ? clipRef.volume : 1f);
	}

	public void SetAsLoseLife()
	{
		// Lock this cell permanently after wrong queen placement
		if (m_markerAnimator != null)
		{
			if (!m_markerAnimator.gameObject.activeSelf)
				m_markerAnimator.gameObject.SetActive(true);
			m_markerAnimator.Play(ANIM_LIFELOST);
		}
		m_dontAcceptX = true;
		m_value = QueensGrid.QUEEN; // Treat as occupied so MarkXCell/ClearCell skip it
	}

	public void SetAsLoseLifeFTUE()
	{
		// LifeLost-FTUE is in AC-Tile-Marker (m_markerAnimator)
		if (m_markerAnimator != null)
			m_markerAnimator.Play(ANIM_LIFELOST_FTUE);
	}

	public void Celebrate(bool left)
	{
		m_value = QueensGrid.QUEEN;

		float crownScale = 0.76f;
		if (m_flourishCrownSprite != null)
			m_flourishCrownSprite.transform.localScale = new Vector3(crownScale, crownScale, crownScale);
		if (m_baseCrownSprite != null)
			m_baseCrownSprite.transform.localScale = new Vector3(crownScale, crownScale, crownScale);

		// Restore Queen SpriteRenderer (In animation disables it at the end, WDV=0 won't restore)
		if (m_queenColour != null)
			m_queenColour.enabled = true;

		// Ensure FlourishCrown active, hide BaseCrown (avoid two crowns overlapping)
		if (m_flourishCrownSprite != null)
			m_flourishCrownSprite.gameObject.SetActive(true);
		if (m_baseCrownSprite != null)
			m_baseCrownSprite.gameObject.SetActive(false);

		// Play Out-L/Out-R: Queen rotates ±20° + scales 1.4x + moves up + VFX
		if (m_queenAnimator != null)
			m_queenAnimator.Play(left ? ANIM_OUT_L : ANIM_OUT_R);
	}

	public void Flip(bool x, bool y)
	{
		if (m_content == null) return;
		Vector3 scale = m_content.localScale;
		if (x) scale.x = -scale.x;
		if (y) scale.y = -scale.y;
		m_content.localScale = scale;
		m_flipScale = scale;
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
		StopQueenVFX();
		if (playSound)
			PlayUndoXSound(pitch);
	}

	private void PlayUndoXSound(float pitch)
	{
		var sfx = QueensGameController.CurrentSFX;
		if (sfx == null || sfx.UndoX == null || sfx.UndoX.Length == 0) return;
		var clipRef = sfx.UndoX[UnityEngine.Random.Range(0, sfx.UndoX.Length)];
		if (clipRef == null || clipRef.audioClip == null) return;
		AudioSource.PlayClipAtPoint(clipRef.audioClip, Camera.main != null ? Camera.main.transform.position : Vector3.zero, clipRef.volume > 0f ? clipRef.volume : 1f);
	}

	public void Highlight(bool highlight)
	{
		if (m_whiteBg != null)
			m_whiteBg.enabled = highlight;

		// 播放 Outline-Highlight 脉冲动画（循环闪烁效果，引导玩家注意目标格子）
		if (m_cellAnimator != null)
		{
			if (highlight)
				m_cellAnimator.Play(ANIM_OUTLINE_HIGHLIGHT);
			else
				m_cellAnimator.Play(ANIM_IDLE);
		}
	}

	public void ShowHintHighlight(bool highlight)
	{
		if (m_hintHighlight != null)
			m_hintHighlight.SetActive(highlight);
	}

	private Color CellColour(int colourIndex)
	{
		var cm = CosmeticsManager.Instance;
		if (cm != null)
		{
			var config = cm.GetCurrentColorConfig();
			if (config != null && config.colors != null && colourIndex >= 0 && colourIndex < config.colors.Count)
				return config.colors[colourIndex];
		}
		return Color.white;
	}

	public void PlayFade()
	{
		m_isPlayingFade = true;
		// Fade is in AC-Tile-Marker (m_markerAnimator)
		if (m_markerAnimator != null)
			m_markerAnimator.Play(ANIM_FADE);
	}

	public void StopFade()
	{
		m_isPlayingFade = false;
		// Idle is in AC-Tile-Marker (m_markerAnimator)
		if (m_markerAnimator != null)
			m_markerAnimator.Play(ANIM_IDLE);
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
