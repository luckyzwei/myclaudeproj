using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class PackageComponentNewRegionTarot : PackageComponent
{
	[SerializeField]
	private List<ItemArticle> TarotTicketArticle;

	[SerializeField]
	private List<ItemArticle> RewardCurrencyArticle;

	[SerializeField]
	protected GameObject TimeRoot;

	[SerializeField]
	protected Text RemainTimeText;

	private CompositeDisposable disposables;

	public override void Set(int packageIdx)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
