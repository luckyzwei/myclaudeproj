using Balancy.Models.SmartObjects;
using UnityEngine;
using UnityEngine.UI;

public class LeagueRewardWidget : MonoBehaviour
{
	[SerializeField]
	protected GameObject m_rewardGroup;

	[SerializeField]
	protected Text m_rewardTMP;

	[Header("optional")]
	[SerializeField]
	protected Image m_rewardIcon;

	public void Configure(Reward reward)
	{
	}

	protected virtual void ConfigureWithReward(Reward reward)
	{
	}
}
