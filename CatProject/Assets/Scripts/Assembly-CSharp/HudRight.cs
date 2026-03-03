using System.Collections.Generic;
using DG.Tweening;
using Treeplla;
using UnityEngine;

[UIPath("UI/Page/HUDRight", true, false)]
public class HudRight : UIBase, IScreenAction
{
	private HUDType[] aniType;

	[SerializeField]
	private List<DOTweenAnimation> appearTween;

	private bool appear;

	private bool screenAction;

	public HUDType[] HudType => null;

	public bool IsScreenAction => false;

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	public override void OnShowAfter()
	{
	}

	public void ScreenAction(bool value)
	{
	}

	public void ScreenTopOn(bool value)
	{
	}

	public bool IsScreenTopOn()
	{
		return false;
	}

	public void OnScreenActionStep()
	{
	}

	public void OnScreenActionComplete()
	{
	}
}
