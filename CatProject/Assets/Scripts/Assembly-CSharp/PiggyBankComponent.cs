using System;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class PiggyBankComponent : MonoBehaviour
{
	[SerializeField]
	private SkeletonGraphic PiggyAnim;

	[SerializeField]
	private GameObject IdleObj;

	[SerializeField]
	private GameObject FullObj;

	[SerializeField]
	private Text CurLevelText;

	[SerializeField]
	private Text CashText;

	[SerializeField]
	private Slider Progress;

	[SerializeField]
	private Text EnablePurchaseText;

	[SerializeField]
	private GameObject EnablePurchaseObj;

	[SerializeField]
	private Text MaxText;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private Button PurchaseBtn;

	[SerializeField]
	private Text PriceText;

	[SerializeField]
	private GameObject SaleObj;

	[SerializeField]
	private Text SaleText;

	[SerializeField]
	private List<GameObject> FullObjs;

	[SerializeField]
	private List<GameObject> NotFullObjs;

	private bool bShop;

	public Action LevelUpCallback;

	private void Awake()
	{
	}

	public void Init(bool isShop)
	{
	}

	private void SetPiggySkin(int level)
	{
	}

	private void OnClickInfo()
	{
	}

	private void OnClickBuyPiggyBank()
	{
	}
}
