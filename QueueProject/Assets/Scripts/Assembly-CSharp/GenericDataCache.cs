using System.Collections.Generic;

public class GenericDataCache<T> where T : CacheableData
{
	private const int MONTH_IN_SECONDS = 2592000;

	private Dictionary<string, T> m_cache;

	private readonly long m_cacheDurationInSeconds;

	private readonly string m_cachePath;

	public GenericDataCache(string cacheId, long cacheDurationSeconds)
	{
	}

	public void SetStale()
	{
	}

	public void SetData(string key, T data)
	{
	}

	public T GetData(string key)
	{
		return null;
	}

	public bool IsStale(string key)
	{
		return false;
	}

	public bool IsDirty(string key)
	{
		return false;
	}

	private void LoadData()
	{
	}

	private void CleanExpiredData()
	{
	}

	private void SaveCache()
	{
	}

	public void ClearAll()
	{
	}
}
