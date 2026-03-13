"""Shorten hint texts in zh-CN localization file."""
import re

LOC_FILE = 'I:/client/myclaudeproj/QueueProject/Assets/Resources/configs/localisation/Localisation_zh_CN.txt'

# Map: key -> new shorter Chinese text
REPLACEMENTS = {
    # === CellRuleOut (排除格子：此格挡住某颜色) ===
    "CellRuleOut": "此格挡住所有{0}格，可排除。",
    "CellRuleOut_OtherColours": "此格挡住该颜色所有格，可排除。",
    "CellRuleOut_Plural": "这些格挡住所有{0}格，可排除。",
    "CellRuleOut_Plural_OtherColours": "这些格挡住该颜色所有格，可排除。",
    "CellRuleOut_DiffColor_DoubleQueen": "此格阻止{0}包含两位皇后。",
    "CellRuleOut_DoubleQueen": "此格挡住所有{0}格，{0}无法放两位皇后。",
    "CellRuleOut_OtherColours_DiffColor_DoubleQueen": "此格阻止该颜色包含两位皇后。",
    "CellRuleOut_OtherColours_DoubleQueen": "此格挡住该颜色所有格，无法放两位皇后。",
    "CellRuleOut_Plural_DiffColor_DoubleQueen": "这些格阻止{0}包含两位皇后。",
    "CellRuleOut_Plural_DoubleQueen": "这些格挡住所有{0}格，{0}无法放两位皇后。",
    "CellRuleOut_Plural_OtherColours_DiffColor_DoubleQueen": "这些格阻止该颜色包含两位皇后。",
    "CellRuleOut_Plural_OtherColours_DoubleQueen": "这些格挡住该颜色所有格，无法放两位皇后。",

    # === ColourCheck (已有皇后的颜色) ===
    "ColourCheck": "{0}已有皇后，排除这些格。",
    "ColourCheck_OtherColours": "此颜色已有皇后，排除这些格。",
    "ColourCheck_DoubleQueen": "{0}已有两位皇后，排除这些格。",
    "ColourCheck_OtherColours_DoubleQueen": "此颜色已有两位皇后，排除这些格。",

    # === ForcedQueen (唯一可用格) ===
    "ForcedQueen": "此[ROWCOL]仅剩此格，必须放皇后。",
    "ForcedQueen_1Cell_DoubleQueen": "此[行/列]需两位皇后，仅剩此格。",
    "ForcedQueen_ManyCells_DoubleQueen": "此[行/列]需两位皇后，仅剩这些格。",

    # === ForcedRuleOut (行/列中皇后必为某色) ===
    "ForcedRuleOut": "此[ROWCOL]皇后必为{0}，排除其余{0}格。",
    "ForcedRuleOut_OtherColours": "此[ROWCOL]皇后必为此颜色，排除同色格。",
    "ForcedRuleOut_DoubleQueen": "此[行/列]两位皇后必为{0}，排除其他{0}格。",
    "ForcedRuleOut_OtherColours_DoubleQueen": "此[行/列]两位皇后必为此颜色，排除同色格。",

    # === NakedSingle (最后一格) ===
    "NakedSingle": "{0}仅剩此格，放皇后！",
    "NakedSingle_OnlyCell": "{0}唯一方格，放皇后！",
    "NakedSingle_OtherColours": "该颜色仅剩此格，放皇后！",
    "NakedSingle_OtherColours_OnlyCell": "该颜色唯一方格，放皇后！",
    "NakedSingle_1Queen_DoubleQueen": "{0}唯一方格，必须是皇后。",
    "NakedSingle_1Queen_OtherColours_DoubleQueen": "此颜色唯一方格，必须是皇后。",
    "NakedSingle_DoubleQueen": "{0}仅剩这些格，必须放皇后。",
    "NakedSingle_OtherColours_DoubleQueen": "此颜色仅剩这些格，必须放皇后。",

    # === PointingPairs ===
    "PointingPairs": "{0}皇后必在这些格中，排除此[ROWCOL]其余格。",
    "PointingPairs_OtherColours": "此色皇后必在这些格中，排除此[ROWCOL]其余格。",
    "PointingPairs_DoubleQueen": "{0}和{1}皇后必在这些格中，此[ROWCOL]不能再有皇后。",
    "PointingPairs_OtherColours_DoubleQueen": "这些颜色皇后必在此处，此[ROWCOL]不能再有皇后。",

    "DoublePointingPairs": "这两[ROWCOL]须放{0}和{1}皇后，排除其余格。",
    "DoublePointingPairs_OtherColours": "这两[ROWCOL]须放这两色皇后，排除其余格。",
    "DoublePointingPairs_DoubleQueen": "{0}和{1}仅在这2[行列]中，排除其他格。",
    "DoublePointingPairs_OtherColours_DoubleQueen": "这两色仅在这2[行列]中，排除其他格。",

    "TriplePointingPairs": "这三[ROWCOL]须放{0}、{1}和{2}皇后，排除其余格。",
    "TriplePointingPairs_OtherColours": "这三[ROWCOL]须放这三色皇后，排除其余格。",
    "TriplePointingPairs_DoubleQueen": "{0}、{1}和{2}仅在这3[行列]中，排除其他格。",
    "TriplePointingPairs_OtherColours_DoubleQueen": "这三色仅在这3[行列]中，排除其他格。",

    "QuadruplePointingPairs": "这四[ROWCOL]须放{0}、{1}、{2}和{3}皇后，排除其余格。",
    "QuadruplePointingPairs_OtherColours": "这四[ROWCOL]须放这四色皇后，排除其余格。",
    "QuadruplePointingPairs_DoubleQueen": "{0}、{1}、{2}和{3}仅在这4[行列]中，排除其他格。",
    "QuadruplePointingPairs_OtherColours_DoubleQueen": "这四色仅在这4[行列]中，排除其他格。",

    "PentaPointingPairs": "这五[ROWCOL]须放{0}、{1}、{2}、{3}和{4}皇后，排除其余格。",
    "PentaPointingPairs_OtherColours": "这五[ROWCOL]须放这五色皇后，排除其余格。",
    "PentaPointingPairs_DoubleQueen": "{0}、{1}、{2}、{3}和{4}仅在这5[行列]中，排除其他格。",
    "PentaPointingPairs_OtherColours_DoubleQueen": "这五色仅在这5[行列]中，排除其他格。",

    # === ReversePointingPairs ===
    "ReversePointingPair": "这两[ROWCOL]仅含{0}和{1}，须放皇后，排除外部格。",
    "ReversePointingPair_OtherColours": "这两[ROWCOL]仅含两种颜色，须放皇后，排除外部格。",
    "ReversePointingPair_DoubleQueen": "{0}和{1}仅在这2[行列]中，排除外部同色格。",
    "ReversePointingPair_OtherColours_DoubleQueen": "这两色仅在这2[行列]中，排除外部同色格。",

    "ReverseTriplePointingPair": "这三[ROWCOL]仅含{0}、{1}和{2}，须放皇后，排除外部格。",
    "ReverseTriplePointingPair_OtherColours": "这三[ROWCOL]仅含三种颜色，须放皇后，排除外部格。",
    "ReverseTriplePointingPair_DoubleQueen": "{0}、{1}和{2}仅在这3[行列]中，排除外部同色格。",
    "ReverseTriplePointingPair_OtherColours_DoubleQueen": "这三色仅在这3[行列]中，排除外部同色格。",

    "ReverseQuadPointingPair": "这四[ROWCOL]仅含{0}、{1}、{2}和{3}，须放皇后，排除外部格。",
    "ReverseQuadPointingPair_OtherColours": "这四[ROWCOL]仅含四种颜色，须放皇后，排除外部格。",
    "ReverseQuadPointingPair_DoubleQueen": "{0}、{1}、{2}和{3}仅在这4[行列]中，排除外部同色格。",
    "ReverseQuadPointingPair_OtherColours_DoubleQueen": "这四色仅在这4[行列]中，排除外部同色格。",

    "ReversePentaPointingPair": "这五[ROWCOL]仅含{0}、{1}、{2}、{3}和{4}，须放皇后，排除外部格。",
    "ReversePentaPointingPair_OtherColours": "这五[ROWCOL]仅含五种颜色，须放皇后，排除外部格。",
    "ReversePentaPointingPair_DoubleQueens": "{0}、{1}、{2}、{3}和{4}仅在这5[行列]中，排除外部同色格。",
    "ReversePentaPointingPair_OtherColours_DoubleQueens": "这五色仅在这5[行列]中，排除外部同色格。",

    # === RowColumn ===
    "RowColumnCheck": "排除皇后所在行和列的所有格。",
    "RowColumnCheck_DoubleQueen": "排除已有两位皇后的行和列。",
    "RowColumnRuleOut": "此格挡住该[ROWCOL]全部格，排除。",
    "RowColumnRuleOut_Plural": "这些格挡住该[ROWCOL]全部格，排除。",
    "RowColumnRuleOut_DoubleQueen": "在此放皇后会阻止该[行/列]有两位皇后。",
    "RowColumnRuleOut_Plural_DoubleQueen": "在这些格放皇后会阻止该[行/列]有两位皇后。",

    # === Other ===
    "ProximityCheck": "排除所有与皇后相邻的格。",
    "Fallback": "可排除这些格。",
    "Mistake": "此格不应排除，应放皇后。",
    "RemoteCell_DoubleQueen": "此颜色须两位皇后且不能相邻，此格必为皇后。",
    "RemoteCell_OtherColours_DoubleQueen": "此颜色须两位皇后且不能相邻，此格必为皇后。",
}


