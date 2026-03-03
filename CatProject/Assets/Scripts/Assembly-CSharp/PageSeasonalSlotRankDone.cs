using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/Page/PageSeasonalSlotRankDone", false, false)]
public class PageSeasonalSlotRankDone : UIBase
{
	[SerializeField]
	private Image imgRankIcon;

	[SerializeField]
	private Text textRank;

	[SerializeField]
	private List<ItemArticle> listRewards;

	public void Set(int Rank)
	{
	}
}
