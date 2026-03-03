using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAuctionResultFail", false, false)]
public class PopupAuctionResultFail : UIBase
{
	[SerializeField]
	private Text Title;

	[SerializeField]
	private Text TotalRoundText;

	[SerializeField]
	private Text WinCountText;

	[SerializeField]
	private Button ConfirmBtn;

	protected override void Awake()
	{
	}

	public void Set(int win_count, bool isdraw)
	{
	}
}
