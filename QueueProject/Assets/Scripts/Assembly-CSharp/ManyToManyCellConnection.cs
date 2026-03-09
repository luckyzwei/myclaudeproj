using System.Collections.Generic;

public class ManyToManyCellConnection
{
	private Dictionary<int, List<int>> connections;

	private Dictionary<int, List<int>> reverseConnections;

	public void Add(int key, int value)
	{
	}

	public List<int> GetValues(int key)
	{
		return null;
	}

	public List<int> GetKeys(int value)
	{
		return null;
	}

	public bool ContainsKey(int key)
	{
		return false;
	}

	public bool ContainsValue(int value)
	{
		return false;
	}

	public void Clear()
	{
	}
}
