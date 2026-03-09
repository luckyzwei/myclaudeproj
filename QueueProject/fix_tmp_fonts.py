"""
Fix TMP FontAsset files exported by AssetRipper for TMP 4.0 compatibility.
Rewrites each font .asset to use Dynamic atlas population mode with correct .ttf reference.
"""
import re
import os

ASSETS_DIR = os.path.dirname(os.path.abspath(__file__)) + "/Assets"

# Font GUID mapping: .ttf name -> GUID from .meta file
TTF_GUIDS = {
    "nunito-extrabold": "0889dc9d5339d104c885605476a22e90",
    "nunito-semibold": "8d4b48375dd47c249aba8592a2a5d7dc",
    "nunito-bold": "8d4b48375dd47c249aba8592a2a5d7dc",  # fallback to semibold
    "roboto-regular": "72bfc311104cf0943843b2d993491242",
    "roboto-bold": "e07d76e77599618449a1173668133b1a",
    "liberationsans": "41a6d479b72e93043a77af352391f00c",
    "lilitaone-regular": "932d050dcf54b3446a827e1817dd178b",
    "rubik-medium": "06f7f0f0e80c64644ad2ac5a0665bab2",
    "arial": "fd181ad442dffb4489dd4cfee96a9226",
    "notinter-regular": "d63cc22e71add6143baefa598f74226f",
}

# Map of font asset files to their source .ttf
FONT_ASSET_MAP = {
    "Resources/fonts & materials/Nunito-ExtraBold SDF.asset": "nunito-extrabold",
    "Resources/fonts & materials/Nunito-SemiBold SDF.asset": "nunito-semibold",
    "Resources/fonts & materials/LiberationSans SDF.asset": "liberationsans",
    "Resources/fonts & materials/LiberationSans SDF - Fallback.asset": "liberationsans",
    "Resources/Roboto-Regular SDF.asset": "roboto-regular",
    "Resources/Roboto-Bold SDF.asset": "roboto-bold",
    "MonoBehaviour/Roboto-Regular SDF.asset": "roboto-regular",
    "MonoBehaviour/FredokaOne-Regular SDF.asset": "roboto-regular",  # no .ttf, use fallback
    "MonoBehaviour/Korean_Fallback_SDF.asset": "roboto-regular",
    "MonoBehaviour/Multi_Languages_Fallback_SDF.asset": "roboto-regular",
    "MonoBehaviour/NotoSans-Bold SDF.asset": "roboto-regular",
    "MonoBehaviour/ja_NotoSansSC-Regular_SDF.asset": "roboto-regular",
    "MonoBehaviour/ko_NotoSansKR-Regular_SDF.asset": "roboto-regular",
    "MonoBehaviour/ru_NotoSansSC-Regular_SDF.asset": "roboto-regular",
    "MonoBehaviour/zh_Hans_NotoSansSC-Regular_SDF.asset": "roboto-regular",
    "MonoBehaviour/zh_Hant_NotoSansSC-Regular_SDF.asset": "roboto-regular",
    "MonoBehaviour/kapraneue-medium SDF.asset": "roboto-regular",
    "MonoBehaviour/Currencies_Fallback.asset": "roboto-regular",
    "MonoBehaviour/Rubik-Medium SDF outline.asset": "rubik-medium",
    "MonoBehaviour/LilitaOne-Regular SDF-FollowPopup-CoinBank.asset": "lilitaone-regular",
    "MonoBehaviour/LilitaOne-Regular SDF-FollowPopup-Facebook.asset": "lilitaone-regular",
    "MonoBehaviour/LilitaOne-Regular SDF-FollowPopup-FollowUs.asset": "lilitaone-regular",
    "MonoBehaviour/LilitaOne-Regular SDF-FollowPopup-Tiktok.asset": "lilitaone-regular",
}


def fix_font_asset(filepath, ttf_guid):
    """Fix a TMP font asset file by:
    1. Setting m_SourceFontFile to reference the .ttf by GUID
    2. Setting m_AtlasPopulationMode to 1 (Dynamic)
    3. Clearing m_GlyphTable and m_CharacterTable (TMP will regenerate from .ttf)
    4. Updating m_SourceFontFileGUID
    """
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()

    # Check if it's actually a font asset
    if 'm_GlyphTable:' not in content:
        print(f"  SKIP (not a font asset): {filepath}")
        return False

    original = content

    # 1. Fix m_SourceFontFile reference
    # fileID 12800000 is the standard fileID for Font assets in Unity
    content = re.sub(
        r'm_SourceFontFile: \{fileID: 0\}',
        f'm_SourceFontFile: {{fileID: 12800000, guid: {ttf_guid}, type: 3}}',
        content
    )

    # 2. Fix m_SourceFontFileGUID
    content = re.sub(
        r'm_SourceFontFileGUID: [a-f0-9]+',
        f'm_SourceFontFileGUID: {ttf_guid}',
        content
    )

    # Also fix in m_CreationSettings
    content = re.sub(
        r'(sourceFontFileGUID: )[a-f0-9]+',
        f'\\g<1>{ttf_guid}',
        content
    )

    # 3. Set m_AtlasPopulationMode to 1 (Dynamic)
    content = re.sub(
        r'm_AtlasPopulationMode: 0',
        'm_AtlasPopulationMode: 1',
        content
    )

    # 4. Clear m_GlyphTable (replace the array with empty)
    content = re.sub(
        r'(  m_GlyphTable:\n)(  - .*\n)*',
        '  m_GlyphTable: []\n',
        content
    )

    # Clear multiline glyph entries (they span multiple lines)
    # Match from "  m_GlyphTable:" to the next top-level field
    content = re.sub(
        r'  m_GlyphTable:\n(    .*\n)*',
        '  m_GlyphTable: []\n',
        content
    )

    # 5. Clear m_CharacterTable
    content = re.sub(
        r'  m_CharacterTable:\n(  - .*\n)*',
        '  m_CharacterTable: []\n',
        content
    )

    # 6. Clear m_UsedGlyphRects
    content = re.sub(
        r'  m_UsedGlyphRects:\n(  - .*\n)*',
        '  m_UsedGlyphRects: []\n',
        content
    )

    # 7. Clear m_FreeGlyphRects
    content = re.sub(
        r'  m_FreeGlyphRects:\n(  - .*\n)*',
        '  m_FreeGlyphRects: []\n',
        content
    )

    # 8. Clear kerning/feature tables
    content = re.sub(
        r'(    m_GlyphPairAdjustmentRecords:\n)(    - .*\n)*',
        '    m_GlyphPairAdjustmentRecords: []\n',
        content
    )

    if content != original:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(content)
        return True
    return False


def main():
    fixed = 0
    for rel_path, ttf_key in FONT_ASSET_MAP.items():
        filepath = os.path.join(ASSETS_DIR, rel_path)
        if not os.path.exists(filepath):
            print(f"  NOT FOUND: {rel_path}")
            continue

        ttf_guid = TTF_GUIDS.get(ttf_key)
        if not ttf_guid:
            print(f"  NO GUID for: {ttf_key}")
            continue

        if fix_font_asset(filepath, ttf_guid):
            print(f"  FIXED: {rel_path} -> {ttf_key} ({ttf_guid})")
            fixed += 1
        else:
            print(f"  UNCHANGED: {rel_path}")

    print(f"\nDone! Fixed {fixed} font assets.")
    print("Restart Unity to apply changes.")


if __name__ == "__main__":
    main()
