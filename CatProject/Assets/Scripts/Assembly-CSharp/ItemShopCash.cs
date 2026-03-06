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
		if (Btn != null) Btn.onClick.AddListener(OnClickItem);
	}

	public void Init(int idx)
	{
		Idx = idx;
		DrawInfo();
	}

	private void DrawInfo()
	{
		// TODO
	}

	private void OnClickItem()
	{
		clickAction?.Invoke(Idx);
	}
}
