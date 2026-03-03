using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupStaminaShop", false, false)]
public class PopupStaminaShop : UIBase
{
	[SerializeField]
	protected List<ItemShopStamina> items;

	[Header("HUD")]
	[SerializeField]
	private Transform staminaIconTrans;

	[SerializeField]
	private Text StaminaText;

	[SerializeField]
	private Text GemText;

	private CompositeDisposable disposables;

	public override void OnShowBefore()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
