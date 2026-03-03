using UnityEngine;

public class ObjectFollowCam : MonoBehaviour
{
	[Header("Follow Settings")]
	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private Vector3 offset;

	[Header("Zoom Settings")]
	[SerializeField]
	private float minZoom;

	[SerializeField]
	private float maxZoom;

	[SerializeField]
	private float zoomSmoothTime;

	[SerializeField]
	private float defaultZoom;

	[Header("Debug")]
	[SerializeField]
	private bool showDebug;

	private Transform target;

	private float currentZoomVelocity;

	private bool isFollowing;

	private Camera cam;

	private float targetZoom;

	private Vector3 lastTargetPosition;

	private void Awake()
	{
	}

	public void StartFollow(Transform newTarget)
	{
	}

	public void StopFollow()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetZoom(float zoom)
	{
	}

	public void SetZoomRange(float min, float max)
	{
	}

	public void SetCameraSettings(float newMoveSpeed)
	{
	}

	public void SetOffset(Vector3 newOffset)
	{
	}

	public void SetZoomSmoothTime(float time)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
