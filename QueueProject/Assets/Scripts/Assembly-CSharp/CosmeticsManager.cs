using System;
using System.Collections.Generic;
using Balancy.Models;
using Balancy.Models.KWPlayerProfile;
using Balancy.Models.Store;
using KWCore.Utils;
using UnityEngine;

public class CosmeticsManager : MonoSingleton<CosmeticsManager>
{
	private const string VIP_SKIN = "Skin_E";

	private const string VIP_COLORS = "BoardColors_D";

	private static bool s_isUsingDefaultX;

	private static Sprite s_crossSprite;

	private static Sprite s_mistakeCrossSprite;

	private static Color s_crossColor;

	private static Color s_mistakeCrossColor;

	[SerializeField]
	private ColourConfig[] m_colorConfig;

	[SerializeField]
	private Sprite m_defaultCrossIcon;

	[SerializeField]
	private Color m_defaultCrossColor;

	[SerializeField]
	private SkinsDb m_skinsDb;

	[SerializeField]
	private Material m_shapesVfxMaterial;

	private bool m_everythingLoaded;

	private static string s_queenSkinClientId = "Skin_A";
	private static string s_boardColorsClientId = "BoardColors_A";
	private static int s_currentColorConfigIndex;

	public static GameplayEvents.BasicDelegate QueenSkinChanged;

	public static GameplayEvents.BasicDelegate BoardColorsChanged;

	public static string QueenSkinClientID => s_queenSkinClientId;

	public static string BoardColorsClientID => s_boardColorsClientId;

	public static bool IsUsingDefaultCross => s_isUsingDefaultX;

	protected override void Init()
	{
		s_isUsingDefaultX = true;
		s_crossColor = m_defaultCrossColor;
		s_crossSprite = m_defaultCrossIcon;
		s_mistakeCrossColor = Color.red;
		s_currentColorConfigIndex = 0;
	}

	private void Start()
	{
		EverythingLoaded();
	}

	private void EverythingLoaded()
	{
		m_everythingLoaded = true;
	}

	private void UpdateProfile()
	{
		// Skip - no server profile
	}

	private static void ChangeVfx()
	{
		// Skip - VFX material changes
	}

	public static void SendQueenSkinChangedEvent()
	{
		QueenSkinChanged?.Invoke();
	}

	public static void SendBoardColorsChangedEvent()
	{
		BoardColorsChanged?.Invoke();
	}

	public static List<QueenSkinIcons> GetAllSkins()
	{
		// Skins come from Balancy config - return null in offline mode
		return null;
	}

	public static List<BoardColorsIcon> GetAllBoardColorsIcons(bool sort = true)
	{
		// Board colors come from Balancy config - return null in offline mode
		return null;
	}

	public ColourConfig GetColorConfigByClientId(string clientId)
	{
		if (m_colorConfig == null) return null;
		// Match by index in name (BoardColors_A = 0, BoardColors_B = 1, etc.)
		for (int i = 0; i < m_colorConfig.Length; i++)
		{
			if (m_colorConfig[i] != null)
				return m_colorConfig[i]; // Return first match for now
		}
		return null;
	}

	public static void GetCurrentBackground(Action<Sprite> callbackBackground)
	{
		callbackBackground?.Invoke(null);
	}

	public static QueenSkinIcons GetCurrentSkin()
	{
		return null;
	}

	public static void ApplyCurrentSkin(Action<Sprite> callbackFlourishSprite, Action<Sprite> callbackBaseSprite, Action callbackCross = null)
	{
		// Load default crown sprite
		var sprite = Resources.Load<Sprite>("sprites/Tile-Queen-Crown");
		callbackFlourishSprite?.Invoke(sprite);
		callbackBaseSprite?.Invoke(sprite);
		callbackCross?.Invoke();
	}

	public static void LoadSkinSpritesById(string skinClientId, Action<Sprite> callbackFlourishSprite, Action<Sprite> callbackBaseSprite, Action<Sprite> callbackCrossSprite)
	{
		var sprite = Resources.Load<Sprite>("sprites/Tile-Queen-Crown");
		callbackFlourishSprite?.Invoke(sprite);
		callbackBaseSprite?.Invoke(sprite);
		callbackCrossSprite?.Invoke(null);
	}

	private static void MistakeCrossSpriteLoaded(Sprite obj)
	{
		s_mistakeCrossSprite = obj;
	}

	public static int GetCurrentColorConfigIndex()
	{
		return s_currentColorConfigIndex;
	}

	public ColourConfig GetCurrentColorConfig()
	{
		if (m_colorConfig != null && s_currentColorConfigIndex >= 0 && s_currentColorConfigIndex < m_colorConfig.Length)
			return m_colorConfig[s_currentColorConfigIndex];
		if (m_colorConfig != null && m_colorConfig.Length > 0)
			return m_colorConfig[0];
		return null;
	}

	public static bool IsSkinUnlocked(string clientId)
	{
		return true; // All unlocked in offline mode
	}

	public static void ChangeQueenSkin(string clientId, bool force = false)
	{
		if (string.IsNullOrEmpty(clientId) && !force) return;
		s_queenSkinClientId = clientId;
		SendQueenSkinChangedEvent();
	}

	public static void ChangeBoardColors(string clientId, bool force = false)
	{
		if (string.IsNullOrEmpty(clientId) && !force) return;
		s_boardColorsClientId = clientId;
		// Try to find color config index
		if (Instance != null && Instance.m_colorConfig != null)
		{
			// Simple mapping: BoardColors_A=0, BoardColors_B=1, etc.
			char letter = 'A';
			if (!string.IsNullOrEmpty(clientId) && clientId.Length > 0)
			{
				char last = clientId[clientId.Length - 1];
				if (last >= 'A' && last <= 'Z')
					letter = last;
			}
			s_currentColorConfigIndex = letter - 'A';
			if (s_currentColorConfigIndex >= Instance.m_colorConfig.Length)
				s_currentColorConfigIndex = 0;
		}
		SendBoardColorsChangedEvent();
	}

	private void UpdateSkinsAndColoursSubscription()
	{
		// Skip - subscription features
	}

	public Color GetCrossColor()
	{
		return s_crossColor != default(Color) ? s_crossColor : m_defaultCrossColor;
	}

	public Sprite GetCrossIcon()
	{
		return s_crossSprite != null ? s_crossSprite : m_defaultCrossIcon;
	}

	public Color GetCrossMistakeColor()
	{
		return s_mistakeCrossColor != default(Color) ? s_mistakeCrossColor : Color.red;
	}

	private void TrialExpired(FeatureTrial trial)
	{
		// Skip - trials
	}

	private void TrialStarted(FeatureTrial trial)
	{
		// Skip - trials
	}

	public Skins GetTrialSkin(FeatureTrial trial)
	{
		return null;
	}

	public Colors GetTrialBoardColor(FeatureTrial trial)
	{
		return null;
	}

	public Sprite GetMistakeCrossIcon()
	{
		return s_mistakeCrossSprite;
	}

	public Texture2D GetVfxTextureForSkin(string clientId)
	{
		if (m_skinsDb != null)
			return m_skinsDb.GetVFXTexture(clientId);
		return null;
	}

	public Texture2D GetVfxTextureForCurrentSkin()
	{
		return GetVfxTextureForSkin(s_queenSkinClientId);
	}

	private void Update()
	{
		// No runtime updates needed
	}
}
