using System.Collections.Generic;

public class BaseGameFindObjectParams : TpCommandParams
{
	public List<BoundCondition> objectConditions;

	public List<BoundCondition> cameraConditions;

	public bool enabled { get; protected set; }

	public BaseGameFindObjectParams(List<BoundCondition> objectConditions, List<BoundCondition> cameraConditions, bool enabled)
	{
		this.objectConditions = objectConditions;
		this.cameraConditions = cameraConditions;
		this.enabled = enabled;
	}
}
