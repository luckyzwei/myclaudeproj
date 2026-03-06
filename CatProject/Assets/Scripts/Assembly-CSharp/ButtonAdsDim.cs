using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAdsDim : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
{
	public void OnPointerDown(PointerEventData e)
	{
		transform.localScale = Vector3.one * 0.95f;
	}

	public void OnPointerUp(PointerEventData e)
	{
		transform.localScale = Vector3.one;
	}

	public void OnPointerClick(PointerEventData e)
	{
	}

	private void Start()
	{
		CB_AdRewarded(false);
	}

	private void OnEnable()
	{
		CB_AdRewarded(false);
	}

	private void OnDestroy()
	{
	}

	private void CB_AdRewarded(bool isAdReady)
	{
		var canvasGroup = GetComponent<CanvasGroup>();
		if (canvasGroup != null)
		{
			canvasGroup.alpha = isAdReady ? 1f : 0.5f;
			canvasGroup.interactable = isAdReady;
		}
	}
}
