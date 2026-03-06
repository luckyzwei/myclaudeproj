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
		ActiveObjList = new List<GameObject> { AdsUserObj, CompanyObj, AllCompanyMaxObj, UnlockCompanyObj, AllContractObj };
		if (AllCompanyMaxLvShortCutBtn != null)
			AllCompanyMaxLvShortCutBtn.onClick.AddListener(OnClickedCompanyMaxLvShortCutBtn);
		if (NoAdsPurchaseBtn != null)
			NoAdsPurchaseBtn.onClick.AddListener(OnClickedNoAdsPurchaseBtn);
		if (UnlockCompanyShortCutBtn != null)
			UnlockCompanyShortCutBtn.onClick.AddListener(OnClickedUnlockCompanyShortCutBtn);
	}

	public void SetSlotState(E_ItemSlotRecommendState state)
	{
		SlotState = state;
		if (ActiveObjList != null)
		{
			for (int i = 0; i < ActiveObjList.Count; i++)
			{
				if (ActiveObjList[i] != null)
					ActiveObjList[i].SetActive(false);
			}
		}
		switch (state)
		{
			case E_ItemSlotRecommendState.AdsUser:
				if (AdsUserObj != null) AdsUserObj.SetActive(true);
				break;
			case E_ItemSlotRecommendState.RecommendCompany:
				if (CompanyObj != null) CompanyObj.SetActive(true);
				break;
			case E_ItemSlotRecommendState.RecommendCompany_AllContract:
				if (AllContractObj != null) AllContractObj.SetActive(true);
				break;
			case E_ItemSlotRecommendState.AllCompanyMax_UnlockableCompExist:
				if (UnlockCompanyObj != null) UnlockCompanyObj.SetActive(true);
				break;
			case E_ItemSlotRecommendState.AllCompanyMax:
				if (AllCompanyMaxObj != null) AllCompanyMaxObj.SetActive(true);
				break;
		}
	}

	private void OnClickedCompanyMaxLvShortCutBtn()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void OnClickedNoAdsPurchaseBtn()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupNoAds>();
	}

	private void OnClickedUnlockCompanyShortCutBtn()
	{
		Treeplla.Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupShop>();
	}

	private void RefreshCompanyContract()
	{
		if (ItemCompany != null) ItemCompany.gameObject.SetActive(true);
	}
}
