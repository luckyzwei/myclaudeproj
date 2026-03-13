import re

path = 'I:/client/myclaudeproj/QueueProject/Assets/Resources/configs/localisation/Localisation_zh_CN.txt'
with open(path, 'r', encoding='utf-8') as f:
    content = f.read()

pattern = re.compile(r'"([^"]+)"\s*:\s*"((?:[^"\\]|\\.)*)"')
hints = {}
for m in pattern.finditer(content):
    key = m.group(1)
    raw_val = m.group(2)
    if not any(x in key for x in ['Hint', 'hint', 'Check', 'RuleOut', 'Queen', 'Proximity', 'Mistake', 'Fallback', 'Naked', 'Pointing', 'Forced']):
        continue
    try:
        val = raw_val.encode('utf-8').decode('unicode_escape')
    except:
        val = raw_val
    hints[key] = val

out = 'I:/client/myclaudeproj/QueueProject/hint_texts.txt'
with open(out, 'w', encoding='utf-8') as f:
    for key in sorted(hints.keys()):
        val = hints[key]
        f.write(f'{key} ({len(val)}字):\n')
        f.write(f'  {val}\n\n')
print(f'Written {len(hints)} entries to {out}')
