public class PropertyEqualsCondition : SelectorCondition
{
	public PropertyType Property { get; private set; }

	public string PropertyValue { get; set; }

	public PropertyEqualsCondition(string selector)
		: base(null, default(SelectorType))
	{
	}
}
