using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemCatstagram : MonoBehaviour
{
	[SerializeField]
	private GameObject MainRoot;

	[SerializeField]
	private GameObject EventRoot;

	[Header("Main")]
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Image CatstaBg;

	[SerializeField]
	private Button Btn;

	[Header("Event")]
	[SerializeField]
	private Image CatstaImg;

	[SerializeField]
	private GameObject DimObj;

	[Header("Reward")]
	[SerializeField]
	private GameObject RewardGemRoot;

	private int CatstaOrder;

	private int EventCatstaIdx;

	public Action<int> ClickAction;

	private void Awake()
	{
	}

	public void Set(int order)
	{
	}

	public void Refresh()
	{
	}

	private void OnClickBtn()
	{
	}

	private void OnClickGemBtn()
	{
	}

	public void SetEvent(int idx)
	{
	}

	private void OnClickEventBtn()
	{
	}

	private int GetLogCnt(int targetIdx)
	{
		return 0;
	}
}
