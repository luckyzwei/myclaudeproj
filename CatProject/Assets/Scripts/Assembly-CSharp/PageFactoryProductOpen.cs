using System.Collections.Generic;
using Treeplla;
using UnityEngine;

[UIPath("UI/Page/PageFactoryProductOpen", false, false)]
public class PageFactoryProductOpen : UIBase
{
	[SerializeField]
	private List<GameObject> OpenProductItemRootList;

	[SerializeField]
	private List<ItemArticle> OpenProductItemList;

	public void Set(List<int> openProductIdList)
	{
		// Update display
	}
}
