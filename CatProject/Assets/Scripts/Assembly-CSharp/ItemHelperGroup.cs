using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemHelperGroup : MonoBehaviour
{
	[SerializeField]
	private Text packageName;

	[SerializeField]
	private Image img;

	[SerializeField]
	private Image BuffIcon;

	[SerializeField]
	private Text BuffDesc;

	[SerializeField]
	private Button buyBtn;

	[SerializeField]
	private Text buyPriceText;

	public Action HideCb;

	private int packageIdx;

	private void Awake()
	{
	}

	public void Set(int idx)
	{
	}

	private void OnClickBuy()
	{
	}
}
