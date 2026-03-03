using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupParkingCompensation", false, false)]
public class PopupParkingCompensation : UIBase
{
	[SerializeField]
	private Text CompensationMoneyText;

	private BigInteger CompensationValue;

	private int RemoveRichPoint;

	public override void OnShowBefore()
	{
	}

	public override void Hide()
	{
	}
}
