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
		if (disposables != null) { disposables.Dispose(); }
		disposables = new CompositeDisposable();
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
