using System.Collections.Generic;
using UnityEngine;

public class SeasonalCoinRankReward : MonoBehaviour
{
	[SerializeField]
	private List<ItemArticle> Reward1st;

	[SerializeField]
	private List<ItemArticle> Reward2nd;

	[SerializeField]
	private List<ItemArticle> Reward3rd;

	[SerializeField]
	private List<ItemArticle> Reward4thEtc;

	private void Awake()
	{
	}
}
