using System;
using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class Loading : UIBase, ILocalizeRefresh
{
	[SerializeField]
	private CanvasGroup group;

	[SerializeField]
	private GameObject FullScreen;

	[SerializeField]
	protected GameObject Spinner;

	[SerializeField]
	private float hideTime;

	[SerializeField]
	private float hideHoldTime;

	[SerializeField]
	private Text TipText;

	[SerializeField]
	private List<LocalizeString> refreshStringList;

	private float deletaTime;

	private bool hideAni;

	private GameObject instSprite;

	private Action HideCallback;

	protected override void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public void RefreshText()
	{
	}

	public virtual void Show(bool worldTranslate)
	{
	}

	public void LockScreen()
	{
	}

	public void ShowTip()
	{
	}

	public virtual void Hide(bool Immediately = true, Action action = null)
	{
	}

	protected virtual void Update()
	{
	}
}
