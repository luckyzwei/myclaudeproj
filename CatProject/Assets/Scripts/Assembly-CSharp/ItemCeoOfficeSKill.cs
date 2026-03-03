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
	}

	public void Set(int skillIdx, int value, Action openInfoAction)
	{
	}

	private void OnClickBtn()
	{
	}

	public void CloseInfo()
	{
	}
}
