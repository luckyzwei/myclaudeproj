using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAuctionOrganizeMyCEO", false, false)]
public class PopupAuctionOrganizeMyCEO : UIBase
{
	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject Item;

	[SerializeField]
	private Button InfoBtn;

	public int Round { get; private set; }

	protected override void Awake()
	{
	}

	public void SetRound(int idx)
	{
	}

	private void OnClickSelectCeo(int managerIdx)
	{
	}

	private void OnClickInfo()
	{
	}
}
