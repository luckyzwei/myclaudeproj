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
		// Handled by button click listener
	}

	private void Start()
	{
		CB_AdRewarded(false);
	}

	private void OnEnable()
	{
		// Subscribe to ad ready state changes
	}

	private void OnDestroy()
	{
		// Unsubscribe from ad ready state changes
	}

	private void CB_AdRewarded(bool isAdReady)
	{
		// Dim the button when ads are not ready
		var canvasGroup = GetComponent<CanvasGroup>();
		if (canvasGroup != null)
		{
			canvasGroup.alpha = isAdReady ? 1f : 0.5f;
			canvasGroup.interactable = isAdReady;
		}
	}
}
