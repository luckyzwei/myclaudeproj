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
		base.Awake();
		hideAni = false;
		deletaTime = 0f;
	}

	protected virtual void OnDestroy()
	{
		if (instSprite != null)
		{
			Destroy(instSprite);
			instSprite = null;
		}
	}

	public void RefreshText()
	{
		if (refreshStringList != null)
		{
			for (int i = 0; i < refreshStringList.Count; i++)
			{
				if (refreshStringList[i] != null)
					refreshStringList[i].RefreshText();
			}
		}
	}

	public virtual void Show(bool worldTranslate)
	{
		gameObject.SetActive(true);
		if (group != null)
		{
			group.alpha = 1f;
			group.blocksRaycasts = true;
		}
		if (FullScreen != null)
			FullScreen.SetActive(true);
		if (Spinner != null)
			Spinner.SetActive(true);
		hideAni = false;
		deletaTime = 0f;
		ShowTip();
	}

	public void LockScreen()
	{
		gameObject.SetActive(true);
		if (group != null)
		{
			group.alpha = 0f;
			group.blocksRaycasts = true;
		}
		if (Spinner != null)
			Spinner.SetActive(false);
	}

	public void ShowTip()
	{
		if (TipText == null) return;
		// Show random tip text
		TipText.gameObject.SetActive(true);
	}

	public virtual void Hide(bool Immediately = true, Action action = null)
	{
		HideCallback = action;
		if (Immediately)
		{
			if (group != null)
			{
				group.alpha = 0f;
				group.blocksRaycasts = false;
			}
			gameObject.SetActive(false);
			HideCallback?.Invoke();
			HideCallback = null;
		}
		else
		{
			hideAni = true;
			deletaTime = 0f;
		}
	}

	protected virtual void Update()
	{
		if (!hideAni) return;

		deletaTime += Time.unscaledDeltaTime;

		if (deletaTime < hideHoldTime) return;

		float t = (deletaTime - hideHoldTime) / hideTime;
		if (group != null)
			group.alpha = Mathf.Lerp(1f, 0f, t);

		if (t >= 1f)
		{
			hideAni = false;
			if (group != null)
			{
				group.alpha = 0f;
				group.blocksRaycasts = false;
			}
			gameObject.SetActive(false);
			HideCallback?.Invoke();
			HideCallback = null;
		}
	}
}
