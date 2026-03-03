using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopCash : MonoBehaviour
{
	[SerializeField]
	private Text Name;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Count;

	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Text Price;

	[Header("Promotion")]
	[SerializeField]
	private Text PromotionCount;

	[SerializeField]
	private Text PromotionChanceCount;

	[SerializeField]
	private List<GameObject> PromotionObjs;

	public Action<int> clickAction;

	public int Idx { get; private set; }

	private void Awake()
	{
	}

	public void Init(int idx)
	{
	}

	private void DrawInfo()
	{
	}

	private void OnClickItem()
	{
	}
}
