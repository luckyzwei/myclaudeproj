using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupUpdate", false, false)]
public class PopupUpdate : UIBase
{
	[SerializeField]
	private Button hideBtn;

	[SerializeField]
	private Button updateBtn;

	[SerializeField]
	private Text gemText;

	private Action<bool> action;

	protected override void Awake()
	{
	}

	public void Init(Action<bool> _action, bool isHardUpdate = false)
	{
	}

	private void GoUpdate()
	{
	}

	private void OnClickHide()
	{
	}
}
