using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		if (DistributeNoticeObj != null)
			DistributeNoticeObj.SetActive(true);
		if (AddNewWorkerNoticeObj != null)
			AddNewWorkerNoticeObj.SetActive(false);
		if (ProductValueText != null)
			ProductValueText.text = sellingPrice_PerMile.ToString();
		Show();
	}

	public void OnAddNewWorker()
	{
		if (AddNewWorkerNoticeObj != null)
			AddNewWorkerNoticeObj.SetActive(true);
		if (DistributeNoticeObj != null)
			DistributeNoticeObj.SetActive(false);
		Show();
	}

	public void Show()
	{
		if (CanvasGroup == null)
			CanvasGroup = GetComponent<CanvasGroup>();
		if (CanvasGroup != null)
		{
			CanvasGroup.alpha = 1f;
			CanvasGroup.blocksRaycasts = true;
		}
	}
}
