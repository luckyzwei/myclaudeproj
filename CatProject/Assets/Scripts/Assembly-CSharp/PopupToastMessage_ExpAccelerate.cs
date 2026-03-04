using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupToastMessage_ExpAccelerate", false, false)]
public class PopupToastMessage_ExpAccelerate : UIBase
{
	[SerializeField]
	private Image IconImage;

	[SerializeField]
	private Text DescText;

	public static void OpenToast(Config.ItemIdx itemIdx, BigInteger expAmount, bool isShowImmediately = true)
	{
	}

	public void SetData(Config.ItemIdx itemIdx, BigInteger expAmount)
	{
	}
}
