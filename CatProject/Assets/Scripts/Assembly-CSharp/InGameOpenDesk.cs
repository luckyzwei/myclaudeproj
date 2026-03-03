using System;
using System.Numerics;
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
	}

	public void SetCallback(Action callback)
	{
	}

	public void SetDesk(int desk)
	{
	}

	public void SetPrice(BigInteger _Price)
	{
	}

	private void OnClickBtn()
	{
	}

	public void SetDir(int dir)
	{
	}

	private void OnDestroy()
	{
	}

	public override void Hide()
	{
	}
}
