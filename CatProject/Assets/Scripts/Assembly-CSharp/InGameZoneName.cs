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
	}

	public void Set(int zoneIdx)
	{
	}

	public void RefreshText()
	{
	}

	private void OnDestroy()
	{
	}
}
