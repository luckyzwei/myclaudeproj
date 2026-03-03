using UnityEngine;

public abstract class InGameMode : MonoBehaviour, IInGameMode
{
	[SerializeField]
	private PanAndZoom ingameCamera;

	[SerializeField]
	private float zoomTime;

	private float deletaTimeZoom;

	private bool zoomOut;

	public PanAndZoom IngameCamera => null;

	public Camera MainCamera => null;

	public float CamPixelWidth { get; private set; }

	public float CamPixelHeight { get; private set; }

	private void Awake()
	{
	}

	protected virtual void Update()
	{
	}

	public void InitCameraZoom(float value)
	{
	}

	public void SetCameraBoundMinY(float value)
	{
	}

	public void SetCameraBoundMaxY(float value)
	{
	}

	public void InitCameraBound(float min_x, float min_y, float max_x, float max_y)
	{
	}

	public void SetCameraZoom(float value)
	{
	}

	public virtual void Load()
	{
	}

	public virtual void UnLoad()
	{
	}

	public virtual void LoadUI()
	{
	}

	public virtual void UnLoadUI()
	{
	}
}
