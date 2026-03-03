using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotRecommend : MonoBehaviour
{
	[SerializeField]
	public ItemCompany ItemCompany;

	[SerializeField]
	private Button AllCompanyMaxLvShortCutBtn;

	[SerializeField]
	private Button NoAdsPurchaseBtn;

	[SerializeField]
	private Button UnlockCompanyShortCutBtn;

	[SerializeField]
	private GameObject AdsUserObj;

	[SerializeField]
	private GameObject CompanyObj;

	[SerializeField]
	private GameObject AllCompanyMaxObj;

	[SerializeField]
	private GameObject UnlockCompanyObj;

	[SerializeField]
	private GameObject AllContractObj;

	private List<GameObject> ActiveObjList;

	private E_ItemSlotRecommendState SlotState;

	private void Awake()
	{
	}

	public void SetSlotState(E_ItemSlotRecommendState state)
	{
	}

	private void OnClickedCompanyMaxLvShortCutBtn()
	{
	}

	private void OnClickedNoAdsPurchaseBtn()
	{
	}

	private void OnClickedUnlockCompanyShortCutBtn()
	{
	}

	private void RefreshCompanyContract()
	{
	}
}
