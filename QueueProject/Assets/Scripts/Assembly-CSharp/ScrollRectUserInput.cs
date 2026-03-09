using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ScrollRectUserInput : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	public UnityEvent OnBeginDragEvent;

	public UnityEvent OnEndDragEvent;

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}
}
