public class SelectorCondition
{
	public string Selector { get; set; }

	public SelectorType Type { get; protected set; }

	public SelectorCondition(string selector, SelectorType type)
	{
	}

	protected static PropertyType GetPropertyType(string property)
	{
		return default(PropertyType);
	}

	protected static FunctionType GetFunctionType(string functionName)
	{
		return default(FunctionType);
	}
}
