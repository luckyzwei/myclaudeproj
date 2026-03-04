using System.Collections.Generic;

[Command("findObjects")]
public class TpGameFindObjectsParams : BaseGameFindObjectParams
{
	public TpGameFindObjectsParams(List<BoundCondition> objectConditions, List<BoundCondition> cameraConditions, bool enabled)
		: base(objectConditions, cameraConditions, enabled)
	{
	}
}
