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
		ID = id;
	}

	public void ShowExp(int exp)
	{
		if (ExpRoot != null)
			ExpRoot.SetActive(true);
		if (EarnExpText != null)
			EarnExpText.text = "+" + exp;
		if (MsgRoot != null)
			MsgRoot.SetActive(false);
		if (ActivityRoot != null)
			ActivityRoot.SetActive(false);
		if (EvaluationRoot != null)
			EvaluationRoot.SetActive(false);
		Show();
	}

	public void ShowMessage(string msg, int isgood)
	{
		ShowMessage(msg, isgood > 0 ? EmployeeMoodSystem.Mood.Good : EmployeeMoodSystem.Mood.Bad);
	}

	public void ShowMessage(string msg, EmployeeMoodSystem.Mood mood)
	{
		if (MsgRoot != null)
			MsgRoot.SetActive(true);
		if (MsgText != null)
			MsgText.text = msg;
		if (ExpRoot != null)
			ExpRoot.SetActive(false);
		if (ActivityRoot != null)
			ActivityRoot.SetActive(false);
		if (EvaluationRoot != null)
			EvaluationRoot.SetActive(false);
		Show();
	}

	public void ShowActivity(Config.OfficeType type)
	{
		if (ActivityRoot != null)
			ActivityRoot.SetActive(true);
		if (MsgRoot != null)
			MsgRoot.SetActive(false);
		if (ExpRoot != null)
			ExpRoot.SetActive(false);
		if (EvaluationRoot != null)
			EvaluationRoot.SetActive(false);
		if (DebuffObj != null)
			DebuffObj.SetActive(false);
		Show();
	}

	public void ShowEvaluation(bool isgood)
	{
		if (EvaluationRoot != null)
			EvaluationRoot.SetActive(true);
		if (MsgRoot != null)
			MsgRoot.SetActive(false);
		if (ExpRoot != null)
			ExpRoot.SetActive(false);
		if (ActivityRoot != null)
			ActivityRoot.SetActive(false);
		Show();
	}

	protected override void Update()
	{
		base.Update();
	}

	private void OnEnable()
	{
		CancelInvoke();
		Invoke(nameof(AutoHide), 2f);
	}

	private void OnDisable()
	{
		CancelInvoke();
	}

	private void AutoHide()
	{
		Hide();
	}
}
