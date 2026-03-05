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
		if (Btn != null)
			Btn.onClick.AddListener(OnClickGetReward);
	}

	public override void Init(Transform parent, GameType type = GameType.Main)
	{
		base.Init(parent, type);
	}

	public void Set(int plant)
	{
		PlantIdx = plant;
		UpdateLevel();
	}

	private void UpdateLevel()
	{
		if (EnableGetObj != null)
			EnableGetObj.SetActive(false);
		if (RewardTimeProgress != null)
			RewardTimeProgress.value = 0f;
	}

	private void OnClickGetReward()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.PlantSystem?.GetGemReward(PlantIdx, transform.position);
	}
}
