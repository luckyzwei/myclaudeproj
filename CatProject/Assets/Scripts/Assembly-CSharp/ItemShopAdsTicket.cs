using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemShopAdsTicket : MonoBehaviour
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text Time;

	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Text Price;

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
