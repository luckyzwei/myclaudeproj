using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSquareRoulette : MonoBehaviour
{
	[Header("Reward")]
	[SerializeField]
	private List<Image> RewardImage;

	[SerializeField]
	private List<Text> RewardCountText;

	[Header("Effect")]
	[SerializeField]
	private GameObject HighlightFxObj;

	[SerializeField]
	private List<DoTweenScriptComponent> HighlightDoTweenList;

	[SerializeField]
	private GameObject RewardedFxObj;

	public void SetReward(int specialDayRouletteIdx)
	{
	}

	public void SetHighlight(bool isHighlighted)
	{
	}

	public void SetRewardedFx(bool isActive)
	{
	}
}
