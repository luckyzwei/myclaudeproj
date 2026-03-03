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
	}

	public void SetCard(int tarotIdx, bool isSpecial = false, bool updateCard = true, Action<ItemTarotCard> cb = null)
	{
	}

	public void UpdateCard()
	{
	}

	public void PlayAnimation(AniClip ani)
	{
	}

	public void SetRewardCheck()
	{
	}

	public void OnClickInfo()
	{
	}
}
