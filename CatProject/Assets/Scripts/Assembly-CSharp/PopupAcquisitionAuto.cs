using System;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupAcquisitionAuto", false, false)]
public class PopupAcquisitionAuto : UIBase
{
	[SerializeField]
	private Text RemainTimeText;

	private int AutoPlayWaitTime;

	private float ElapsedTime;

	private bool StartCountDown;

	private bool ContinueBattle;

	public event Action<bool> OnCountDownEnd
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void OnShowBefore()
	{
	}

	public override void OnHideBefore()
	{
	}

	public void Update()
	{
	}

	private void SetRemainTimeText()
	{
	}
}
