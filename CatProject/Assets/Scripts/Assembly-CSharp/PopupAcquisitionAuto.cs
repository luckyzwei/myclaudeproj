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

	private Action<bool> _onCountDownEnd;
	public event Action<bool> OnCountDownEnd
	{
		[CompilerGenerated]
		add
		{
			_onCountDownEnd += value;
		}
		[CompilerGenerated]
		remove
		{
			_onCountDownEnd -= value;
		}
	}

	public override void OnShowBefore()
	{
		ElapsedTime = 0f;
		StartCountDown = true;
		ContinueBattle = true;
		AutoPlayWaitTime = 5;
		SetRemainTimeText();
	}

	public override void OnHideBefore()
	{
		StartCountDown = false;
		_onCountDownEnd?.Invoke(ContinueBattle);
		_onCountDownEnd = null;
	}

	public void Update()
	{
		if (!StartCountDown) return;
		ElapsedTime += Time.deltaTime;
		SetRemainTimeText();
		if (ElapsedTime >= AutoPlayWaitTime)
		{
			StartCountDown = false;
			Hide();
		}
	}

	private void SetRemainTimeText()
	{
		int remain = AutoPlayWaitTime - (int)ElapsedTime;
		if (remain < 0) remain = 0;
		if (RemainTimeText != null) RemainTimeText.text = remain.ToString();
	}
}
