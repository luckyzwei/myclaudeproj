using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/InGameManagerUI", true)]
[FloatingDepth(9)]
public class InGameManagerUI : InGameFloatingUI
{
	[Header("Msg")]
	[SerializeField]
	private GameObject MsgRoot;

	[SerializeField]
	private Text MsgText;

	[SerializeField]
	private Image MsgMood;

	[SerializeField]
	private Image MsgBg;

	[SerializeField]
	private Image MsgTail;

	public void ShowMessage(string msg, int isgood)
	{
		if (MsgRoot != null) MsgRoot.SetActive(true);
		if (MsgText != null) MsgText.text = msg;
		// isgood > 0 means good mood, <= 0 means bad mood
		if (MsgMood != null) MsgMood.color = isgood > 0 ? Color.green : Color.red;
	}

	protected override void Update()
	{
		base.Update();
	}

	private void OnEnable()
	{
		if (MsgRoot != null) MsgRoot.SetActive(false);
	}
}
