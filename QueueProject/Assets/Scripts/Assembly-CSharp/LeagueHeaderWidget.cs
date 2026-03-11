using Balancy.Models.KWLeaderboard;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class LeagueHeaderWidget : MonoBehaviour
{
	[SerializeField]
	private Image m_headerIcon;

	[SerializeField]
	private UnityEngine.UI.Extensions.Gradient m_headerBackGradient;

	[SerializeField]
	private Text m_headerTitleText;

	public void Configure(LeagueDataConfig leagueData)
	{
	}

	public void OnLeaguedHelpPressed()
	{
	}
}
