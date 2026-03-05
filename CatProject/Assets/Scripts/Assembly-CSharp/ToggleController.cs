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
		handleTransform = handle != null ? handle.GetComponent<RectTransform>() : null;
		if (handleTransform != null)
			handleSize = RectTransformUtility.PixelAdjustRect(handleTransform, GetComponentInParent<Canvas>()).width;
	}

	public void Init(bool status)
	{
		IsOn = status;
		if (handleTransform == null && handle != null)
			handleTransform = handle.GetComponent<RectTransform>();

		float toggleWidth = toggle != null ? toggle.sizeDelta.x : 100f;
		if (direction == dir.leftOn)
		{
			onPosX = -((toggleWidth / 2f) - (handleSize / 2f) - handleOffset);
			offPosX = (toggleWidth / 2f) - (handleSize / 2f) - handleOffset;
		}
		else
		{
			onPosX = (toggleWidth / 2f) - (handleSize / 2f) - handleOffset;
			offPosX = -((toggleWidth / 2f) - (handleSize / 2f) - handleOffset);
		}
		Toggle(status);
	}

	private void Start()
	{
		if (toggleBtn != null)
			toggleBtn.onClick.AddListener(Switching);
	}

	private void Update()
	{
		if (!switching) return;
		float targetX = IsOn ? onPosX : offPosX;
		Color targetColor = IsOn ? onColorBg : offColorBg;
		if (handle != null)
			handle.transform.localPosition = SmoothMove(handle, handle.transform.localPosition.x, targetX);
		if (toggleBgImage != null)
			toggleBgImage.color = SmoothColor(toggleBgImage.color, targetColor);
		if (Mathf.Abs(handle.transform.localPosition.x - targetX) < 0.5f)
			StopSwitching();
	}

	public void setToggleListener(Action<bool> toggleAction)
	{
		clickAction = toggleAction;
	}

	public void DoYourStaff()
	{
		clickAction?.Invoke(IsOn);
	}

	public void Switching()
	{
		IsOn = !IsOn;
		t = 0f;
		switching = true;
		if (onIcon != null) foreach (var icon in onIcon) if (icon != null) icon.SetActive(IsOn);
		if (offIcon != null) foreach (var icon in offIcon) if (icon != null) icon.SetActive(!IsOn);
		DoYourStaff();
	}

	public void ForceSet(bool isOn)
	{
		IsOn = isOn;
		Toggle(isOn);
	}

	public void Toggle(bool toggleStatus)
	{
		IsOn = toggleStatus;
		float posX = IsOn ? onPosX : offPosX;
		if (handle != null)
			handle.transform.localPosition = new Vector3(posX, 0f, 0f);
		if (toggleBgImage != null)
			toggleBgImage.color = IsOn ? onColorBg : offColorBg;
		if (onIcon != null) foreach (var icon in onIcon) if (icon != null) icon.SetActive(IsOn);
		if (offIcon != null) foreach (var icon in offIcon) if (icon != null) icon.SetActive(!IsOn);
	}

	private Vector3 SmoothMove(GameObject toggleHandle, float startPosX, float endPosX)
	{
		t += speed * Time.deltaTime;
		float x = Mathf.Lerp(startPosX, endPosX, t);
		return new Vector3(x, 0f, 0f);
	}

	private Color SmoothColor(Color startCol, Color endCol)
	{
		return Color.Lerp(startCol, endCol, t);
	}

	private CanvasGroup Transparency(GameObject alphaObj, float startAlpha, float endAlpha)
	{
		if (alphaObj == null) return null;
		var cg = alphaObj.GetComponent<CanvasGroup>();
		if (cg == null) cg = alphaObj.AddComponent<CanvasGroup>();
		cg.alpha = Mathf.Lerp(startAlpha, endAlpha, t);
		return cg;
	}

	private void StopSwitching()
	{
		switching = false;
	}
}
