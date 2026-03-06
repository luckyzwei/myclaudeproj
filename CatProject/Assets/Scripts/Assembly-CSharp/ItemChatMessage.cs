using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemChatMessage : MonoBehaviour
{
	[Header("Audience")]
	[SerializeField]
	private GameObject AudienceRoot;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Text;

	[SerializeField]
	private GameObject MsgRoot;

	[SerializeField]
	private GameObject WritingObj;

	[SerializeField]
	private GameObject RewardRoot;

	[SerializeField]
	private Button RewardBtn;

	[SerializeField]
	private GameObject ReceivedObj;

	[Header("User")]
	[SerializeField]
	private GameObject UserRoot;

	[SerializeField]
	private Image UserIcon;

	[SerializeField]
	private Text UserText;

	public Action GetRewardAction;

	private int Group;

	private int Idx;

	private int Order;

	private void Awake()
	{
		if (RewardBtn != null) RewardBtn.onClick.AddListener(OnClickReward);
	}

	public void Set(int group, int idx, int order)
	{
		Group = group;
		Idx = idx;
		Order = order;
	}

	public void UpdateReward()
	{
		// Update display
	}

	public void ShowWriting(bool isShowWriting = true)
	{
		if (WritingObj != null) WritingObj.SetActive(isShowWriting);
		if (MsgRoot != null) MsgRoot.SetActive(!isShowWriting);
	}

	private void OnClickReward()
	{
		GetRewardAction?.Invoke();
	}
}
