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
		base.Awake();
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
	}

	public void SetRound(int idx)
	{
		Round = idx;
	}

	private void OnClickSelectCeo(int managerIdx)
	{
		Hide();
	}

	private void OnClickInfo()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}
}
