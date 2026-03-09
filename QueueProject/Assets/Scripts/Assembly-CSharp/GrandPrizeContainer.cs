using System.Runtime.InteropServices;
using Balancy.Models.SmartObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GrandPrizeContainer : MonoBehaviour
{
	[SerializeField]
	private Image m_bar;

	[SerializeField]
	private TMP_Text m_progressText;

	[SerializeField]
	private RewardWidget m_rewardWidget;

	[SerializeField]
	private GameObject m_collectedOverlay;

	[SerializeField]
	private bool m_doAnimateProgressBar;

	[SerializeField]
	private LayoutElement m_collectionHeaderLayoutElement;

	private int m_total;

	private int m_current;

	private const int CLAIMED_LAYOUT_GROUP_HEIGHT = 530;

	public void Config(Reward prize, int total, int current)
	{
	}

	public void ConfigureRewardWidget(Reward reward)
	{
	}

	private void SetProgressBar([Optional] bool? overrideAnim)
	{
	}

	public void GotPoint()
	{
	}

	public void SetCurrentPoint(int pts)
	{
	}

	public void AnimEvent_OnClaimed()
	{
	}
}
