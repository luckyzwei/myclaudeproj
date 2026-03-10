using UnityEngine;
using UnityEditor;

/// <summary>
/// TMPFontFixer - DISABLED.
///
/// Previous versions of this script destroyed all TMP font assets by:
/// 1. Switching m_AtlasPopulationMode from 0 (Static) to 1 (Dynamic)
/// 2. Calling SerializedObject.ApplyModifiedProperties(), which caused Unity's
///    TMP 4.0 serialization to re-serialize the YAML and prepend "[]" to
///    m_GlyphTable and m_CharacterTable keys, making YAML ignore all entries below.
/// 3. For CJK fonts, this wiped 10,000-47,000 lines of pre-baked glyph data.
///
/// The fonts have been restored from the original commit with:
/// - m_AtlasPopulationMode: 0 (Static) - uses pre-baked atlas data
/// - m_GlyphTable/m_CharacterTable: intact with all glyph entries
/// - m_Script GUID updated for Unity 6 TMP source package
///
/// CJK fallback for characters not in pre-baked atlas is handled at runtime
/// by CJKFontInitializer.cs (adds system CJK font as TMP fallback).
///
/// DO NOT re-enable this script without understanding the above.
/// </summary>
public static class TMPFontFixer
{
    [MenuItem("Tools/TMP Font Fixer/Fix All Font Assets")]
    static void RunFixMenu()
    {
        Debug.LogWarning("[TMPFontFixer] DISABLED. Font assets use pre-baked Static atlas data. " +
            "CJK fallback is handled by CJKFontInitializer at runtime. " +
            "Re-enabling this script will destroy all glyph data.");
    }
}
