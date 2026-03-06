using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupOneTimeEventComplete", false, false)]
public class PopupOneTimeEventComplete : UIBase
{
	[Header("[PopupOneTimeEventComplete]")]
	[SerializeField]
	private Button moveBtn;

	protected override void Awake()
	{
		base.Awake();
	}
}
