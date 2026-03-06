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
		// Update display
	}

	public void SetHighlight(bool isHighlighted)
	{
		if (HighlightFxObj != null)
			HighlightFxObj.SetActive(isHighlighted);
		if (HighlightDoTweenList != null)
		{
			for (int i = 0; i < HighlightDoTweenList.Count; i++)
			{
				if (HighlightDoTweenList[i] != null)
				{
					if (isHighlighted)
						HighlightDoTweenList[i].Play();
					else
						HighlightDoTweenList[i].gameObject.SetActive(false);
				}
			}
		}
	}

	public void SetRewardedFx(bool isActive)
	{
		if (RewardedFxObj != null)
			RewardedFxObj.SetActive(isActive);
	}
}
