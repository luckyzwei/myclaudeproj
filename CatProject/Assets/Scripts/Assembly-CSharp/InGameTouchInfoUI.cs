using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/TouchInfoUI", true)]
[FloatingDepth(1)]
public class InGameTouchInfoUI : InGameFloatingUI
{
	[SerializeField]
	private Button uiBtn;

	public Action BtnCb;

	private void Awake()
	{
		// Initialize
	}

	public override void Init(Transform parent, GameType type = GameType.House)
	{
		base.Init(parent, type);
	}
}
