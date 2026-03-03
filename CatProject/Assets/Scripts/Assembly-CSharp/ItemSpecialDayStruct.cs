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

	public int Idx => 0;

	public List<ItemOnetimeFloor> ItemOnetimeFloors => null;

	public List<DoTweenScriptComponent> FloorDoTweens => null;

	public float CharacterTerm => 0f;

	public Transform ExitT => null;

	public ParticleSystem CurrencyParticle => null;

	public void UpdateRewards()
	{
	}

	public void UpdateBtns()
	{
	}

	public void HideInfoBubbles()
	{
	}

	public void PlayCharacterAnimation(string clipName)
	{
	}

	public ItemOnetimeReward GetLastRewardItem()
	{
		return null;
	}
}
