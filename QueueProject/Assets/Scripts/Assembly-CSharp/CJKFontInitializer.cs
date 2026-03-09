using TMPro;
using UnityEngine;

/// <summary>
/// Creates a dynamic TMP font from system CJK fonts at runtime
/// and adds it as a global fallback for TextMeshPro.
/// </summary>
public static class CJKFontInitializer
{
	private static bool s_initialized;

	public static void Init()
	{
		if (s_initialized) return;
		s_initialized = true;

		// Try to find a CJK-capable system font
		string[] cjkFontNames = new string[]
		{
			"Microsoft YaHei",    // Windows Chinese
			"SimHei",             // Windows Chinese
			"PingFang SC",        // macOS Chinese
			"Hiragino Sans GB",   // macOS Chinese
			"Noto Sans CJK SC",  // Linux/Android Chinese
			"Droid Sans Fallback",// Android
			"Source Han Sans SC", // Adobe CJK
			"WenQuanYi Micro Hei",// Linux
			"Arial Unicode MS",  // Windows universal
		};

		Font cjkFont = null;
		foreach (string fontName in cjkFontNames)
		{
			cjkFont = Font.CreateDynamicFontFromOSFont(fontName, 36);
			if (cjkFont != null)
			{
				// Verify it actually has CJK characters
				cjkFont.RequestCharactersInTexture("\u4e2d", 36);
				CharacterInfo ci;
				if (cjkFont.GetCharacterInfo('\u4e2d', out ci, 36))
				{
					Debug.Log($"[CJKFont] Using system font: {fontName}");
					break;
				}
				cjkFont = null;
			}
		}

		if (cjkFont == null)
		{
			Debug.LogWarning("[CJKFont] No CJK system font found. Chinese text may not display.");
			return;
		}

		// Create dynamic TMP font asset from system font
		TMP_FontAsset tmpFont = TMP_FontAsset.CreateFontAsset(cjkFont);
		if (tmpFont == null)
		{
			Debug.LogWarning("[CJKFont] Failed to create TMP_FontAsset.");
			return;
		}

		tmpFont.name = "CJK-Fallback-Dynamic";

		// Add as fallback to the default TMP font
		TMP_FontAsset defaultFont = TMP_Settings.defaultFontAsset;
		if (defaultFont != null)
		{
			if (defaultFont.fallbackFontAssetTable == null)
				defaultFont.fallbackFontAssetTable = new System.Collections.Generic.List<TMP_FontAsset>();
			defaultFont.fallbackFontAssetTable.Add(tmpFont);
			Debug.Log($"[CJKFont] Added CJK fallback to default font ({defaultFont.name}).");
		}

		// Also try to add to any Nunito fonts loaded in Resources
		var allFonts = Resources.FindObjectsOfTypeAll<TMP_FontAsset>();
		foreach (var font in allFonts)
		{
			if (font == tmpFont) continue;
			if (font.fallbackFontAssetTable == null)
				font.fallbackFontAssetTable = new System.Collections.Generic.List<TMP_FontAsset>();
			if (!font.fallbackFontAssetTable.Contains(tmpFont))
				font.fallbackFontAssetTable.Add(tmpFont);
		}
		Debug.Log($"[CJKFont] Added CJK fallback to {allFonts.Length} font assets.");
	}
}
