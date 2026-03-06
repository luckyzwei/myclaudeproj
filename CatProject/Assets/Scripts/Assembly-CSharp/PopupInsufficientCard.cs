using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupInsufficientCard", false, false)]
public class PopupInsufficientCard : UIBase
{
	[SerializeField]
	private Image CardImage;

	[SerializeField]
	private ItemArticle CardArticle;

	[SerializeField]
	private Text NeedGemText;

	[SerializeField]
	private Button BuyBtn;

	[SerializeField]
	private ShopContentsGem ShopContentsGem;

	private int NeedGemValue;

	private int ManagerIdx;

	private int ManagerLevel;

	private int NeedCount;

	private int Log_NeedLevel;

	protected override void Awake()
	{
		base.Awake();
		if (BuyBtn != null) BuyBtn.onClick.AddListener(OnClickBuyBtn);
	}

	public void Set(int managerIdx, int needCount)
	{
		ManagerIdx = managerIdx;
		NeedCount = needCount;
	}

	private void OnClickBuyBtn()
	{
		Hide();
	}
}
