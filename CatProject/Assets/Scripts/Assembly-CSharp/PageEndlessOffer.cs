using Treeplla;
using UnityEngine;

[UIPath("UI/Page/PageEndlessOffer", false, false)]
public class PageEndlessOffer : UIBase
{
	[SerializeField]
	private Transform ComponentRootTr;

	private int EndlessOfferIdx;

	private string PrefabName;

	private EndlessOfferComponentBase EndlessOfferComponent;

	private GameObject EndlessOfferComponentInstance;

	private bool IsLoading;

	private bool IsNeedClose;

	private bool EndShowBefore;

	private ShopSystem.InAppPurchaseLocation EnterPlace;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetEndlessOffer(int endlessOfferIdx, ShopSystem.InAppPurchaseLocation enterPlace)
	{
	}

	private void InitEndlessOfferComponent()
	{
	}

	private void OnPlayAnimationEvent(bool isPlaying)
	{
	}

	private void OnTimeEndEvent()
	{
	}

	private void SetNeedClose()
	{
	}

	private void ReleaseEndlessOfferComponent()
	{
	}
}
