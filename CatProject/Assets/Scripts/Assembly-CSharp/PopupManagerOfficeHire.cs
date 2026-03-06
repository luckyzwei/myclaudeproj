using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupManagerOfficeHire", false, false)]
public class PopupManagerOfficeHire : UIBase
{
	[Header("PopupManagerOfficeHire")]
	[SerializeField]
	private ItemManagerHireList Item;

	[SerializeField]
	private Button ShowPageBtn;

	private int OfficeIdx;

	private int RegionIdx;

	protected override void Awake()
	{
		base.Awake();
		if (ShowPageBtn != null) ShowPageBtn.onClick.AddListener(OnClickShowPageBtn);
	}

	public void Set(int officeIdx, int regionIdx = -1)
	{
		OfficeIdx = officeIdx;
		RegionIdx = regionIdx;
	}

	private void UpgradeCallBack(int level)
	{
		Set(OfficeIdx, RegionIdx);
	}

	private void OnClickShowPageBtn()
	{
		Hide();
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PageManager>();
	}

	public void ShowUpgradeArrow()
	{
		if (Item != null) Item.gameObject.SetActive(true);
	}
}
