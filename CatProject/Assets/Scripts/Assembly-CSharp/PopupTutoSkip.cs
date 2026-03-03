using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupTutoSkip", false, false)]
public class PopupTutoSkip : UIBase
{
	[SerializeField]
	private Button SkipBtn;

	[SerializeField]
	private Button CancelBtn;

	public Action SkipAction;

	protected override void Awake()
	{
	}

	private void OnClickSkip()
	{
	}
}
