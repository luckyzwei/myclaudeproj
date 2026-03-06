using System.Collections.Generic;
using UnityEngine;

public class ItemSpecialDayStruct : MonoBehaviour
{
	[Header("ItemSpecialDayStruct")]
	[SerializeField]
	private int idx;

	[Header("Floor")]
	[SerializeField]
	private List<ItemOnetimeFloor> itemOnetimeFloors;

	[SerializeField]
	private List<DoTweenScriptComponent> floorDoTweens;

	[Header("Reward")]
	[SerializeField]
	private ItemOnetimeReward[] RewardItems;

	[Header("Characters")]
	[SerializeField]
	private Animator CharactersAnimator;

	[SerializeField]
	private float characterTerm;

	[SerializeField]
	private Transform exitT;

	[Header("Currecny Particle")]
	[SerializeField]
	private ParticleSystem currencyParticle;

	public int Idx { get { return idx; } }

	public List<ItemOnetimeFloor> ItemOnetimeFloors { get { return itemOnetimeFloors; } }

	public List<DoTweenScriptComponent> FloorDoTweens { get { return floorDoTweens; } }

	public float CharacterTerm { get { return characterTerm; } }

	public Transform ExitT { get { return exitT; } }

	public ParticleSystem CurrencyParticle { get { return currencyParticle; } }

	public void UpdateRewards()
	{
		if (RewardItems == null) return;
		for (int i = 0; i < RewardItems.Length; i++)
		{
			if (RewardItems[i] != null)
				RewardItems[i].gameObject.SetActive(true);
		}
	}

	public void UpdateBtns()
	{
		if (RewardItems == null) return;
		for (int i = 0; i < RewardItems.Length; i++)
		{
			if (RewardItems[i] != null)
				RewardItems[i].UpdateBtn();
		}
	}

	public void HideInfoBubbles()
	{
		if (RewardItems == null) return;
		for (int i = 0; i < RewardItems.Length; i++)
		{
			if (RewardItems[i] != null)
				RewardItems[i].HideAllBubble();
		}
	}

	public void PlayCharacterAnimation(string clipName)
	{
		if (CharactersAnimator != null)
			CharactersAnimator.Play(clipName);
	}

	public ItemOnetimeReward GetLastRewardItem()
	{
		if (RewardItems == null || RewardItems.Length == 0) return null;
		return RewardItems[RewardItems.Length - 1];
	}
}
