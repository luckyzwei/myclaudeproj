using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/EmployeeUI", true)]
[FloatingDepth(9)]
public class InGameEmployeeUI : InGameFloatingUI
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

	[Header("Exp")]
	[SerializeField]
	private GameObject ExpRoot;

	[SerializeField]
	private Text EarnExpText;

	[Header("Activity")]
	[SerializeField]
	private GameObject ActivityRoot;

	[SerializeField]
	private Image ActivityIcon;

	[SerializeField]
	private GameObject DebuffObj;

	[Header("Evaluation")]
	[SerializeField]
	private GameObject EvaluationRoot;

	[SerializeField]
	private Image Evaluation;

	private int ID;

	public void SetId(int id)
	{
	}

	public void ShowExp(int exp)
	{
	}

	public void ShowMessage(string msg, int isgood)
	{
	}

	public void ShowMessage(string msg, EmployeeMoodSystem.Mood mood)
	{
	}

	public void ShowActivity(Config.OfficeType type)
	{
	}

	public void ShowEvaluation(bool isgood)
	{
	}

	protected override void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
