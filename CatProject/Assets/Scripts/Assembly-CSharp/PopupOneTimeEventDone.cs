using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupOneTimeEventDone", false, false)]
public class PopupOneTimeEventDone : UIBase
{
	[Header("[PopupOneTimeEventDone]")]
	[SerializeField]
	private Button moveBtn;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}
}
