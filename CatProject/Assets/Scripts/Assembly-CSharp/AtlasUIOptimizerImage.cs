using UnityEngine;

public class AtlasUIOptimizerImage : MonoBehaviour
{
	public enum AtlasType
	{
		Character = 0
	}

	public AtlasType loadType;

	public static float wTime;

	private void Awake()
	{
		// Register with atlas loading system
	}

	private void OnDestroy()
	{
		// Unregister from atlas loading system
	}
}
