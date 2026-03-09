using UnityEngine;

public class HomeScreenAnalytics : MonoBehaviour
{
	private const string DECORAMA_START = "kpf_home_screen_start";

	private const string DECORAMA_END = "kpf_home_screen_end";

	[SerializeField]
	private TabToolbar m_tabToolbar;

	[SerializeField]
	private string[] m_analyticScreenIndexNames;

	private bool m_hasShown;

	private int m_startedIndex;

	private bool m_hasSentCloseEvent;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnTabChange(int tabindex, bool immediately)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void SendHomeScreenStartAnalytic(string context)
	{
	}

	private void SendHomeScreenEndAnalytic(string endContext)
	{
	}

	private static void SendHomeScreenAnalytics(string eventName, string context)
	{
	}

	public void OnStartGamePressed()
	{
	}
}
