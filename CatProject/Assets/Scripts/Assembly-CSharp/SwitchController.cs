using System;
using UnityEngine;
using UnityEngine.UI;

public class SwitchController : MonoBehaviour
{
	[SerializeField]
	private Toggle switchToggle;

	public GameObject[] onIcon;

	public GameObject[] offIcon;

	public Action onClick;

	private bool skipEventTrigger;

	private void Awake()
	{
		if (switchToggle != null) switchToggle.onValueChanged.AddListener(OnClickSwitch);
	}

	public void SetToggle(bool on)
	{
		skipEventTrigger = true;
		if (switchToggle != null) switchToggle.isOn = on;
		SetObject(on);
		skipEventTrigger = false;
	}

	private void SetObject(bool on)
	{
		if (onIcon != null)
		{
			for (int i = 0; i < onIcon.Length; i++)
				if (onIcon[i] != null) onIcon[i].SetActive(on);
		}
		if (offIcon != null)
		{
			for (int i = 0; i < offIcon.Length; i++)
				if (offIcon[i] != null) offIcon[i].SetActive(!on);
		}
	}

	private void OnClickSwitch(bool on)
	{
		if (skipEventTrigger) return;
		SetObject(on);
		onClick?.Invoke();
	}
}
