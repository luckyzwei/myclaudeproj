public class AnyCondition : SelectorCondition
{
	public AnyCondition(string selector)
		: base(selector, default(SelectorType))
	{
	}
}
