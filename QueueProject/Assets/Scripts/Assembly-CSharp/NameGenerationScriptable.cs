using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewNameGenerationData", menuName = "Kwalee/KWLeaderboard/NameGenerationScriptable")]
public class NameGenerationScriptable : ScriptableObject
{
	[Serializable]
	public struct PrefixSuffixStruct
	{
		public string prefix;

		public string suffix;
	}

	public PrefixSuffixStruct[] prefixSuffixPairs;

	public string[] capitalization;
}
