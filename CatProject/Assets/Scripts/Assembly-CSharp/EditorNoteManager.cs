using System;
using System.Collections.Generic;

public class EditorNoteManager
{
	[Serializable]
	private class MemoDataWrapper
	{
		public List<string> keys;

		public List<string> values;

		public MemoDataWrapper(Dictionary<string, string> dict)
		{
			keys = new List<string>();
			values = new List<string>();
			if (dict != null)
			{
				foreach (var kvp in dict)
				{
					keys.Add(kvp.Key);
					values.Add(kvp.Value);
				}
			}
		}

		public Dictionary<string, string> ToDictionary()
		{
			var dict = new Dictionary<string, string>();
			if (keys != null && values != null)
			{
				int count = Math.Min(keys.Count, values.Count);
				for (int i = 0; i < count; i++)
				{
					if (!string.IsNullOrEmpty(keys[i]))
						dict[keys[i]] = values[i];
				}
			}
			return dict;
		}
	}

	private static Dictionary<string, string> memoDictionary;

	private static string MemoFilePath => "EditorNotes.json";

	static EditorNoteManager()
	{
		memoDictionary = new Dictionary<string, string>();
		LoadMemos();
	}

	public static void SaveMemo(string guid, string memo)
	{
		if (memoDictionary == null)
			memoDictionary = new Dictionary<string, string>();
		if (string.IsNullOrEmpty(memo))
			memoDictionary.Remove(guid);
		else
			memoDictionary[guid] = memo;
	}

	public static string LoadMemo(string guid)
	{
		if (memoDictionary == null) return null;
		memoDictionary.TryGetValue(guid, out var memo);
		return memo;
	}

	private static void LoadMemos()
	{
		if (memoDictionary == null)
			memoDictionary = new Dictionary<string, string>();
	}
}
