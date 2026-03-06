using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupUpdateReward", false, false)]
public class PopupUpdateReward : UIBase
{
	[SerializeField]
	private Text RestoreGem;

	[SerializeField]
	private Button ConfirmBtn;

	private int gemCount;

	protected override void Awake()
	{
		base.Awake();
		if (ConfirmBtn != null) ConfirmBtn.onClick.AddListener(() => Hide());
	}

	public void SetGem(int restoreGem)
	{
		gemCount = restoreGem;
		if (RestoreGem != null) RestoreGem.text = restoreGem.ToString();
	}

	public override void Hide()
	{
		base.Hide();
	}
}
