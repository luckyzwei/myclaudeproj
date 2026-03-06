using UnityEngine;

public abstract class InGameMode : MonoBehaviour, IInGameMode
{
	[SerializeField]
	private PanAndZoom ingameCamera;

	[SerializeField]
	private float zoomTime;

	private float deletaTimeZoom;

	private bool zoomOut;

	public PanAndZoom IngameCamera { get { return ingameCamera; } }

	public Camera MainCamera { get { return ingameCamera != null ? ingameCamera.GetComponent<Camera>() : null; } }

	public float CamPixelWidth { get; private set; }

	public float CamPixelHeight { get; private set; }

	private void Awake()
	{
		if (ingameCamera != null)
		{
			var cam = ingameCamera.GetComponent<Camera>();
			if (cam != null)
			{
				CamPixelWidth = cam.pixelWidth;
				CamPixelHeight = cam.pixelHeight;
			}
		}
	}

	protected virtual void Update()
	{
		if (zoomOut && ingameCamera != null)
		{
			deletaTimeZoom += Time.deltaTime;
			if (deletaTimeZoom >= zoomTime)
			{
				zoomOut = false;
			}
		}
	}

	public void InitCameraZoom(float value)
	{
		if (ingameCamera != null)
			ingameCamera.SetCameraZoom(value);
	}

	public void SetCameraBoundMinY(float value)
	{
		if (ingameCamera != null)
			ingameCamera.boundMinY = value;
	}

	public void SetCameraBoundMaxY(float value)
	{
		if (ingameCamera != null)
			ingameCamera.boundMaxY = value;
	}

	public void InitCameraBound(float min_x, float min_y, float max_x, float max_y)
	{
		if (ingameCamera != null)
		{
			ingameCamera.boundMinX = min_x;
			ingameCamera.boundMinY = min_y;
			ingameCamera.boundMaxX = max_x;
			ingameCamera.boundMaxY = max_y;
		}
	}

	public void SetCameraZoom(float value)
	{
		if (ingameCamera != null)
		{
			ingameCamera.SetCameraZoom(value);
			deletaTimeZoom = 0f;
			zoomOut = true;
		}
	}

	public virtual void Load()
	{
		// Virtual base - override in subclass
	}

	public virtual void UnLoad()
	{
		// Virtual base - override in subclass
	}

	public virtual void LoadUI()
	{
		// Virtual base - override in subclass
	}

	public virtual void UnLoadUI()
	{
		// Virtual base - override in subclass
	}
}
