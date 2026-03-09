using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

/// <summary>
/// Fixes TMP FontAssets exported by AssetRipper that are incompatible with TMP 4.0.
/// Links source .ttf fonts and switches to Dynamic atlas population mode.
/// Run automatically on domain reload, or manually via Tools menu.
/// </summary>
[InitializeOnLoad]
public static class TMPFontFixer
{
    private const string FixedKey = "TMPFontFixer_Done_v3";

    static TMPFontFixer()
    {
        if (SessionState.GetBool(FixedKey, false))
            return;
        EditorApplication.delayCall += RunFix;
    }

    [MenuItem("Tools/TMP Font Fixer/Fix All Font Assets")]
    static void RunFixMenu()
    {
        SessionState.SetBool(FixedKey, false);
        RunFix();
    }

    static void RunFix()
    {
        SessionState.SetBool(FixedKey, true);
        Debug.Log("[TMPFontFixer] Scanning for broken TMP font assets...");

        // Build a map of font name -> .ttf Font asset
        var fontMap = new Dictionary<string, Font>();
        string[] ttfGuids = AssetDatabase.FindAssets("t:Font");
        foreach (string guid in ttfGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (!path.EndsWith(".ttf") && !path.EndsWith(".otf")) continue;
            Font font = AssetDatabase.LoadAssetAtPath<Font>(path);
            if (font != null)
            {
                string key = font.name.ToLowerInvariant();
                if (!fontMap.ContainsKey(key))
                    fontMap[key] = font;
            }
        }

        // Fallback font
        Font fallbackFont = null;
        if (fontMap.TryGetValue("roboto-regular", out var rf)) fallbackFont = rf;
        else if (fontMap.TryGetValue("liberationsans", out var lf)) fallbackFont = lf;
        else if (fontMap.Count > 0)
        {
            foreach (var kv in fontMap) { fallbackFont = kv.Value; break; }
        }

        Debug.Log($"[TMPFontFixer] Found {fontMap.Count} .ttf fonts, fallback={fallbackFont?.name ?? "null"}");

        // Find all TMP_FontAsset files
        // TMP_FontAsset script GUIDs (try both old and new)
        string[] fontAssetGuids = AssetDatabase.FindAssets("t:TMP_FontAsset");

        // If the above doesn't work, search by file extension
        if (fontAssetGuids.Length == 0)
        {
            var assetPaths = new List<string>();
            foreach (string dir in new[] { "Assets/Resources", "Assets/MonoBehaviour" })
            {
                if (!Directory.Exists(dir)) continue;
                foreach (string f in Directory.GetFiles(dir, "*SDF*.asset", SearchOption.AllDirectories))
                    assetPaths.Add(f.Replace('\\', '/'));
            }
            fontAssetGuids = new string[assetPaths.Count];
            for (int i = 0; i < assetPaths.Count; i++)
                fontAssetGuids[i] = AssetDatabase.AssetPathToGUID(assetPaths[i]);
        }

        int fixedCount = 0;

        foreach (string guid in fontAssetGuids)
        {
            if (string.IsNullOrEmpty(guid)) continue;
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            if (string.IsNullOrEmpty(assetPath) || !assetPath.EndsWith(".asset")) continue;

            Object asset = AssetDatabase.LoadMainAssetAtPath(assetPath);
            if (asset == null) continue;

            var so = new SerializedObject(asset);

            // Check if this is a TMP font asset by looking for TMP-specific properties
            var glyphTableProp = so.FindProperty("m_GlyphTable");
            if (glyphTableProp == null) continue; // Not a TMP font asset

            var srcFontProp = so.FindProperty("m_SourceFontFile");
            var popModeProp = so.FindProperty("m_AtlasPopulationMode");

            if (srcFontProp == null || popModeProp == null) continue;

            // Check if source font is already linked
            if (srcFontProp.objectReferenceValue != null)
                continue; // Already has a valid source font

            // Try to match by name
            string assetName = Path.GetFileNameWithoutExtension(assetPath);
            // Remove " SDF", " SDF - Fallback", etc.
            string fontName = assetName
                .Replace(" SDF - Fallback", "")
                .Replace(" SDF", "")
                .Replace("_SDF", "")
                .Trim();

            Font matchedFont = null;
            string lowerName = fontName.ToLowerInvariant();

            // Try exact match
            if (fontMap.TryGetValue(lowerName, out var exact))
                matchedFont = exact;

            // Try with underscores replaced
            if (matchedFont == null)
            {
                string altName = lowerName.Replace("_", "-");
                if (fontMap.TryGetValue(altName, out var alt))
                    matchedFont = alt;
            }

            // Try partial match
            if (matchedFont == null)
            {
                foreach (var kv in fontMap)
                {
                    if (kv.Key.Contains(lowerName) || lowerName.Contains(kv.Key))
                    {
                        matchedFont = kv.Value;
                        break;
                    }
                }
            }

            // Use fallback
            if (matchedFont == null)
                matchedFont = fallbackFont;

            if (matchedFont == null)
            {
                Debug.LogWarning($"[TMPFontFixer] No font found for: {assetPath}");
                continue;
            }

            // Fix the font asset
            srcFontProp.objectReferenceValue = matchedFont;
            popModeProp.intValue = 1; // Dynamic

            // Clear glyph and character tables to force regeneration
            var charTableProp = so.FindProperty("m_CharacterTable");
            if (charTableProp != null)
                charTableProp.ClearArray();
            glyphTableProp.ClearArray();

            // Clear used glyph rects
            var usedRectsProp = so.FindProperty("m_UsedGlyphRects");
            if (usedRectsProp != null)
                usedRectsProp.ClearArray();
            var freeRectsProp = so.FindProperty("m_FreeGlyphRects");
            if (freeRectsProp != null)
                freeRectsProp.ClearArray();

            // Clear font features (kern table, etc.)
            var fontFeatureProp = so.FindProperty("m_FontFeatureTable");
            if (fontFeatureProp != null)
            {
                var kernProp = fontFeatureProp.FindPropertyRelative("m_GlyphPairAdjustmentRecords");
                if (kernProp != null)
                    kernProp.ClearArray();
                var markToBaseProp = fontFeatureProp.FindPropertyRelative("m_MarkToBaseAdjustmentRecords");
                if (markToBaseProp != null)
                    markToBaseProp.ClearArray();
                var markToMarkProp = fontFeatureProp.FindPropertyRelative("m_MarkToMarkAdjustmentRecords");
                if (markToMarkProp != null)
                    markToMarkProp.ClearArray();
            }

            so.ApplyModifiedPropertiesWithoutUndo();
            EditorUtility.SetDirty(asset);

            Debug.Log($"[TMPFontFixer] Fixed: {assetPath} -> {matchedFont.name} (Dynamic mode)");
            fixedCount++;
        }

        if (fixedCount > 0)
        {
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        Debug.Log($"[TMPFontFixer] Complete. Fixed {fixedCount} font assets.");
    }
}
