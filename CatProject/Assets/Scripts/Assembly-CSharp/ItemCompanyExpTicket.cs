using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;
using UnityEngine.UI;

public class ItemCompanyExpTicket : MonoBehaviour
{
	[SerializeField]
	private ItemArticle ItemArticle;

	[SerializeField]
	protected Text ExpValueText;

	[SerializeField]
	private GameObject SelectedObj;

	[SerializeField]
	private Button SelectButton;

	public Action<int> OnSelectButtonClickEvent;

	public int ItemIdx { get; private set; }

	private void Awake()
	{
		if (SelectButton != null) SelectButton.onClick.AddListener(OnSelectButtonClick);
	}

	public void Set(int itemIdx, BigInteger hasValue)
	{
		ItemIdx = itemIdx;
	}

	public void SetSelected(bool isSelected)
	{
		if (SelectedObj != null) SelectedObj.SetActive(isSelected);
	}

	private void OnSelectButtonClick()
	{
		OnSelectButtonClickEvent?.Invoke(ItemIdx);
	}
}
