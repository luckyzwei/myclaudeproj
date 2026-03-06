using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class HudEndlessOfferItem : MonoBehaviour
{
	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private TimeComponent TimeComponent;

	[SerializeField]
	private GameObject RedDotObj;

	[SerializeField]
	private bool isHUD;

	private int EndlessOfferIdx;

	private CompositeDisposable Disposables;

	private void Awake()
	{
		Disposables = new CompositeDisposable();
		if (Btn != null) Btn.onClick.AddListener(OnClickBtn);
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	public void Set(int offerIdx)
	{
		EndlessOfferIdx = offerIdx;
		SetRedDot();
	}

	private void SetRedDot()
	{
		if (RedDotObj != null) RedDotObj.SetActive(false);
	}

	private void OnClickBtn()
	{
	}
}