def chinese_to_unicode_escape(text):
    """Convert Chinese text to \\uXXXX escape sequences."""
    result = []
    for ch in text:
        if ord(ch) > 127:
            result.append(f'\\u{ord(ch):04x}')
        else:
            result.append(ch)
    return ''.join(result)


def main():
    with open(LOC_FILE, 'r', encoding='utf-8') as f:
        content = f.read()

    count = 0
    for key, new_text in REPLACEMENTS.items():
        new_escaped = chinese_to_unicode_escape(new_text)
        # Match "key": "old_value"
        pattern = re.compile(r'("' + re.escape(key) + r'")\s*:\s*"((?:[^"\\]|\\.)*)"')
        m = pattern.search(content)
        if m:
            old_full = m.group(0)
            new_full = f'"{key}": "{new_escaped}"'
            if old_full != new_full:
                content = content.replace(old_full, new_full, 1)
                old_val = m.group(2).encode('utf-8').decode('unicode_escape')
                print(f'{key}:')
                print(f'  旧 ({len(old_val)}字): {old_val}')
                print(f'  新 ({len(new_text)}字): {new_text}')
                print()
                count += 1
        else:
            print(f'WARNING: Key not found: {key}')

    with open(LOC_FILE, 'w', encoding='utf-8') as f:
        f.write(content)

    print(f'\n=== 修改了 {count} 条提示文本 ===')


if __name__ == '__main__':
    main()
