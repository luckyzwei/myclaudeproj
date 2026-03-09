using System.Collections.Generic;
using KWCore.UI;
using UnityEngine;
using UnityEngine.UI;

public class PopupFriends : PopUpBase
{
	private const string PREFAB_NAME = "Prefabs/KWPlayerProfile/Popup-Friends";

	[SerializeField]
	private List<Button> m_tabButtons;

	[SerializeField]
	private List<GameObject> m_tabContainers;

	[SerializeField]
	private int m_defaultTab;

	public static PopupFriends Open()
	{
		return null;
	}

	private void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void ChangeTab(int tabIndex)
	{
	}
}
