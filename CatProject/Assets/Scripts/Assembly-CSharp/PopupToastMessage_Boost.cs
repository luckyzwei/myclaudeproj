using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupToastMessage_Boost>(ui => ui.SetData(prevRevenue, newRevenue));
	}

	public void SetData(BigInteger prevRevenue, BigInteger newRevenue)
	{
		PrevRevenue = prevRevenue;
		NewRevenue = newRevenue;
	}

	public override void OnShowBefore()
	{
		PlayCount();
	}

	private void PlayCount()
	{
		BigInteger increase = NewRevenue - PrevRevenue;
		if (IncreaseRevenueText != null)
			IncreaseRevenueText.text = "+" + ProjectUtility.GetThousandCommaText(increase);
	}
}
