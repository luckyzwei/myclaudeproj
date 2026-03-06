using System;
using UnityEngine;
using UnityEngine.UI;

public class HUDJewelryBoxComponent : MonoBehaviour
{
	[SerializeField]
	private Button OpenBtn;

	[SerializeField]
	private Text AccumulateCount;

	[SerializeField]
	private Image JewelryBoxIcon;

	[SerializeField]
	private GameObject RedDotObj;

	[SerializeField]
	private DoTweenScriptComponent FullNoticeTween;

	private string CurIconResName;

	private IDisposable Disposable;

	private void Awake()
	{
		if (OpenBtn != null)
			OpenBtn.onClick.AddListener(OnClickJewelryBoxBtn);
	}

	private void OnDestroy()
	{
		if (Disposable != null)
		{
			Disposable.Dispose();
			Disposable = null;
		}
	}

	public void Init()
	{
		CurIconResName = null;
		UpdateJewelryBoxValue();
	}

	public void Reset()
	{
		if (AccumulateCount != null)
			AccumulateCount.text = "0";
		if (RedDotObj != null)
			RedDotObj.SetActive(false);
		CurIconResName = null;
	}

	public void UpdateJewelryBoxValue()
	{
		// Update accumulate count and icon from jewelry box data
		if (RedDotObj != null)
			RedDotObj.SetActive(false);
	}

	private void SetJewelryBoxIcon(int stageStep, bool isFull)
	{
		// Set icon based on current stage step and full state
		if (isFull && FullNoticeTween != null)
			FullNoticeTween.Play();
	}

	private void OnClickJewelryBoxBtn()
	{
	}
}
