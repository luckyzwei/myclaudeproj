using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/ToastMessage_BoostDone", false, false)]
public class PopupToastMessage_BoostDone : UIBase
{
	[SerializeField]
	private Text DescText;

	public static void Show(int boosterIdx)
	{
		// TODO
	}

	public void SetData(int boosterIdx)
	{
		// Update display
	}
}
