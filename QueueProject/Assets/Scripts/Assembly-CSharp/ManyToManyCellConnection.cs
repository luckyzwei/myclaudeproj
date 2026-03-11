using System.Collections.Generic;

public class ManyToManyCellConnection
{
	private Dictionary<int, List<int>> connections;

	private Dictionary<int, List<int>> reverseConnections;

	public ManyToManyCellConnection()
	{
		connections = new Dictionary<int, List<int>>();
		reverseConnections = new Dictionary<int, List<int>>();
	}

	public void Add(int key, int value)
	{
		if (!connections.TryGetValue(key, out var list))
		{
			list = new List<int>();
			connections[key] = list;
		}
		if (!list.Contains(value))
			list.Add(value);

		if (!reverseConnections.TryGetValue(value, out var revList))
		{
			revList = new List<int>();
			reverseConnections[value] = revList;
		}
		if (!revList.Contains(key))
			revList.Add(key);
	}

	public List<int> GetValues(int key)
	{
		if (connections != null && connections.TryGetValue(key, out var list))
			return list;
		return null;
	}

	public List<int> GetKeys(int value)
	{
		if (reverseConnections != null && reverseConnections.TryGetValue(value, out var list))
			return list;
		return null;
	}

	public bool ContainsKey(int key)
	{
		return connections != null && connections.ContainsKey(key);
	}

	public bool ContainsValue(int value)
	{
		return reverseConnections != null && reverseConnections.ContainsKey(value);
	}

	public void Clear()
	{
		connections?.Clear();
		reverseConnections?.Clear();
	}
}
