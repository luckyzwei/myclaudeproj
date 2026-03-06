using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemCeoOfficeSKill : MonoBehaviour
{
	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Image SkillIcon;

	[SerializeField]
	private GameObject InfoObj;

	[SerializeField]
	private Text InfoDesc;

	private Action onOpenInfo;

	private void Awake()
	{
		if (Btn != null) Btn.onClick.AddListener(OnClickBtn);
	}

	public void Set(int skillIdx, int value, Action openInfoAction)
	{
		onOpenInfo = openInfoAction;
	}

	private void OnClickBtn()
	{
		if (InfoObj != null) InfoObj.SetActive(true);
		onOpenInfo?.Invoke();
	}

	public void CloseInfo()
	{
		if (InfoObj != null) InfoObj.SetActive(false);
	}
}
