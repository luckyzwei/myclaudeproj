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

	public void SetCameraZoom(float value)
	{
	}

	public void SetCameraBoundMinY(float value)
	{
	}

	public void SetCameraBoundMaxY(float value)
	{
	}

	public void SetCameraBound(float min_x, float min_y, float max_x, float max_y)
	{
	}

	public virtual void Load()
	{
	}

	public virtual void UnLoad()
	{
	}

	protected virtual void LoadUI()
	{
	}

	protected virtual void UnLoadUI()
	{
	}
}
