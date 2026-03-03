using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Seasonal/PopupCoinDCMission", false, false)]
public class PopupCoinDCMission : UIBase
{
	[SerializeField]
	private Text textRemainTime;

	[SerializeField]
	private Button btnShortcut;

	protected override void Awake()
	{
	}

	private void OnClickShortcut()
	{
	}
}
