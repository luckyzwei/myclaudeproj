using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupTutorialBoostGive", false, false)]
public class PopupTutorialBoostGive : UIBase
{
	[SerializeField]
	private Button confirmBtn;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Time;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text Price;

	protected override void Awake()
	{
		base.Awake();
		if (confirmBtn != null) confirmBtn.onClick.AddListener(OnClickConfirm);
	}

	public void Init()
	{
	}

	private void OnClickConfirm()
	{
		Hide();
	}
}
