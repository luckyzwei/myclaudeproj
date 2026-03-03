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
	}

	private void OnDestroy()
	{
	}

	private void Clear()
	{
	}
}
