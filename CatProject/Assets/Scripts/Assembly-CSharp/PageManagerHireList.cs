using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageManagerHireList", false, false)]
public class PageManagerHireList : UIBase
{
	[Header("PageManagerHireList")]
	[Header("ManagerList")]
	[SerializeField]
	private ItemManagerHireList ItemPrefab;

	[SerializeField]
	private List<ItemManagerHireList> ItemList;

	[SerializeField]
	private ScrollRect ItemScroll;

	[Header("OneTime")]
	[SerializeField]
	private OnetimeCurrencyComponent onetimeCurrencyComponent;

	private Transform focusCardT;

	private int savedPiggyCount;

	private int savedOneTimeCount;

	public int TargetOfficeIdx { get; set; }

	public int TargetManagerIdx { get; set; }

	public override void OnShowBefore()
	{
		savedPiggyCount = 0;
		savedOneTimeCount = 0;
		UpdateList();
	}

	public override void OnHideBefore()
	{
		ShowPiggyOnetime();
	}

	public override void OnHideAfter()
	{
		focusCardT = null;
	}

	private void ShowPiggyOnetime()
	{
		if (onetimeCurrencyComponent != null)
			onetimeCurrencyComponent.gameObject.SetActive(false);
	}

	public void UpdateList()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
		if (ItemList == null) return;
		for (int i = 0; i < ItemList.Count; i++)
		{
			if (ItemList[i] != null)
				ItemList[i].gameObject.SetActive(true);
		}
	}

	public void ShowUpgradeArrow(int officeIdx)
	{
	}

	private void UpgradeCallBack(int level)
	{
		UpdateList();
	}
}
