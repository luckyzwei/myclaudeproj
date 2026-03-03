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
	}

	private void OnDisable()
	{
	}

	private void InitScale()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void StartAni(bool down = true)
	{
	}
}
