using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/LevelData")]
public class LevelDataScriptable : ScriptableObject
{
	public LevelData data;

	[ContextMenu("Fix Colors")]
	public bool FixColors()
	{
		return false;
	}

	[ContextMenu("Grab Used Colours")]
	public void GrabUsedColours()
	{
	}
}
