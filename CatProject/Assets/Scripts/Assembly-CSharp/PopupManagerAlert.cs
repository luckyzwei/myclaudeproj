using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupManagerAlert", false, false)]
public class PopupManagerAlert : UIBase
{
	[Header("PopupManagerAlert")]
	[SerializeField]
	private Button HireBtn;

	[SerializeField]
	private Text AlertDesc;

	private Action onClickHireCb;

	protected override void Awake()
	{
	}

	public void Set(int regionIdx, int stageIdx, int officeIdx, Action hireCb)
	{
	}

	public void OnClickHireBtn()
	{
	}
}
