using System.Collections.Generic;

[Command("findObject")]
public class TpGameFindObjectParams : BaseGameFindObjectParams
{
	public TpGameFindObjectParams(List<BoundCondition> objectConditions, List<BoundCondition> cameraConditions, bool enabled)
		: base(objectConditions, cameraConditions, enabled)
	{
	}
}
