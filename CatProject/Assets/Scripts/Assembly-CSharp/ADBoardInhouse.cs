using UnityEngine;

public class ADBoardInhouse : MonoBehaviour
{
	[SerializeField]
	private Config.E_INHOUSE_RESERVATION InHouseType;

	[SerializeField]
	private SpriteRenderer ADBoardSprite;

	private void Awake()
	{
		Init();
	}

	private void Init()
	{
		// Resource loading for ad board sprite - keep empty
	}

	public void OnClick()
	{
		if (InHouseType == Config.E_INHOUSE_RESERVATION.None) return;
		CrossPromotionHelper.CheckPossibleClaimReward(InHouseType);
	}
}
