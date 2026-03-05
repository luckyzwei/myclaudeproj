using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemTarotCard : MonoBehaviour
{
	public enum AniClip
	{
		None = -1,
		Idle = 0,
		Open = 1,
		Change = 2,
		Reverse = 3
	}

	[Header("ItemTarotCard")]
	[SerializeField]
	private Button CardBtn;

	[SerializeField]
	private Animator CardAnimator;

	[SerializeField]
	private GameObject SpecialObj;

	[Space(10f)]
	[SerializeField]
	private Image RewardIcon;

	[SerializeField]
	private Text RewardCountText;

	[SerializeField]
	private GameObject RewardCheckObj;

	[SerializeField]
	private GameObject RewardOwnBubble;

	[SerializeField]
	private GameObject RewardInfoBtn;

	[SerializeField]
	private GameObject RewardInfoBubble;

	[SerializeField]
	private Text RewardInfoBubbleText;

	private Action<ItemTarotCard> ClickCB;

	public int Idx { get; private set; }

	public bool IsSpecial { get; private set; }

	private void Awake()
	{
		if (CardBtn != null)
			CardBtn.onClick.AddListener(() => ClickCB?.Invoke(this));
	}

	public void SetCard(int tarotIdx, bool isSpecial = false, bool updateCard = true, Action<ItemTarotCard> cb = null)
	{
		Idx = tarotIdx;
		IsSpecial = isSpecial;
		ClickCB = cb;
		if (SpecialObj != null)
			SpecialObj.SetActive(isSpecial);
		if (updateCard)
			UpdateCard();
	}

	public void UpdateCard()
	{
		// Update card display from tarot data table by Idx
		if (RewardCheckObj != null)
			RewardCheckObj.SetActive(false);
		if (RewardOwnBubble != null)
			RewardOwnBubble.SetActive(false);
		if (RewardInfoBubble != null)
			RewardInfoBubble.SetActive(false);
	}

	public void PlayAnimation(AniClip ani)
	{
		if (CardAnimator == null) return;
		switch (ani)
		{
			case AniClip.Idle: CardAnimator.Play("Idle"); break;
			case AniClip.Open: CardAnimator.Play("Open"); break;
			case AniClip.Change: CardAnimator.Play("Change"); break;
			case AniClip.Reverse: CardAnimator.Play("Reverse"); break;
		}
	}

	public void SetRewardCheck()
	{
		if (RewardCheckObj != null)
			RewardCheckObj.SetActive(true);
	}

	public void OnClickInfo()
	{
		if (RewardInfoBubble != null)
			RewardInfoBubble.SetActive(!RewardInfoBubble.activeSelf);
	}
}
