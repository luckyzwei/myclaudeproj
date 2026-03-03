using System;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
	public enum dir
	{
		leftOn = 0,
		rightOn = 1
	}

	public Color onColorBg;

	public Color offColorBg;

	public Image toggleBgImage;

	public RectTransform toggle;

	public Button toggleBtn;

	public GameObject handle;

	private RectTransform handleTransform;

	private float handleSize;

	private float onPosX;

	private float offPosX;

	public float handleOffset;

	public GameObject[] onIcon;

	public GameObject[] offIcon;

	public float speed;

	private static float t;

	public dir direction;

	private bool switching;

	private Action<bool> clickAction;

	public bool IsOn { get; private set; }

	private void Awake()
	{
	}

	public void Init(bool status)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void setToggleListener(Action<bool> toggleAction)
	{
	}

	public void DoYourStaff()
	{
	}

	public void Switching()
	{
	}

	public void ForceSet(bool isOn)
	{
	}

	public void Toggle(bool toggleStatus)
	{
	}

	private Vector3 SmoothMove(GameObject toggleHandle, float startPosX, float endPosX)
	{
		return default(Vector3);
	}

	private Color SmoothColor(Color startCol, Color endCol)
	{
		return default(Color);
	}

	private CanvasGroup Transparency(GameObject alphaObj, float startAlpha, float endAlpha)
	{
		return null;
	}

	private void StopSwitching()
	{
	}
}
