using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/Factory/OrderUI", true)]
[FloatingDepth(0)]
public class InGameOrderUI : InGameFloatingUI
{
	[SerializeField]
	private Button Btn;

	public Action clickAction;

	public override void Init(Transform parent, GameType type = GameType.Factory)
	{
	}

	private void Awake()
	{
	}

	private void OnClickBtn()
	{
	}
}
