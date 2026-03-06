using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupStatueMove", false, false)]
public class PopupStatueMove : UIBase
{
	[SerializeField]
	private Button GotoHouseBtn;

	protected override void Awake()
	{
		base.Awake();
	}

	private void OnClickGotoHouse()
	{
		Hide();
	}
}
