using System;
using System.Runtime.CompilerServices;
using SuperBlur;
using UnityEngine;

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

	public bool IsZoomOutOver { get { return false; } }

	public float ZoomSize { get { return 0f; } }

	public bool isTouching { get; private set; }

	public Vector2 touchPosition { get { return default(Vector2); } }

	public Vector3 DefaltCenter { get; private set; }

	public event Action<Vector2> onStartTouch
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Vector2> onEndTouch
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Vector2> onSwipe
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<float, float> onPinch
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void UpdateBound()
	{
	}

	public void SetFixX()
	{
	}

	private void Update()
	{
	}

	private float EvaluateAutoScrollDampCurve(float t)
	{
		return 0f;
	}

	private void UpdateWithMouse()
	{
	}

	private void CheckMoveTarget(Vector2 input, bool touch = false)
	{
	}

	private void UpdateWithTouch()
	{
	}

	private void OnClick(Vector2 position)
	{
	}

	private void OnSwipe(Vector2 deltaPosition)
	{
	}

	public void CameraZoom(Vector3 worldCenter, float zoomSize)
	{
	}

	private void OnPinch(Vector2 center, float oldDistance, float newDistance, Vector2 touchDelta)
	{
	}

	public bool IsPointerOverUIObject(Vector2 touchPosition)
	{
		return false;
	}

	public Vector2 RandomPointInBounds()
	{
		return default(Vector2);
	}

	public bool IsClickInGameObject(Vector2 touchPosition)
	{
		return false;
	}

	public void SetCameraZoom(float focusSize)
	{
	}

	public void FocusPositionImmediately(Vector3 worldPos, float _focusSize = 15f)
	{
	}

	public void FocusPosition(Vector3 worldPos, float _focusSize = 15f, bool isbackup = true)
	{
	}

	public void FollowCameraPos(Transform worldTrans, float _focusSize = 15f, FollowType _followType = FollowType.All)
	{
	}

	public void EndFollow()
	{
	}

	public void FocusOutBackup()
	{
	}

	public void FocusOut()
	{
	}

	public void FocusOrigin()
	{
	}

	public void CancelCamera()
	{
	}

	private void CameraInBounds()
	{
	}

	public Texture2D TakeScreenShot(bool _blur = true)
	{
		return null;
	}

	public void SetAllowMove(bool allow)
	{
	}

	public bool IsFocusing()
	{
		return false;
	}
}
