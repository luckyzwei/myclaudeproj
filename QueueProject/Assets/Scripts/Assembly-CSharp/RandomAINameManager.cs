using System.Collections.Generic;

public static class RandomAINameManager
{
	private static int m_currentIndex;

	private static List<string> m_nameList;

	private static List<string> m_nameListRestricted;

	public static void ShuffleList(int newSeed = -1)
	{
	}

	public static string GetRandomName()
	{
		return null;
	}

	public static string GetRandomNameRestricted()
	{
		return null;
	}

	public static void ClearRestricted()
	{
	}

	public static void ClearNonRestriced()
	{
	}

	public static void AddName(string name, bool includeRestricted = true)
	{
	}

	public static void AddNames(List<string> names, bool includeRestricted = true)
	{
	}

	public static string[] GetNamesArray(bool restricted)
	{
		return null;
	}
}
