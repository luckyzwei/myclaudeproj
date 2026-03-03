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
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Set(int offerIdx)
	{
	}

	private void SetRedDot()
	{
	}

	private void OnClickBtn()
	{
	}
}
