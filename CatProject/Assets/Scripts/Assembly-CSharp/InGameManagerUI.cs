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
	}

	protected override void Update()
	{
	}

	private void OnEnable()
	{
	}
}
