using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AutoEquipItemsDb", menuName = "ScriptableObjects/AutoEquipItemsDb", order = 2)]
public class AutoEquipItemsDb : ScriptableObject
{
	public enum AutoEquipItemType
	{
		SKIN = 0,
		BOARD_COLOR = 1,
		AUTO_X = 2
	}

	[Serializable]
	public class AutoEquipBundleData
	{
		public string productCliendId;

		public AutoEquipItemData[] itemsToEquip;
	}

	[Serializable]
	public class AutoEquipItemData
	{
		public string cliendId;

		public AutoEquipItemType type;
	}

	public List<AutoEquipBundleData> items;

	public void Equip(AutoEquipBundleData bundle)
	{
	}
}
