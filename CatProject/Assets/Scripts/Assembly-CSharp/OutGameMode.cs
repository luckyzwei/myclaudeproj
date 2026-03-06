using UnityEngine;

public abstract class OutGameMode : MonoBehaviour, IInGameMode
{
	[SerializeField]
	private PanAndZoom ingameCamera;

	[SerializeField]
	private float zoomTime;

	private float deletaTimeZoom;

	private bool zoomOut;

	[HideInInspector]
	public GameType Type { get; protected set; }

	public PanAndZoom IngameCamera { get { return ingameCamera; } }

	public Camera MainCamera { get { return ingameCamera != null ? ingameCamera.cam : null; } }

	public float CamPixelWidth { get; private set; }

	public float CamPixelHeight { get; private set; }

	private void Awake()
	{
		if (ingameCamera != null && ingameCamera.cam != null)
		{
			CamPixelWidth = ingameCamera.cam.pixelWidth;
			CamPixelHeight = ingameCamera.cam.pixelHeight;
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

	public void SetCameraZoom(float value)
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

	public void SetCameraBound(float min_x, float min_y, float max_x, float max_y)
	{
		if (ingameCamera != null)
		{
			ingameCamera.boundMinX = min_x;
			ingameCamera.boundMinY = min_y;
			ingameCamera.boundMaxX = max_x;
			ingameCamera.boundMaxY = max_y;
		}
	}

	public virtual void Load()
	{
		LoadUI();
	}

	public virtual void UnLoad()
	{
		UnLoadUI();
	}

	protected virtual void LoadUI()
	{
		// Virtual base - override in subclass
	}

	protected virtual void UnLoadUI()
	{
		// Virtual base - override in subclass
	}
}
