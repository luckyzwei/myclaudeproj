using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupGemChange", false, false)]
public class PopupGemChange : UIBase
{
	[Header("PopupGemChange")]
	[SerializeField]
	private Text CashText;

	[Space(5f)]
	[SerializeField]
	private Text gemCountText;

	private BigInteger gemCount;

	public override void OnShowBefore()
	{
	}

	public void Set(BigInteger count)
	{
	}
}
