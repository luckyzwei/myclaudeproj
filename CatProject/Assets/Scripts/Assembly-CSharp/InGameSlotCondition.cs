using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/InGame/SlotCondition", false, false)]
public class InGameSlotCondition : InGameFloatingUI
{
	[SerializeField]
	private Text text;

	[SerializeField]
	private List<GameObject> scaleComponents;

	[SerializeField]
	private HorizontalOrVerticalLayoutGroup layoutGroup;

	public void SetLvCnt(int cnt)
	{
		// Update display
	}

	public void SetDir(bool Left)
	{
		// Update display
	}
}
