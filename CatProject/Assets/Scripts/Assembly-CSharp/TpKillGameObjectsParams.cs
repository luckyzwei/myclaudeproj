using System.Collections.Generic;

[Command("killGameObjects")]
public class TpKillGameObjectsParams : BaseGameFindObjectParams
{
	public TpKillGameObjectsParams(List<BoundCondition> objectConditions, List<BoundCondition> cameraConditions, bool enabled)
		: base(null, null, enabled: false)
	{
	}
}
