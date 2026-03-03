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
	}

	public void SetActiveExpFx(bool isActive)
	{
	}

	private void SetActiveSelf()
	{
	}
}
