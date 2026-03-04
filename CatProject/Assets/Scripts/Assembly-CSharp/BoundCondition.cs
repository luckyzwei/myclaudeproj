using System.Collections.Generic;

public class BoundCondition
{
	public string Selector { get; set; }

	public BoundType Type { get; protected set; }

	public IndexerCondition Indexer { get; set; }

	public List<SelectorCondition> Selectors { get; set; }

	public BoundCondition(string selector, BoundType type)
	{
		Selector = selector;
		Type = type;
	}
}
