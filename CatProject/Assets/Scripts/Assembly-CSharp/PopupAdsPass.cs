using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAdsPass", false, false)]
public class PopupAdsPass : UIBase
{
	[SerializeField]
	private Transform Root;

	[SerializeField]
	private GameObject ItemAdsPass;

	[SerializeField]
	private Text ResetRemainText;

	private CompositeDisposable disposables;

	public override void OnShowBefore()
	{
		disposables = new CompositeDisposable();
		UpdateList();
	}

	private void UpdateList()
	{
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
