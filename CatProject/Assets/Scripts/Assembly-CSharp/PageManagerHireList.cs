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
	}

	public override void OnHideBefore()
	{
	}

	public override void OnHideAfter()
	{
	}

	private void ShowPiggyOnetime()
	{
	}

	public void UpdateList()
	{
	}

	public void ShowUpgradeArrow(int officeIdx)
	{
	}

	private void UpgradeCallBack(int level)
	{
	}
}
