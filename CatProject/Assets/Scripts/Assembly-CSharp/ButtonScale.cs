using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonScale : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
	public Transform tweenTarget;

	public Vector3 pressed;

	public float duration;

	private Vector3 mScale;

	private bool isInit;

	private bool isPress;

	private Button button;

	private TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore;

	private void Awake()
	{
		if (tweenTarget == null)
			tweenTarget = transform;
		button = GetComponent<Button>();
		InitScale();
	}

	private void OnDisable()
	{
		if (isInit && tweenTarget != null)
		{
			if (tweenerCore != null)
			{
				tweenerCore.Kill();
				tweenerCore = null;
			}
			tweenTarget.localScale = mScale;
		}
		isPress = false;
	}

	private void InitScale()
	{
		if (isInit) return;
		isInit = true;
		if (tweenTarget != null)
			mScale = tweenTarget.localScale;
		if (pressed == Vector3.zero)
			pressed = new Vector3(0.9f, 0.9f, 0.9f);
		if (duration <= 0f)
			duration = 0.1f;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (button != null && !button.interactable) return;
		isPress = true;
		StartAni(true);
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		if (!isPress) return;
		isPress = false;
		StartAni(false);
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		// TODO
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		if (!isPress) return;
		isPress = false;
		StartAni(false);
	}

	private void StartAni(bool down = true)
	{
		InitScale();
		if (tweenTarget == null) return;

		if (tweenerCore != null)
		{
			tweenerCore.Kill();
			tweenerCore = null;
		}

		Vector3 targetScale = down ? Vector3.Scale(mScale, pressed) : mScale;
		tweenerCore = tweenTarget.DOScale(targetScale, duration).SetUpdate(true);
	}
}
