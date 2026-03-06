using UnityEngine;
using UnityEngine.UI;

public class ItemShopFreecash : MonoBehaviour
{
	[SerializeField]
	private Button PopupBtn;

	[SerializeField]
	private Text RewardText;

	private void Awake()
	{
		if (PopupBtn != null) PopupBtn.onClick.AddListener(OnClickedPopupBtn);
	}

	private void OnClickedPopupBtn()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}
}
