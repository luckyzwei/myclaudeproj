using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRestoreGem", false, false)]
public class PopupRestoreGem : UIBase
{
	[SerializeField]
	private Text RestoreGem;

	[SerializeField]
	private Button ConfirmBtn;

	private int gemCount;

	protected override void Awake()
	{
	}

	public void SetGem(int restoreGem)
	{
	}

	public override void Hide()
	{
	}
}
