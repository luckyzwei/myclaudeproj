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
	}
}
