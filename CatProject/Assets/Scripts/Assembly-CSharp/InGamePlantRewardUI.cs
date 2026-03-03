using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/PlantRewardUI", true)]
[FloatingDepth(4)]
public class InGamePlantRewardUI : InGameFloatingUI
{
	[SerializeField]
	private Text RewardCount;

	[SerializeField]
	private Slider RewardTimeProgress;

	[SerializeField]
	private Button Btn;

	[SerializeField]
	private GameObject EnableGetObj;

	private int PlantIdx;

	private int MaxCooltime;

	private void Awake()
	{
	}

	public override void Init(Transform parent, GameType type = GameType.Main)
	{
	}

	public void Set(int plant)
	{
	}

	private void UpdateLevel()
	{
	}

	private void OnClickGetReward()
	{
	}
}
