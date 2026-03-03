public class FunctionCondition : SelectorCondition
{
	public PropertyType Property { get; private set; }

	public string PropertyValue { get; set; }

	public FunctionType Function { get; private set; }

	public FunctionCondition(string selector)
		: base(null, default(SelectorType))
	{
	}
}
