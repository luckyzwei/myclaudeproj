using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TpFindObjectViaRayCast
{
	private static GameObject findEventSystemObject(PointerEventData pointerEventData)
	{
		return null;
	}

	public static GameObject FindObjectAtCoordinates(Vector2 screenPosition)
	{
		return null;
	}

	public static GameObject FindMonoBehaviourObject(Vector2 coordinates)
	{
		return null;
	}

	public static GameObject GetGameObjectHitMonoBehaviour(Vector2 coordinates)
	{
		return null;
	}

	public static int FindCameraThatSeesObject(GameObject gameObject, out Vector3 position)
	{
		position = default(Vector3);
		return 0;
	}

	public static Vector3 GetObjectScreenPosition(GameObject gameObject, Camera camera)
	{
		return default(Vector3);
	}

	public static void GetAllRaycastResults(PointerEventData pointerEventData, out List<RaycastResult> raycastResults)
	{
		raycastResults = null;
	}
}
