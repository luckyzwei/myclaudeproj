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
		s_instance = this;
	}

	private void OnDestroy()
	{
		if (s_instance == this)
			s_instance = null;
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (s_disableControlPad) return;
		if (QueensInputController.Exist)
			QueensInputController.Instance.OnPointerDownFromControlPad();
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		if (QueensInputController.Exist)
			QueensInputController.Instance.OnPointerUpFromControlPad();
	}

	public static void DisableControlPad()
	{
		s_disableControlPad = true;
	}

	public static bool IsDisabled()
	{
		return s_disableControlPad;
	}

	private void Start()
	{
	}

	private void DisablePad()
	{
		s_disableControlPad = true;
	}

	private void Update()
	{
	}
}
