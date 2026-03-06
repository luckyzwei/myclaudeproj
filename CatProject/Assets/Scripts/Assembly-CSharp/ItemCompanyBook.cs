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
		var btn = GetComponent<UnityEngine.UI.Button>();
		if (btn != null) btn.onClick.AddListener(OnClickBtn);
	}

	public void Set(int idx)
	{
		CompanyIdx = idx;
		if (LockObj != null) LockObj.SetActive(false);
		if (NotGetObj != null) NotGetObj.SetActive(false);
	}

	public void SetVisibleArrowIcon(bool bShow)
	{
		if (ArrowObj != null) ArrowObj.SetActive(bShow);
	}

	private void OnClickBtn()
	{
		ClickCb?.Invoke(CompanyIdx);
	}
}
