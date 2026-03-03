using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class HUDSeasonalNotice : MonoBehaviour
{
	[SerializeField]
	private GameObject DistributeNoticeObj;

	[SerializeField]
	private GameObject AddNewWorkerNoticeObj;

	[SerializeField]
	private Image ProductIconImage;

	[SerializeField]
	private Image MoneyIconImage;

	[SerializeField]
	private Text ProductValueText;

	private CanvasGroup CanvasGroup;

	public void OnDistributeProduct(int productIdx, BigInteger sellingPrice_PerMile)
	{
	}

	public void OnAddNewWorker()
	{
	}

	public void Show()
	{
	}
}
