using DG.Tweening;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/InGame/TimeUI", false, false)]
public class InGameFacilityTimeUI : InGameFloatingUI
{
	[SerializeField]
	private Text textTime;

	[SerializeField]
	private DOTweenAnimation tween;

	private float saveTime;

	private float deltaTime;

	private bool show;

	public void SetTime(float time)
	{
		saveTime = time;
		if (textTime != null)
		{
			int sec = (int)time;
			textTime.text = string.Format("{0:D2}:{1:D2}", sec / 60, sec % 60);
		}
	}

	public void ShowAni(float updateTime)
	{
		show = true;
		deltaTime = 0f;
		if (tween != null) tween.DOPlayForward();
	}

	protected override void Update()
	{
		base.Update();
		if (!show) return;
		deltaTime += Time.deltaTime;
		float remaining = saveTime - deltaTime;
		if (remaining <= 0f)
		{
			show = false;
			remaining = 0f;
		}
		if (textTime != null)
		{
			int sec = (int)remaining;
			textTime.text = string.Format("{0:D2}:{1:D2}", sec / 60, sec % 60);
		}
	}

	public void OnPlay()
	{
		show = true;
		deltaTime = 0f;
	}
}
