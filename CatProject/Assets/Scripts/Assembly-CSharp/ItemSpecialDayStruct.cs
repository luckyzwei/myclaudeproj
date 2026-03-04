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

	public int Idx { get { return 0; } }

	public List<ItemOnetimeFloor> ItemOnetimeFloors { get { return null; } }

	public List<DoTweenScriptComponent> FloorDoTweens { get { return null; } }

	public float CharacterTerm { get { return 0f; } }

	public Transform ExitT { get { return null; } }

	public ParticleSystem CurrencyParticle { get { return null; } }

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
