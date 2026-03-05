using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SuperBlur;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanAndZoom : MonoBehaviour
{
	public enum FollowType
	{
		All = 0,
		OnlyY = 1
	}

	[Header("Tap")]
	[Tooltip("The maximum movement for a touch motion to be treated as a tap")]
	public float maxDistanceForTap;

	[Tooltip("The maximum duration for a touch motion to be treated as a tap")]
	public float maxDurationForTap;

	[Header("Desktop debug")]
	[Tooltip("Use the mouse on desktop?")]
	public bool useMouse;

	[Tooltip("The simulated pinch speed using the scroll wheel")]
	public float mouseScrollSpeed;

	[Header("Camera control")]
	[Tooltip("Enable ZoomInOut")]
	public bool enableZoom;

	[Tooltip("Does the script control camera movement?")]
	public bool controlCamera;

	[Tooltip("The controlled camera, ignored of controlCamera=false")]
	public Camera cam;

	[Header("UI")]
	[Tooltip("Are touch motions listened to if they are over UI elements?")]
	public bool ignoreUI;

	[Header("Bounds")]
	[Tooltip("Is the camera bound to an area?")]
	public bool useBounds;

	public global::SuperBlur.SuperBlur blur;

	public float boundMinX;

	public float boundMaxX;

	public float boundMinY;

	public float boundMaxY;

	[Header("Etc")]
	public float focusSize;

	public float focusMoveDuration;

	public float zoomOutSizeDefault;

	public float zoomMinSize;

	public float doubleclickInterval;

	private bool follow;

	private Transform followTrans;

	private FollowType followType;

	private bool focusing;

	private bool moving;

	private float dragSpeed;

	private Vector3 movingTarget;

	private Vector3 distanceOrigin;

	private Vector3 focusTargetPos;

	private Vector3 focusOriginPos;

	private float focusOriginCameraSize;

	private float focusDeltaTime;

	private Vector2 touch0StartPosition;

	private Vector2 touch0LastPosition;

	private float touch0StartTime;

	[HideInInspector]
	public float zoomOutSize;

	[HideInInspector]
	public float maxZoomOutSize;

	private bool cameraControlEnabled;

	public Action OnFoucusEnd;

	private bool canUseMouse;

	private float timeRealDragStop;

	private Vector3 cameraScrollVelocity;

	private AnimationCurve autoScrollDampCurve;

	private Vector3 camVelocity;

	private Vector3 posLastFrame;

	private bool multiTouch;

	private bool doubleclick;

	private float doubleclicktime;

	private bool isFixX;

	private bool isFixY;

	private float backupCamSize;

	[SerializeField]
	private bool allowMove;

	private Action<Vector2> _onStartTouch;
	private Action<Vector2> _onEndTouch;
	private Action<Vector2> _onSwipe;
	private Action<float, float> _onPinch;

	public bool IsZoomOutOver { get { return cam != null && cam.orthographicSize >= zoomOutSize; } }

	public float ZoomSize { get { return cam != null ? cam.orthographicSize : 0f; } }

	public bool isTouching { get; private set; }

	public Vector2 touchPosition
	{
		get
		{
			if (Input.touchCount > 0)
			{
				return Input.GetTouch(0).position;
			}
			return Input.mousePosition;
		}
	}

	public Vector3 DefaltCenter { get; private set; }

	public event Action<Vector2> onStartTouch
	{
		[CompilerGenerated]
		add
		{
			_onStartTouch = (Action<Vector2>)Delegate.Combine(_onStartTouch, value);
		}
		[CompilerGenerated]
		remove
		{
			_onStartTouch = (Action<Vector2>)Delegate.Remove(_onStartTouch, value);
		}
	}

	public event Action<Vector2> onEndTouch
	{
		[CompilerGenerated]
		add
		{
			_onEndTouch = (Action<Vector2>)Delegate.Combine(_onEndTouch, value);
		}
		[CompilerGenerated]
		remove
		{
			_onEndTouch = (Action<Vector2>)Delegate.Remove(_onEndTouch, value);
		}
	}

	public event Action<Vector2> onSwipe
	{
		[CompilerGenerated]
		add
		{
			_onSwipe = (Action<Vector2>)Delegate.Combine(_onSwipe, value);
		}
		[CompilerGenerated]
		remove
		{
			_onSwipe = (Action<Vector2>)Delegate.Remove(_onSwipe, value);
		}
	}

	public event Action<float, float> onPinch
	{
		[CompilerGenerated]
		add
		{
			_onPinch = (Action<float, float>)Delegate.Combine(_onPinch, value);
		}
		[CompilerGenerated]
		remove
		{
			_onPinch = (Action<float, float>)Delegate.Remove(_onPinch, value);
		}
	}

	private void Awake()
	{
		if (cam == null)
		{
			cam = Camera.main;
		}
		zoomOutSize = zoomOutSizeDefault;
		maxZoomOutSize = zoomOutSizeDefault;
		cameraControlEnabled = true;
		canUseMouse = true;
		allowMove = true;
		autoScrollDampCurve = AnimationCurve.EaseInOut(0f, 1f, 1f, 0f);
	}

	private void Start()
	{
		if (cam != null)
		{
			DefaltCenter = cam.transform.position;
			posLastFrame = cam.transform.position;
			backupCamSize = cam.orthographicSize;
		}
	}

	private void LateUpdate()
	{
		if (cam == null || !controlCamera)
		{
			return;
		}

		if (follow && followTrans != null)
		{
			Vector3 targetPos = cam.transform.position;
			if (followType == FollowType.All)
			{
				targetPos.x = followTrans.position.x;
				targetPos.y = followTrans.position.y;
			}
			else if (followType == FollowType.OnlyY)
			{
				targetPos.y = followTrans.position.y;
			}
			cam.transform.position = Vector3.Lerp(cam.transform.position, targetPos, Time.deltaTime * 5f);
		}

		if (focusing)
		{
			focusDeltaTime += Time.deltaTime;
			float t = Mathf.Clamp01(focusDeltaTime / focusMoveDuration);
			float smoothT = Mathf.SmoothStep(0f, 1f, t);

			Vector3 newPos = Vector3.Lerp(focusOriginPos, focusTargetPos, smoothT);
			newPos.z = cam.transform.position.z;
			cam.transform.position = newPos;

			cam.orthographicSize = Mathf.Lerp(focusOriginCameraSize, focusSize, smoothT);

			if (t >= 1f)
			{
				focusing = false;
				if (OnFoucusEnd != null)
				{
					OnFoucusEnd();
				}
			}
		}

		if (!isTouching && !focusing && !follow)
		{
			float elapsed = Time.realtimeSinceStartup - timeRealDragStop;
			if (cameraScrollVelocity.sqrMagnitude > 0.001f && elapsed < 1.5f)
			{
				float damp = EvaluateAutoScrollDampCurve(elapsed / 1.5f);
				Vector3 scrollDelta = cameraScrollVelocity * damp * Time.deltaTime;
				cam.transform.position += scrollDelta;
			}
			else
			{
				cameraScrollVelocity = Vector3.zero;
			}
		}

		if (useBounds)
		{
			CameraInBounds();
		}

		camVelocity = (cam.transform.position - posLastFrame) / Time.deltaTime;
		posLastFrame = cam.transform.position;
	}

	public void UpdateBound()
	{
		if (cam == null)
		{
			return;
		}
		float vertExtent = cam.orthographicSize;
		float horzExtent = vertExtent * cam.aspect;
		if (boundMaxX - boundMinX < horzExtent * 2f)
		{
			isFixX = true;
		}
		else
		{
			isFixX = false;
		}
		if (boundMaxY - boundMinY < vertExtent * 2f)
		{
			isFixY = true;
		}
		else
		{
			isFixY = false;
		}
	}

	public void SetFixX()
	{
		isFixX = true;
	}

	private void Update()
	{
		if (!cameraControlEnabled || cam == null)
		{
			return;
		}

		if (useMouse && canUseMouse)
		{
			UpdateWithMouse();
		}
		else
		{
			UpdateWithTouch();
		}
	}

	private float EvaluateAutoScrollDampCurve(float t)
	{
		if (autoScrollDampCurve != null)
		{
			return autoScrollDampCurve.Evaluate(t);
		}
		return 1f - t;
	}

	private void UpdateWithMouse()
	{
		if (Input.GetMouseButtonDown(0))
		{
			if (!ignoreUI && IsPointerOverUIObject(Input.mousePosition))
			{
				return;
			}
			touch0StartPosition = Input.mousePosition;
			touch0LastPosition = touch0StartPosition;
			touch0StartTime = Time.time;
			isTouching = true;
			cameraScrollVelocity = Vector3.zero;

			if (_onStartTouch != null)
			{
				_onStartTouch(Input.mousePosition);
			}
		}

		if (Input.GetMouseButton(0) && isTouching)
		{
			Vector2 currentPos = Input.mousePosition;
			Vector2 delta = currentPos - touch0LastPosition;
			if (delta.sqrMagnitude > 0.01f && controlCamera && allowMove)
			{
				OnSwipe(delta);
			}
			touch0LastPosition = currentPos;
		}

		if (Input.GetMouseButtonUp(0) && isTouching)
		{
			isTouching = false;
			Vector2 endPos = Input.mousePosition;
			float distance = Vector2.Distance(touch0StartPosition, endPos);
			float duration = Time.time - touch0StartTime;

			if (distance <= maxDistanceForTap && duration <= maxDurationForTap)
			{
				OnClick(endPos);
			}
			else if (controlCamera)
			{
				timeRealDragStop = Time.realtimeSinceStartup;
				cameraScrollVelocity = -camVelocity;
			}

			if (_onEndTouch != null)
			{
				_onEndTouch(endPos);
			}
		}

		if (enableZoom)
		{
			float scroll = Input.GetAxis("Mouse ScrollWheel");
			if (Mathf.Abs(scroll) > 0.01f)
			{
				float newSize = cam.orthographicSize - scroll * mouseScrollSpeed;
				newSize = Mathf.Clamp(newSize, zoomMinSize, zoomOutSize);
				Vector3 mouseWorldBefore = cam.ScreenToWorldPoint(Input.mousePosition);
				cam.orthographicSize = newSize;
				Vector3 mouseWorldAfter = cam.ScreenToWorldPoint(Input.mousePosition);
				if (controlCamera)
				{
					cam.transform.position += mouseWorldBefore - mouseWorldAfter;
				}
				UpdateBound();
			}
		}
	}

	private void CheckMoveTarget(Vector2 input, bool touch = false)
	{
		if (!controlCamera || !allowMove)
		{
			return;
		}
		Vector3 worldPos = cam.ScreenToWorldPoint(new Vector3(input.x, input.y, 0f));
		worldPos.z = cam.transform.position.z;
		movingTarget = worldPos;
		moving = true;
	}

	private void UpdateWithTouch()
	{
		int touchCount = Input.touchCount;

		if (touchCount == 0)
		{
			if (isTouching)
			{
				isTouching = false;
				multiTouch = false;
				float distance = Vector2.Distance(touch0StartPosition, touch0LastPosition);
				float duration = Time.time - touch0StartTime;

				if (distance <= maxDistanceForTap && duration <= maxDurationForTap)
				{
					OnClick(touch0LastPosition);
				}
				else if (controlCamera)
				{
					timeRealDragStop = Time.realtimeSinceStartup;
					cameraScrollVelocity = -camVelocity;
				}

				if (_onEndTouch != null)
				{
					_onEndTouch(touch0LastPosition);
				}
			}
			return;
		}

		Touch touch0 = Input.GetTouch(0);

		if (touchCount == 1)
		{
			if (touch0.phase == TouchPhase.Began)
			{
				if (!ignoreUI && IsPointerOverUIObject(touch0.position))
				{
					return;
				}
				touch0StartPosition = touch0.position;
				touch0LastPosition = touch0.position;
				touch0StartTime = Time.time;
				isTouching = true;
				multiTouch = false;
				cameraScrollVelocity = Vector3.zero;

				if (_onStartTouch != null)
				{
					_onStartTouch(touch0.position);
				}

				if (doubleclick && (Time.time - doubleclicktime) < doubleclickInterval)
				{
					doubleclick = false;
					if (enableZoom && controlCamera)
					{
						if (cam.orthographicSize < zoomOutSize - 0.1f)
						{
							FocusOut();
						}
						else
						{
							Vector3 worldPos = cam.ScreenToWorldPoint(touch0.position);
							worldPos.z = cam.transform.position.z;
							FocusPosition(worldPos, focusSize, true);
						}
					}
					return;
				}
				doubleclick = true;
				doubleclicktime = Time.time;
			}
			else if (touch0.phase == TouchPhase.Moved && isTouching && !multiTouch)
			{
				Vector2 delta = touch0.position - touch0LastPosition;
				if (delta.sqrMagnitude > 0.01f && controlCamera && allowMove)
				{
					OnSwipe(delta);
				}
				touch0LastPosition = touch0.position;
			}
		}
		else if (touchCount >= 2 && enableZoom)
		{
			multiTouch = true;
			Touch touch1 = Input.GetTouch(1);

			Vector2 prevTouch0 = touch0.position - touch0.deltaPosition;
			Vector2 prevTouch1 = touch1.position - touch1.deltaPosition;

			float oldDistance = Vector2.Distance(prevTouch0, prevTouch1);
			float newDistance = Vector2.Distance(touch0.position, touch1.position);

			Vector2 center = (touch0.position + touch1.position) * 0.5f;
			Vector2 touchDelta = (touch0.deltaPosition + touch1.deltaPosition) * 0.5f;

			if (Mathf.Abs(oldDistance - newDistance) > 1f)
			{
				OnPinch(center, oldDistance, newDistance, touchDelta);
			}
			else if (controlCamera && allowMove)
			{
				OnSwipe(touchDelta);
			}

			touch0LastPosition = touch0.position;
		}
	}

	private void OnClick(Vector2 position)
	{
		if (doubleclick && (Time.time - doubleclicktime) < doubleclickInterval && useMouse)
		{
			doubleclick = false;
			if (enableZoom && controlCamera)
			{
				if (cam.orthographicSize < zoomOutSize - 0.1f)
				{
					FocusOut();
				}
				else
				{
					Vector3 worldPos = cam.ScreenToWorldPoint(position);
					worldPos.z = cam.transform.position.z;
					FocusPosition(worldPos, focusSize, true);
				}
			}
			return;
		}
		if (useMouse)
		{
			doubleclick = true;
			doubleclicktime = Time.time;
		}
	}

	private void OnSwipe(Vector2 deltaPosition)
	{
		if (!controlCamera || cam == null || !allowMove)
		{
			return;
		}

		focusing = false;

		Vector3 screenDelta = new Vector3(-deltaPosition.x, -deltaPosition.y, 0f);
		Vector3 worldBefore = cam.ScreenToWorldPoint(Vector3.zero);
		Vector3 worldAfter = cam.ScreenToWorldPoint(screenDelta);
		Vector3 worldDelta = worldAfter - worldBefore;

		if (isFixX)
		{
			worldDelta.x = 0f;
		}
		if (isFixY)
		{
			worldDelta.y = 0f;
		}

		cam.transform.position += worldDelta;

		if (_onSwipe != null)
		{
			_onSwipe(deltaPosition);
		}
	}

	public void CameraZoom(Vector3 worldCenter, float zoomSize)
	{
		if (cam == null)
		{
			return;
		}
		float newSize = Mathf.Clamp(zoomSize, zoomMinSize, zoomOutSize);
		cam.orthographicSize = newSize;
		Vector3 pos = cam.transform.position;
		pos.x = worldCenter.x;
		pos.y = worldCenter.y;
		cam.transform.position = pos;
		UpdateBound();
		if (useBounds)
		{
			CameraInBounds();
		}
	}

	private void OnPinch(Vector2 center, float oldDistance, float newDistance, Vector2 touchDelta)
	{
		if (!controlCamera || cam == null)
		{
			return;
		}

		focusing = false;

		float ratio = oldDistance / newDistance;
		float newSize = cam.orthographicSize * ratio;
		newSize = Mathf.Clamp(newSize, zoomMinSize, zoomOutSize);

		Vector3 worldCenterBefore = cam.ScreenToWorldPoint(center);
		cam.orthographicSize = newSize;
		Vector3 worldCenterAfter = cam.ScreenToWorldPoint(center);

		cam.transform.position += worldCenterBefore - worldCenterAfter;

		UpdateBound();

		if (_onPinch != null)
		{
			_onPinch(oldDistance, newDistance);
		}
	}

	public bool IsPointerOverUIObject(Vector2 touchPosition)
	{
		PointerEventData eventData = new PointerEventData(EventSystem.current);
		eventData.position = touchPosition;
		List<RaycastResult> results = new List<RaycastResult>();
		if (EventSystem.current != null)
		{
			EventSystem.current.RaycastAll(eventData, results);
		}
		return results.Count > 0;
	}

	public Vector2 RandomPointInBounds()
	{
		float x = UnityEngine.Random.Range(boundMinX, boundMaxX);
		float y = UnityEngine.Random.Range(boundMinY, boundMaxY);
		return new Vector2(x, y);
	}

	public bool IsClickInGameObject(Vector2 touchPosition)
	{
		if (cam == null)
		{
			return false;
		}
		Vector3 worldPos = cam.ScreenToWorldPoint(touchPosition);
		RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);
		return hit.collider != null;
	}

	public void SetCameraZoom(float focusSize)
	{
		if (cam == null)
		{
			return;
		}
		cam.orthographicSize = Mathf.Clamp(focusSize, zoomMinSize, zoomOutSize);
		UpdateBound();
	}

	public void FocusPositionImmediately(Vector3 worldPos, float _focusSize = 15f)
	{
		if (cam == null)
		{
			return;
		}
		focusing = false;
		cameraScrollVelocity = Vector3.zero;
		Vector3 pos = cam.transform.position;
		pos.x = worldPos.x;
		pos.y = worldPos.y;
		cam.transform.position = pos;
		cam.orthographicSize = Mathf.Clamp(_focusSize, zoomMinSize, zoomOutSize);
		UpdateBound();
		if (useBounds)
		{
			CameraInBounds();
		}
	}

	public void FocusPosition(Vector3 worldPos, float _focusSize = 15f, bool isbackup = true)
	{
		if (cam == null)
		{
			return;
		}
		if (isbackup)
		{
			backupCamSize = cam.orthographicSize;
		}
		focusing = true;
		cameraScrollVelocity = Vector3.zero;
		focusDeltaTime = 0f;
		focusOriginPos = cam.transform.position;
		focusTargetPos = new Vector3(worldPos.x, worldPos.y, cam.transform.position.z);
		focusOriginCameraSize = cam.orthographicSize;
		focusSize = Mathf.Clamp(_focusSize, zoomMinSize, zoomOutSize);
	}

	public void FollowCameraPos(Transform worldTrans, float _focusSize = 15f, FollowType _followType = FollowType.All)
	{
		if (cam == null || worldTrans == null)
		{
			return;
		}
		follow = true;
		followTrans = worldTrans;
		followType = _followType;
		backupCamSize = cam.orthographicSize;
		cam.orthographicSize = Mathf.Clamp(_focusSize, zoomMinSize, zoomOutSize);
		focusing = false;
		cameraScrollVelocity = Vector3.zero;
		UpdateBound();
	}

	public void EndFollow()
	{
		follow = false;
		followTrans = null;
	}

	public void FocusOutBackup()
	{
		if (cam == null)
		{
			return;
		}
		focusing = true;
		cameraScrollVelocity = Vector3.zero;
		focusDeltaTime = 0f;
		focusOriginPos = cam.transform.position;
		focusTargetPos = DefaltCenter;
		focusTargetPos.z = cam.transform.position.z;
		focusOriginCameraSize = cam.orthographicSize;
		focusSize = backupCamSize;
	}

	public void FocusOut()
	{
		if (cam == null)
		{
			return;
		}
		focusing = true;
		cameraScrollVelocity = Vector3.zero;
		focusDeltaTime = 0f;
		focusOriginPos = cam.transform.position;
		focusTargetPos = DefaltCenter;
		focusTargetPos.z = cam.transform.position.z;
		focusOriginCameraSize = cam.orthographicSize;
		focusSize = zoomOutSize;
	}

	public void FocusOrigin()
	{
		if (cam == null)
		{
			return;
		}
		focusing = true;
		cameraScrollVelocity = Vector3.zero;
		focusDeltaTime = 0f;
		focusOriginPos = cam.transform.position;
		focusTargetPos = DefaltCenter;
		focusTargetPos.z = cam.transform.position.z;
		focusOriginCameraSize = cam.orthographicSize;
		focusSize = zoomOutSizeDefault;
	}

	public void CancelCamera()
	{
		focusing = false;
		moving = false;
		follow = false;
		followTrans = null;
		isTouching = false;
		cameraScrollVelocity = Vector3.zero;
	}

	private void CameraInBounds()
	{
		if (cam == null)
		{
			return;
		}
		float vertExtent = cam.orthographicSize;
		float horzExtent = vertExtent * cam.aspect;

		Vector3 pos = cam.transform.position;

		if (isFixX)
		{
			pos.x = (boundMinX + boundMaxX) * 0.5f;
		}
		else
		{
			float minX = boundMinX + horzExtent;
			float maxX = boundMaxX - horzExtent;
			if (minX > maxX)
			{
				pos.x = (boundMinX + boundMaxX) * 0.5f;
			}
			else
			{
				pos.x = Mathf.Clamp(pos.x, minX, maxX);
			}
		}

		if (isFixY)
		{
			pos.y = (boundMinY + boundMaxY) * 0.5f;
		}
		else
		{
			float minY = boundMinY + vertExtent;
			float maxY = boundMaxY - vertExtent;
			if (minY > maxY)
			{
				pos.y = (boundMinY + boundMaxY) * 0.5f;
			}
			else
			{
				pos.y = Mathf.Clamp(pos.y, minY, maxY);
			}
		}

		cam.transform.position = pos;
	}

	public Texture2D TakeScreenShot(bool _blur = true)
	{
		if (_blur && blur != null)
		{
			blur.enabled = true;
		}
		RenderTexture rt = new RenderTexture(Screen.width, Screen.height, 24);
		cam.targetTexture = rt;
		cam.Render();
		RenderTexture.active = rt;
		Texture2D screenshot = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		screenshot.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		screenshot.Apply();
		cam.targetTexture = null;
		RenderTexture.active = null;
		UnityEngine.Object.Destroy(rt);
		if (_blur && blur != null)
		{
			blur.enabled = false;
		}
		return screenshot;
	}

	public void SetAllowMove(bool allow)
	{
		allowMove = allow;
	}

	public bool IsFocusing()
	{
		return focusing;
	}
}
