using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCompanyBook : MonoBehaviour
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private List<Image> LevelObjs;

	[SerializeField]
	private Image GradeBG;

	[SerializeField]
	private Text GradeText;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject NotGetObj;

	[SerializeField]
	private GameObject ArrowObj;

	[SerializeField]
	private GameNotificationRegister Reddot;

	public Action<int> ClickCb;

	public int CompanyIdx { get; private set; }

	private void Awake()
	{
	}

	public void Set(int idx)
	{
	}

	public void SetVisibleArrowIcon(bool bShow)
	{
	}

	private void OnClickBtn()
	{
	}
}
