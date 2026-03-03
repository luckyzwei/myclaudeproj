using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/ToastMessage_Boost", false, false)]
public class PopupToastMessage_Boost : UIBase
{
	[SerializeField]
	private RollingCountTextComponent ResultRevenueText;

	[SerializeField]
	private Text IncreaseRevenueText;

	private BigInteger PrevRevenue;

	private BigInteger NewRevenue;

	public static void Show(BigInteger prevRevenue, BigInteger newRevenue)
	{
	}

	public void SetData(BigInteger prevRevenue, BigInteger newRevenue)
	{
	}

	public override void OnShowBefore()
	{
	}

	private void PlayCount()
	{
	}
}
