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
		cam = GetComponent<Camera>();
		if (cam == null) cam = Camera.main;
		targetZoom = defaultZoom;
	}

	public void StartFollow(Transform newTarget)
	{
		target = newTarget;
		isFollowing = true;
		if (target != null)
			lastTargetPosition = target.position;
	}

	public void StopFollow()
	{
		isFollowing = false;
		target = null;
	}

	private void LateUpdate()
	{
		if (!isFollowing || target == null) return;
		Vector3 desiredPos = target.position + offset;
		transform.position = Vector3.Lerp(transform.position, desiredPos, moveSpeed * Time.deltaTime);
		lastTargetPosition = target.position;
		if (cam != null)
		{
			cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, targetZoom, ref currentZoomVelocity, zoomSmoothTime);
		}
	}

	public void SetZoom(float zoom)
	{
		targetZoom = Mathf.Clamp(zoom, minZoom, maxZoom);
	}

	public void SetZoomRange(float min, float max)
	{
		minZoom = min;
		maxZoom = max;
	}

	public void SetCameraSettings(float newMoveSpeed)
	{
		moveSpeed = newMoveSpeed;
	}

	public void SetOffset(Vector3 newOffset)
	{
		offset = newOffset;
	}

	public void SetZoomSmoothTime(float time)
	{
		zoomSmoothTime = time;
	}

	private void OnDrawGizmos()
	{
		if (!showDebug || target == null) return;
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(target.position + offset, 0.5f);
	}
}
