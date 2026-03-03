using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemRichWay : MonoBehaviour
{
	[SerializeField]
	private Image rewardIcon;

	[SerializeField]
	private Text rewardCountText;

	[SerializeField]
	private Text missionText;

	[SerializeField]
	private Slider progressSlider;

	[SerializeField]
	private Text progressText;

	[SerializeField]
	private Button rewardBtn;

	[SerializeField]
	private GameObject Reddot;

	[SerializeField]
	private Button shortcutBtn;

	[SerializeField]
	private GameObject lockObj;

	[SerializeField]
	private GameObject completeObj;

	private Coroutine unlockCoroutine;

	private Action CompLevelAction;

	public int MissionIdx { get; private set; }

	private void Awake()
	{
	}

	public void Set(int missionIdx, Action compLevelAction)
	{
	}

	public void UpdateStatus(bool init = false)
	{
	}

	private void OnClickReward()
	{
	}

	private void OnClickShortcut()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
