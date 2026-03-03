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
	}

	private void OnDestroy()
	{
	}

	public void Init()
	{
	}

	public void Reset()
	{
	}

	public void UpdateJewelryBoxValue()
	{
	}

	private void SetJewelryBoxIcon(int stageStep, bool isFull)
	{
	}

	private void OnClickJewelryBoxBtn()
	{
	}
}
