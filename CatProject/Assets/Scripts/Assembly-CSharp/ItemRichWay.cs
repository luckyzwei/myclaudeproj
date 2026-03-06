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
		if (rewardBtn != null) rewardBtn.onClick.AddListener(OnClickReward);
		if (shortcutBtn != null) shortcutBtn.onClick.AddListener(OnClickShortcut);
	}

	public void Set(int missionIdx, Action compLevelAction)
	{
		MissionIdx = missionIdx;
		CompLevelAction = compLevelAction;
		UpdateStatus(true);
	}

	public void UpdateStatus(bool init = false)
	{
		if (lockObj != null) lockObj.SetActive(false);
		if (completeObj != null) completeObj.SetActive(false);
		if (Reddot != null) Reddot.SetActive(false);

		if (progressSlider != null) progressSlider.value = 0f;
		if (progressText != null) progressText.text = "0/0";
	}

	private void OnClickReward()
	{
		CompLevelAction?.Invoke();
	}

	private void OnClickShortcut()
	{
		// Navigate to mission target
	}

	private void OnDestroy()
	{
		if (unlockCoroutine != null)
		{
			StopCoroutine(unlockCoroutine);
			unlockCoroutine = null;
		}
	}

	private void OnDisable()
	{
		if (unlockCoroutine != null)
		{
			StopCoroutine(unlockCoroutine);
			unlockCoroutine = null;
		}
	}
}
