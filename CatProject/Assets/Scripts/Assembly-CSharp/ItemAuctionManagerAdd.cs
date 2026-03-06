using UnityEngine;
using UnityEngine.UI;

public class ItemAuctionManagerAdd : MonoBehaviour
{
	[SerializeField]
	private Text RoundText;

	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private ItemAuctionManager EquipAuctionManager;

	private int RoundIndex;

	private void Awake()
	{
		if (Btn != null) Btn.onClick.AddListener(OnClickAdd);
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
	}

	public void Set(int index)
	{
		RoundIndex = index;
		if (RoundText != null) RoundText.text = (index + 1).ToString();
		UpdateManager();
	}

	public void UpdateManager()
	{
	}

	private void OnClickInfo()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupRewardDetail>();
	}

	private void OnClickAdd()
	{
	}
}
