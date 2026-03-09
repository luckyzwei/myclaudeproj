using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/PercentData")]
public class LevelCompletionPercentScriptable : ScriptableObject
{
	public List<float> completionPercents;

	public string inputPercents;

	[Button(null, EButtonEnableMode.Always)]
	public void ParsePercents()
	{
		if (string.IsNullOrEmpty(inputPercents)) return;
		completionPercents = new List<float>();
		string[] parts = inputPercents.Split(',');
		for (int i = 0; i < parts.Length; i++)
		{
			float val;
			if (float.TryParse(parts[i].Trim(), out val))
				completionPercents.Add(val);
		}
	}
}
