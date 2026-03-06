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

	public HUDType[] HudType { get { return aniType; } }

	public bool IsScreenAction { get { return screenAction; } }

	protected override void Awake()
	{
		base.Awake();
		aniType = new HUDType[0];
		if (Vip_btn != null) Vip_btn.onClick.AddListener(ClickVip);
	}

	public void Init()
	{
		UpdatePackage();
	}

	public void UpdatePackage()
	{
		if (cachedComponets == null) return;
		for (int i = 0; i < cachedComponets.Count; i++)
		{
			if (cachedComponets[i] != null)
				cachedComponets[i].SetActive(false);
		}
	}

	public override void OnShowBefore()
	{
		Init();
	}

	public GameObject GetCachedObject()
	{
		if (cachedComponets != null)
		{
			for (int i = 0; i < cachedComponets.Count; i++)
			{
				if (cachedComponets[i] != null && !cachedComponets[i].activeSelf)
					return cachedComponets[i];
			}
		}
		if (packagePrefab != null && iconRoot != null)
		{
			var go = Instantiate(packagePrefab, iconRoot.transform);
			if (cachedComponets == null) cachedComponets = new List<GameObject>();
			cachedComponets.Add(go);
			return go;
		}
		return null;
	}

	public void ClickBoost()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupBoost>();
	}

	public void ClickPass()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void ClickVip()
	{
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	public void ScreenAction(bool value)
	{
		screenAction = value;
		appear = !value;
		if (appearTween != null)
		{
			for (int i = 0; i < appearTween.Count; i++)
			{
				if (appearTween[i] != null)
				{
					if (value) appearTween[i].DOPlayForward();
					else appearTween[i].DOPlayBackwards();
				}
			}
		}
	}

	public void ScreenTopOn(bool value)
	{
		screenAction = !value;
	}

	public bool IsScreenTopOn()
	{
		return !screenAction;
	}

	public void OnScreenActionStep()
	{
		// Screen action step - no additional behavior needed
	}

	public void OnScreenActionComplete()
	{
		appear = !screenAction;
	}
}
