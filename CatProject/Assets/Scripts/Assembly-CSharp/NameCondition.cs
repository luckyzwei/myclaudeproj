public class NameCondition : SelectorCondition
{
	public string Name { get; set; }

	public NameCondition(string selector)
		: base(selector, default(SelectorType))
	{
	}
}
