using System.Collections.Generic;
using UnityEngine;

public class TpBaseFindObjectsCommand<T> : TpCommand<BaseGameFindObjectParams, T>
{
	protected readonly BaseGameFindObjectParams FindObjectsParams;

	protected TpBaseFindObjectsCommand(BaseGameFindObjectParams cmdParams)
		: base((BaseGameFindObjectParams)default(T))
	{
	}

	public override T Execute()
	{
		return default(T);
	}

	public List<GameObject> FindObjects(GameObject gameObject, List<BoundCondition> boundConditions, int index, bool singleObject, bool enabled)
	{
		return null;
	}

	protected Camera GetCamera(List<BoundCondition> cameraConditons)
	{
		return null;
	}

	private bool checkValidVisibility(GameObject objectToCheck, bool enabled)
	{
		return false;
	}

	private GameObject objectMatchesConditions(GameObject objectToCheck, BoundCondition boundCondition, bool enabled)
	{
		return null;
	}

	private List<GameObject> getGameObjectsToCheck(GameObject gameObject)
	{
		return null;
	}

	private List<GameObject> getAllChildren(GameObject gameObject)
	{
		return null;
	}

	private List<GameObject> getAllRootObjects()
	{
		return null;
	}

	protected bool IsCameraSpecified(List<BoundCondition> cameraConditions)
	{
		return false;
	}
}
