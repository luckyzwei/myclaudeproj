using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupStageOpen", false, false)]
public class PopupStageOpen : UIBase
{
	[SerializeField]
	protected Image newStageIcon;

	[SerializeField]
	protected Image newStageIconWhite;

	[SerializeField]
	protected Text newStageName;

	[SerializeField]
	protected Button okBtn;

	[Header("menu")]
	[SerializeField]
	private ContentSizeFitter menuContentFitter;

	[SerializeField]
	private int menuFitterOnCount;

	[SerializeField]
	private List<ItemRenovateMenu> menuItemList;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	protected virtual void OnClickOK()
	{
	}
}
