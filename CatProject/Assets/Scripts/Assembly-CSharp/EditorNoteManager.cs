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
		}

		public Dictionary<string, string> ToDictionary()
		{
			return null;
		}
	}

	private static Dictionary<string, string> memoDictionary;

	private static string MemoFilePath => null;

	static EditorNoteManager()
	{
	}

	public static void SaveMemo(string guid, string memo)
	{
	}

	public static string LoadMemo(string guid)
	{
		return null;
	}

	private static void LoadMemos()
	{
	}
}
