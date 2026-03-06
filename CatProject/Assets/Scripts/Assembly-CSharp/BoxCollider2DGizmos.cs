using UnityEngine;

[ExecuteInEditMode]
public class BoxCollider2DGizmos : MonoBehaviour
{
	public Color gizmoColor;

	public int gizmoSize;

	public bool isActive;

	private BoxCollider2D coll;

	private void Start()
	{
		// Start initialization
	}
}
