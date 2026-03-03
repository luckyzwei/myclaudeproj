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
	}

	public void Set(int officeIdx, int regionIdx = -1)
	{
	}

	private void UpgradeCallBack(int level)
	{
	}

	private void OnClickShowPageBtn()
	{
	}

	public void ShowUpgradeArrow()
	{
	}
}
