public class IndexerCondition : SelectorCondition
{
	public int Index { get; private set; }

	public int CurrentIndexCountDown { get; set; }

	public IndexerCondition(string selector)
		: base(selector, default(SelectorType))
	{
	}
}
