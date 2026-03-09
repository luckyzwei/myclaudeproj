using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/LevelData")]
public class LevelDataScriptable : ScriptableObject
{
	public LevelData data;

	[ContextMenu("Fix Colors")]
	public bool FixColors()
	{
		if (data == null) return false;
		return data.FixColours();
	}

	[ContextMenu("Grab Used Colours")]
	public void GrabUsedColours()
	{
		if (data != null)
			data.GenerateUsedColours();
	}
}
