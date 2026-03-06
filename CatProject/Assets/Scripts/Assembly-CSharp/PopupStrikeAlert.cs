using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupStrikeAlert", false, false)]
public class PopupStrikeAlert : UIBase
{
	[Header("PopupStrikeAlert")]
	[SerializeField]
	private GameObject GradeItem;

	[SerializeField]
	private Transform GradeItemRoot;

	[SerializeField]
	private Text RegionNameText;

	[SerializeField]
	private Text DescText;

	public override void OnShowBefore()
	{
		base.OnShowBefore();
	}
}
