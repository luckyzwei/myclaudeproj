using UnityEngine;

public class KPFGameLossAnalytics : MonoBehaviour
{
	private const string KPF_GAMELOSS_POPUP_OPENED = "kpf_game_loss_pop_up";

	private const string KPF_GAMELOSS_POPUP_CLOSED = "kpf_game_loss_pop_up_closed";

	public const string CLOSE_CONTEXT_REVIVE = "revive";

	public const string CLOSE_CONTEXT_GIVEUP = "give_up";

	private static float m_duration;

	private TapTracker m_tapTracker;

	private void Awake()
	{
	}

	public void SendGameLossOpenAnalytics(string context, string options)
	{
	}

	public void SendGameLossClosedAnalytics(string contextLoss, string contextClose)
	{
	}
}
