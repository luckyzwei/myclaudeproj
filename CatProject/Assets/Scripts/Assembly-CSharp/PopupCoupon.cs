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
		base.Awake();
		if (GetButton != null) GetButton.onClick.AddListener(OnClickGet);
	}

	private void OnClickGet()
	{
		if (EditBox == null) return;
		string couponCode = EditBox.text;
		if (string.IsNullOrEmpty(couponCode)) return;
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
	}
}
