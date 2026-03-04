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
	}

	public void Set(int itemIdx, BigInteger hasValue)
	{
	}

	public void SetSelected(bool isSelected)
	{
	}

	private void OnSelectButtonClick()
	{
	}
}
