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
	}

	public void SetToggle(bool on)
	{
	}

	private void SetObject(bool on)
	{
	}

	private void OnClickSwitch(bool on)
	{
	}
}
