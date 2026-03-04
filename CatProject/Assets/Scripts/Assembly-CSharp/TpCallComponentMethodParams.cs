using System.Collections.Generic;

[Command("callComponentMethod")]
public class TpCallComponentMethodParams : BaseGameFindObjectParams
{
	public string componentName;

	public string methodName;

	public TpCallComponentMethodParams(List<BoundCondition> objectConditions, List<BoundCondition> cameraConditions, bool enabled, string componentName, string methodName)
		: base(objectConditions, cameraConditions, enabled)
	{
		this.componentName = componentName;
		this.methodName = methodName;
	}
}
