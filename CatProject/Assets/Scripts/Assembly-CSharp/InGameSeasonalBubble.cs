using Treeplla;
using UnityEngine;

[FloatUIPath("UI/InGame/Seasonal/InGameSeasonalBubble", true)]
[FloatingDepth(10)]
public class InGameSeasonalBubble : InGameFloatingUI
{
	private void Awake()
	{
		// Initialize
	}

	public override void Init(Transform parent, GameType type = GameType.Main)
	{
		base.Init(parent, type);
	}

	private void OnClickBtn()
	{
		Hide();
	}
}
