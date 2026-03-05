using System.Collections.Generic;
using UnityEngine;

public class BoosterOfficeEffect : MonoBehaviour
{
	private static readonly string MONEY_SPRITE_NAME;

	[SerializeField]
	private GameObject ExpBoostObj;

	[SerializeField]
	private GameObject RentalFeeBoostObj;

	private List<SpriteRenderer> MoneyImages;

	private int CurRegion;

	public void SetActiveMoneyFx(bool isActive)
	{
		if (RentalFeeBoostObj != null) RentalFeeBoostObj.SetActive(isActive);
		SetActiveSelf();
	}

	public void SetActiveExpFx(bool isActive)
	{
		if (ExpBoostObj != null) ExpBoostObj.SetActive(isActive);
		SetActiveSelf();
	}

	private void SetActiveSelf()
	{
		bool anyActive = (ExpBoostObj != null && ExpBoostObj.activeSelf) ||
						 (RentalFeeBoostObj != null && RentalFeeBoostObj.activeSelf);
		gameObject.SetActive(anyActive);
	}
}
