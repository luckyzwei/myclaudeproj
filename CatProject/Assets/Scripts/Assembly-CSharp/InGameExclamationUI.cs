using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/ExclamationUI", true)]
[FloatingDepth(1)]
public class InGameExclamationUI : InGameFloatingUI
{
	[SerializeField]
	private Button Btn;

	public Action clickAction;

	private void Awake()
	{
		if (Btn != null)
			Btn.onClick.AddListener(OnClickBtn);
	}

	private void OnClickBtn()
	{
		clickAction?.Invoke();
	}
}
