using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControlPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	private static ControlPad s_instance;

	private static bool s_disableControlPad;

	public static event DecoramaEvents.BasicDelegate PointerDown
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event DecoramaEvents.BasicDelegate PointerUp
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

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

	public static void DisableControlPad()
	{
	}

	public static bool IsDisabled()
	{
		return false;
	}

	private void Start()
	{
	}

	private void DisablePad()
	{
	}

	private void Update()
	{
	}
}
