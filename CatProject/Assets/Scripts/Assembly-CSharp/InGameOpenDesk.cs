using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/OpenDeskUI", false)]
[FloatingDepth(11)]
public class InGameOpenDesk : InGameFloatingUI
{
	[SerializeField]
	private Text OpenPrice;

	[SerializeField]
	private Button OpenBtn;

	[SerializeField]
	private RectTransform UIRectTrans;

	[SerializeField]
	private Image ArrowImg;

	[SerializeField]
	private RectTransform ArrowRectTrans;

	private Action btnAction;

	private CompositeDisposable disposables;

	private BigInteger Price;

	public int Desk { get; private set; }

	private void Awake()
	{
		if (OpenBtn != null)
			OpenBtn.onClick.AddListener(OnClickBtn);
		disposables = new CompositeDisposable();
	}

	public void SetCallback(Action callback)
	{
		btnAction = callback;
	}

	public void SetDesk(int desk)
	{
		Desk = desk;
	}

	public void SetPrice(BigInteger _Price)
	{
		Price = _Price;
		if (OpenPrice != null)
			OpenPrice.text = ProjectUtility.GetThousandCommaText(Price);
	}

	private void OnClickBtn()
	{
		btnAction?.Invoke();
	}

	public void SetDir(int dir)
	{
		if (ArrowRectTrans != null)
		{
			float angle = dir == 0 ? 0f : 180f;
			ArrowRectTrans.localRotation = UnityEngine.Quaternion.Euler(0f, 0f, angle);
		}
		if (UIRectTrans != null)
		{
			float xScale = dir == 0 ? 1f : -1f;
			UIRectTrans.localScale = new Vector3(xScale, 1f, 1f);
		}
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}

	public override void Hide()
	{
		base.Hide();
		btnAction = null;
	}
}
