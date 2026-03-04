[Command("getObjectComponentProperty")]
public class TpGetObjectComponentPropertyParams : BaseTpObjectParams
{
	public string component;

	public string property;

	public string assembly;

	public int maxDepth;

	public TpGetObjectComponentPropertyParams(TpObject TpObject, string component, string property, string assembly, int maxDepth)
		: base(null)
	{
		TpObject = TpObject;
		component = component;
		property = property;
		assembly = assembly;
		maxDepth = maxDepth;
	}
}
