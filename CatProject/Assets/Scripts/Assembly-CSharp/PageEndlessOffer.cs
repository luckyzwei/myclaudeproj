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
		base.Awake();
	}

	public override void OnShowBefore()
	{
		EndShowBefore = false;
		if (IsNeedClose)
		{
			Hide();
			return;
		}
		InitEndlessOfferComponent();
		EndShowBefore = true;
	}

	public override void OnHideBefore()
	{
		ReleaseEndlessOfferComponent();
	}

	private void OnDestroy()
	{
		ReleaseEndlessOfferComponent();
	}

	public void SetEndlessOffer(int endlessOfferIdx, ShopSystem.InAppPurchaseLocation enterPlace)
	{
		EndlessOfferIdx = endlessOfferIdx;
		EnterPlace = enterPlace;
		IsNeedClose = false;
		IsLoading = false;
	}

	private void InitEndlessOfferComponent()
	{
		if (EndlessOfferComponent != null) return;
		if (ComponentRootTr == null) return;

		if (EndlessOfferComponent != null)
		{
			EndlessOfferComponent.OnPlayAnimationEvent = OnPlayAnimationEvent;
			EndlessOfferComponent.OnTimeEndEvent = OnTimeEndEvent;
			EndlessOfferComponent.Set(EndlessOfferIdx, EnterPlace);
		}
	}

	private void OnPlayAnimationEvent(bool isPlaying)
	{
		IsLoading = isPlaying;
	}

	private void OnTimeEndEvent()
	{
		SetNeedClose();
	}

	private void SetNeedClose()
	{
		IsNeedClose = true;
		if (EndShowBefore)
			Hide();
	}

	private void ReleaseEndlessOfferComponent()
	{
		if (EndlessOfferComponent != null)
		{
			EndlessOfferComponent.OnPlayAnimationEvent = null;
			EndlessOfferComponent.OnTimeEndEvent = null;
			EndlessOfferComponent = null;
		}
		if (EndlessOfferComponentInstance != null)
		{
			Object.Destroy(EndlessOfferComponentInstance);
			EndlessOfferComponentInstance = null;
		}
	}
}
