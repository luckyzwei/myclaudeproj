using UnityEngine.UI;
using UnityEngine;

public class NoAdsDebug : MonoBehaviour
{
	private const string NO_ADS_LEFT = "No Ads Time Left: ";

	[SerializeField]
	private Text m_noAdsTMP;

	private void Awake()
	{
	}

	private void GameplayEvents_NoAdsTimeEnabledChanged(bool enable)
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
