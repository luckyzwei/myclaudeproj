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

	public HUDType[] HudType { get { return aniType; } }

	public bool IsScreenAction { get { return screenAction; } }

	protected override void Awake()
	{
		base.Awake();
	}

	public void Init()
	{
		appear = false;
		screenAction = false;
	}

	public override void OnShowAfter()
	{
		appear = true;
	}

	public void ScreenAction(bool value)
	{
		screenAction = value;
		if (appearTween != null)
		{
			for (int i = 0; i < appearTween.Count; i++)
			{
				if (appearTween[i] != null)
				{
					if (value)
						appearTween[i].DOPlayForward();
					else
						appearTween[i].DOPlayBackwards();
				}
			}
		}
		appear = !value;
	}

	public void ScreenTopOn(bool value)
	{
		screenAction = value;
	}

	public bool IsScreenTopOn()
	{
		return screenAction;
	}

	public void OnScreenActionStep()
	{
	}

	public void OnScreenActionComplete()
	{
		screenAction = false;
		appear = true;
	}
}
