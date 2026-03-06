using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/Review", false, false)]
public class PopupReview : UIBase
{
	[SerializeField]
	private Button ReviewBtn;

	protected override void Awake()
	{
		base.Awake();
		if (ReviewBtn != null) ReviewBtn.onClick.AddListener(OnClickReview);
	}

	public void ShowPopup()
	{
		Show();
	}

	private void OnClickReview()
	{
		Application.OpenURL("market://details?id=" + Application.identifier);
		Hide();
	}
}
