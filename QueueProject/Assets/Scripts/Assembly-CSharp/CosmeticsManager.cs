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

	[SerializeField] private ColourConfig[] m_colorConfig;
	[SerializeField] private Sprite m_defaultCrossIcon;
	[SerializeField] private Color m_defaultCrossColor;
	[SerializeField] private SkinsDb m_skinsDb;
	[SerializeField] private Material m_shapesVfxMaterial;

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

	private void Start() { m_everythingLoaded = true; }

	// ─── 皮肤列表（直接从 Resources/SkinIcons/ 加载） ───

	private static readonly string[] s_skinIds = {
		"Skin_A", "Skin_B", "Skin_C", "Skin_D", "Skin_E", "Skin_F",
		"Skin_G", "Skin_H", "Skin_I", "Skin_J", "Skin_K", "Skin_L",
		"Skin_M", "Skin_N", "Skin_O", "Skin_P", "Skin_Q", "Skin_R",
		"Skin_S", "Skin_T", "Skin_U", "Skin_V", "Skin_W", "Skin_X",
		"Skin_Y", "Skin_Z", "Skin_AA", "Skin_AB",
		"Skin_Carnival", "Skin_CarnivalToucan", "Skin_AC", "Skin_AD",
	};

	private static readonly string[] s_boardColorIds = {
		"BoardColors_A", "BoardColors_B", "BoardColors_C", "BoardColors_D",
		"BoardColors_E", "BoardColors_F", "BoardColors_G", "BoardColors_H",
		"BoardColors_I", "BoardColors_J", "BoardColors_K",
		"BoardColors_Carnival", "BoardColors_Easter",
	};

	private static List<QueenSkinIcons> s_cachedSkins;
	private static List<BoardColorsIcon> s_cachedBoardColors;

	private static Sprite LoadIcon(string name)
	{
		var tex = Resources.Load<Texture2D>("SkinIcons/" + name);
		if (tex == null) return null;
		return Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100f);
	}

	public static List<QueenSkinIcons> GetAllSkins()
	{
		if (s_cachedSkins != null) return s_cachedSkins;
		s_cachedSkins = new List<QueenSkinIcons>();
		for (int i = 0; i < s_skinIds.Length; i++)
		{
			var id = s_skinIds[i];
			s_cachedSkins.Add(new QueenSkinIcons
			{
				ClientId = id,
				IconSprite = LoadIcon(id),
				FlourishSprite = LoadIcon(id + "_flourish"),
			});
		}
		Debug.Log($"[CosmeticsManager] Loaded {s_cachedSkins.Count} skins");
		return s_cachedSkins;
	}

	public static List<BoardColorsIcon> GetAllBoardColorsIcons(bool sort = true)
	{
		if (s_cachedBoardColors != null) return s_cachedBoardColors;
		s_cachedBoardColors = new List<BoardColorsIcon>();
		for (int i = 0; i < s_boardColorIds.Length; i++)
		{
			var id = s_boardColorIds[i];
			s_cachedBoardColors.Add(new BoardColorsIcon
			{
				ClientId = id,
				IconSprite = LoadIcon(id),
			});
		}
		Debug.Log($"[CosmeticsManager] Loaded {s_cachedBoardColors.Count} board colors");
		return s_cachedBoardColors;
	}

	// ─── 当前皮肤 ───

	public static QueenSkinIcons GetCurrentSkin()
	{
		var skins = GetAllSkins();
		for (int i = 0; i < skins.Count; i++)
			if (skins[i].ClientId == s_queenSkinClientId) return skins[i];
		return null;
	}

	public static void ApplyCurrentSkin(Action<Sprite> callbackFlourish, Action<Sprite> callbackBase, Action callbackCross = null)
	{
		var skin = GetCurrentSkin();
		if (skin?.FlourishSprite != null)
		{
			callbackFlourish?.Invoke(skin.FlourishSprite);
			callbackBase?.Invoke(skin.IconSprite);
		}
		else
		{
			var sprite = Resources.Load<Sprite>("sprites/Tile-Queen-Crown");
			callbackFlourish?.Invoke(sprite);
			callbackBase?.Invoke(sprite);
		}
		callbackCross?.Invoke();
	}

	public static void LoadSkinSpritesById(string skinClientId, Action<Sprite> callbackFlourish, Action<Sprite> callbackBase, Action<Sprite> callbackCross)
	{
		var skins = GetAllSkins();
		QueenSkinIcons found = null;
		for (int i = 0; i < skins.Count; i++)
			if (skins[i].ClientId == skinClientId) { found = skins[i]; break; }

		if (found?.FlourishSprite != null)
		{
			callbackFlourish?.Invoke(found.FlourishSprite);
			callbackBase?.Invoke(found.IconSprite);
		}
		else
		{
			var sprite = Resources.Load<Sprite>("sprites/Tile-Queen-Crown");
			callbackFlourish?.Invoke(sprite);
			callbackBase?.Invoke(sprite);
		}
		callbackCross?.Invoke(null);
	}

	// ─── 颜色配置 ───

	public ColourConfig GetColorConfigByClientId(string clientId)
	{
		if (m_colorConfig == null) return null;
		for (int i = 0; i < m_colorConfig.Length; i++)
			if (m_colorConfig[i] != null) return m_colorConfig[i];
		return null;
	}

	public static int GetCurrentColorConfigIndex() => s_currentColorConfigIndex;

	public ColourConfig GetCurrentColorConfig()
	{
		if (m_colorConfig != null && s_currentColorConfigIndex >= 0 && s_currentColorConfigIndex < m_colorConfig.Length)
			return m_colorConfig[s_currentColorConfigIndex];
		if (m_colorConfig != null && m_colorConfig.Length > 0)
			return m_colorConfig[0];
		return null;
	}

	// ─── 切换皮肤/颜色 ───

	public static bool IsSkinUnlocked(string clientId) => true;

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
		if (Instance != null && Instance.m_colorConfig != null)
		{
			char letter = 'A';
			if (!string.IsNullOrEmpty(clientId) && clientId.Length > 0)
			{
				char last = clientId[clientId.Length - 1];
				if (last >= 'A' && last <= 'Z') letter = last;
			}
			s_currentColorConfigIndex = letter - 'A';
			if (s_currentColorConfigIndex >= Instance.m_colorConfig.Length)
				s_currentColorConfigIndex = 0;
		}
		SendBoardColorsChangedEvent();
	}

	// ─── 事件/工具方法 ───

	public static void SendQueenSkinChangedEvent() { QueenSkinChanged?.Invoke(); }
	public static void SendBoardColorsChangedEvent() { BoardColorsChanged?.Invoke(); }
	public static void GetCurrentBackground(Action<Sprite> cb) { cb?.Invoke(null); }

	public Color GetCrossColor() => s_crossColor != default ? s_crossColor : m_defaultCrossColor;
	public Sprite GetCrossIcon() => s_crossSprite != null ? s_crossSprite : m_defaultCrossIcon;
	public Color GetCrossMistakeColor() => s_mistakeCrossColor != default ? s_mistakeCrossColor : Color.red;
	public Sprite GetMistakeCrossIcon() => s_mistakeCrossSprite;

	public Texture2D GetVfxTextureForSkin(string clientId) => m_skinsDb != null ? m_skinsDb.GetVFXTexture(clientId) : null;
	public Texture2D GetVfxTextureForCurrentSkin() => GetVfxTextureForSkin(s_queenSkinClientId);

	private void UpdateProfile() { }
	private static void ChangeVfx() { }
	private static void MistakeCrossSpriteLoaded(Sprite obj) { s_mistakeCrossSprite = obj; }
	private void UpdateSkinsAndColoursSubscription() { }
	private void TrialExpired(FeatureTrial trial) { }
	private void TrialStarted(FeatureTrial trial) { }
	public Skins GetTrialSkin(FeatureTrial trial) => null;
	public Colors GetTrialBoardColor(FeatureTrial trial) => null;
	private void Update() { }
}
