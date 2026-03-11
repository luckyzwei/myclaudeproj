using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Creates a dynamic Font from system CJK fonts (Microsoft YaHei preferred)
/// and assigns it to all Text components that lack CJK support.
/// </summary>
public static class CJKFontInitializer
{
	private static bool s_initialized;
	private static Font s_cjkFont;

	public static Font CJKFont => s_cjkFont;

	public static void Init()
	{
		if (s_initialized) return;
		s_initialized = true;

		string[] cjkFontNames = new string[]
		{
			"Microsoft YaHei",    // Windows Chinese (preferred)
			"SimHei",             // Windows Chinese
			"PingFang SC",        // macOS Chinese
			"Hiragino Sans GB",   // macOS Chinese
			"Noto Sans CJK SC",   // Linux/Android Chinese
			"Droid Sans Fallback",// Android
			"Source Han Sans SC", // Adobe CJK
			"WenQuanYi Micro Hei",// Linux
			"Arial Unicode MS",  // Windows universal
		};

		foreach (string fontName in cjkFontNames)
		{
			Font font = Font.CreateDynamicFontFromOSFont(fontName, 36);
			if (font != null)
			{
				font.RequestCharactersInTexture("\u4e2d", 36);
				CharacterInfo ci;
				if (font.GetCharacterInfo('\u4e2d', out ci, 36))
				{
					s_cjkFont = font;
					Debug.Log($"[CJKFont] Using system font: {fontName}");
					break;
				}
			}
		}

		if (s_cjkFont == null)
		{
			Debug.LogWarning("[CJKFont] No CJK system font found. Chinese text may not display.");
			return;
		}

		// Apply to all existing Text components in the scene
		ApplyToAllText();
	}

	public static void ApplyToAllText()
	{
		if (s_cjkFont == null) return;
		var allText = Resources.FindObjectsOfTypeAll<Text>();
		int count = 0;
		foreach (var t in allText)
		{
			t.font = s_cjkFont;
			count++;
		}
		Debug.Log($"[CJKFont] Applied Microsoft YaHei to {count} Text components.");
	}
}
