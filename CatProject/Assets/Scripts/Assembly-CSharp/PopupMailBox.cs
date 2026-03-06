using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupMailBox", false, false)]
public class PopupMailBox : UIBase
{
	[SerializeField]
	private GameObject emptyRoot;

	[SerializeField]
	private ScrollRect listRoot;

	[SerializeField]
	private GameObject postItem;

	private List<GameObject> postList;

	public void Init()
	{
		if (postList == null) postList = new List<GameObject>();
		Clear();
		if (emptyRoot != null) emptyRoot.SetActive(postList.Count == 0);
	}

	private void OnDestroy()
	{
		Clear();
	}

	private void Clear()
	{
		if (postList != null)
		{
			for (int i = 0; i < postList.Count; i++)
			{
				if (postList[i] != null) Object.Destroy(postList[i]);
			}
			postList.Clear();
		}
	}
}
