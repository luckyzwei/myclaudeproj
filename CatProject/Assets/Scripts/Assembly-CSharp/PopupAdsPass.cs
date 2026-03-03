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
	}

	private void UpdateList()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
