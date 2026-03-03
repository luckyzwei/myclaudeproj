using UnityEngine;

public class OfficePlant : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer plantSprite;

	private InGamePlantRewardUI RewardUI;

	public int CurIdx { get; private set; }

	public void Init(int idx)
	{
	}

	public void Show()
	{
	}
}
