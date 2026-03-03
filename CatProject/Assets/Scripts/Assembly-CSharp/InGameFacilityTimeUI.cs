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
	}

	public void ShowAni(float updateTime)
	{
	}

	protected override void Update()
	{
	}

	public void OnPlay()
	{
	}
}
