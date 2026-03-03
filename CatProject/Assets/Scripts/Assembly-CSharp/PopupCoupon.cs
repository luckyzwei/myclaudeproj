using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupCoupon", false, false)]
public class PopupCoupon : UIBase
{
	[SerializeField]
	private Button GetButton;

	[SerializeField]
	private InputField EditBox;

	protected override void Awake()
	{
	}

	private void OnClickGet()
	{
	}
}
