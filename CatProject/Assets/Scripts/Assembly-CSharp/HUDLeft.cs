using System.Collections.Generic;
using DG.Tweening;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/HUDLeft", true, false)]
public class HUDLeft : UIBase, IScreenAction
{
	private HUDType[] aniType;

	[SerializeField]
	private GameObject iconRoot;

	[SerializeField]
	private GameObject packagePrefab;

	[SerializeField]
	private List<GameObject> cachedComponets;

	[SerializeField]
	private Button Vip_btn;

	[SerializeField]
	private List<DOTweenAnimation> appearTween;

	private bool appear;

	private bool screenAction;

	public HUDType[] HudType { get { return null; } }

	public bool IsScreenAction { get { return false; } }

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	public void UpdatePackage()
	{
	}

	public override void OnShowBefore()
	{
	}

	public GameObject GetCachedObject()
	{
		return null;
	}

	public void ClickBoost()
	{
	}

	public void ClickPass()
	{
	}

	public void ClickVip()
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
