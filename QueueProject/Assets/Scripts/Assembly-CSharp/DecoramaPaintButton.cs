using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class DecoramaPaintButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[SerializeField]
	private Text m_paintPointsCurrencyText;

	private bool m_buttonPressed;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}

	private void UpdatePaintPointCurrency()
	{
	}

	private void DecoramaEvents_OnDecoramaUpdatedEvent(Decorama visibleDecorama)
	{
	}
}
