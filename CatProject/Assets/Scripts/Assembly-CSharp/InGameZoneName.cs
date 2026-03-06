using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/OutGame/ZoneNameUI", true)]
[FloatingDepth(12)]
public class InGameZoneName : InGameFloatingUI, ILocalizeRefresh
{
	[SerializeField]
	private Text Name;

	private int curZoneIdx;

	public override void Init(Transform parent, GameType type = GameType.WorldMap)
	{
		base.Init(parent, type);
	}

	public void Set(int zoneIdx)
	{
		curZoneIdx = zoneIdx;
		RefreshText();
	}

	public void RefreshText()
	{
		// Update display
	}

	private void OnDestroy()
	{
		// Cleanup
	}
}
