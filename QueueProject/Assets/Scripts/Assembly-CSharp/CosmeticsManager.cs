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

	public static GameplayEvents.BasicDelegate QueenSkinChanged;

	public static GameplayEvents.BasicDelegate BoardColorsChanged;

	public static string QueenSkinClientID => null;

	public static string BoardColorsClientID => null;

	public static bool IsUsingDefaultCross => false;

	protected override void Init()
	{
	}

	private void Start()
	{
	}

	private void EverythingLoaded()
	{
	}

	private void UpdateProfile()
	{
	}

	private static void ChangeVfx()
	{
	}

	public static void SendQueenSkinChangedEvent()
	{
	}

	public static void SendBoardColorsChangedEvent()
	{
	}

	public static List<QueenSkinIcons> GetAllSkins()
	{
		return null;
	}

	public static List<BoardColorsIcon> GetAllBoardColorsIcons(bool sort = true)
	{
		return null;
	}

	public ColourConfig GetColorConfigByClientId(string clientId)
	{
		return null;
	}

	public static void GetCurrentBackground(Action<Sprite> callbackBackground)
	{
	}

	public static QueenSkinIcons GetCurrentSkin()
	{
		return null;
	}

	public static void ApplyCurrentSkin(Action<Sprite> callbackFlourishSprite, Action<Sprite> callbackBaseSprite, Action callbackCross = null)
	{
	}

	public static void LoadSkinSpritesById(string skinClientId, Action<Sprite> callbackFlourishSprite, Action<Sprite> callbackBaseSprite, Action<Sprite> callbackCrossSprite)
	{
	}

	private static void MistakeCrossSpriteLoaded(Sprite obj)
	{
	}

	public static int GetCurrentColorConfigIndex()
	{
		return 0;
	}

	public ColourConfig GetCurrentColorConfig()
	{
		return null;
	}

	public static bool IsSkinUnlocked(string clientId)
	{
		return false;
	}

	public static void ChangeQueenSkin(string clientId, bool force = false)
	{
	}

	public static void ChangeBoardColors(string clientId, bool force = false)
	{
	}

	private void UpdateSkinsAndColoursSubscription()
	{
	}

	public Color GetCrossColor()
	{
		return default(Color);
	}

	public Sprite GetCrossIcon()
	{
		return null;
	}

	public Color GetCrossMistakeColor()
	{
		return default(Color);
	}

	private void TrialExpired(FeatureTrial trial)
	{
	}

	private void TrialStarted(FeatureTrial trial)
	{
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
		return null;
	}

	public Texture2D GetVfxTextureForSkin(string clientId)
	{
		return null;
	}

	public Texture2D GetVfxTextureForCurrentSkin()
	{
		return null;
	}

	private void Update()
	{
	}
}
