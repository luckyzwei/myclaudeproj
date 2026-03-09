using System;

[Serializable]
public abstract class CacheableData
{
	public long Epoch { get; set; }

	public bool IsStale { get; set; }

	public bool IsDirty { get; set; }
}
