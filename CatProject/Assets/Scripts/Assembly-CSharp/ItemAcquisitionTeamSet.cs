using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemAcquisitionTeamSet : MonoBehaviour
{
	[SerializeField]
	private Button ConfirmButton;

	[SerializeField]
	private Button DimConfirmButton;

	[SerializeField]
	private Button AutoSetButton;

	[SerializeField]
	private List<ItemAcquisitionCEO> MyTeamList;

	[SerializeField]
	private RecycleScrollRect CeoScrollRect;

	private List<ManagerCardData> HasCeoList;

	private bool IsTeamSetMode;

	public Action OnChangedTeamDataEvent;

	public Action OnHideCallback;

	private void Awake()
	{
		HasCeoList = new List<ManagerCardData>();

		if (ConfirmButton != null) ConfirmButton.onClick.AddListener(OnClickedConfirmBtn);
		if (DimConfirmButton != null) DimConfirmButton.onClick.AddListener(OnClickedConfirmBtn);
		if (AutoSetButton != null) AutoSetButton.onClick.AddListener(OnClickedAutoSetBtn);
	}

	public void OnDisable()
	{
		IsTeamSetMode = false;
	}

	public void SetTeamData()
	{
		UpdateTeamData();
		if (MyTeamList != null)
		{
			for (int i = 0; i < MyTeamList.Count; i++)
			{
				if (MyTeamList[i] != null)
				{
					int slotIdx = i;
					MyTeamList[i].OnClickedSlotButtonEvent = (ceoIdx, slot) => OnClickedTeamCeoItem(ceoIdx, slot);
				}
			}
		}
	}

	public void SetTeamSetMode(bool isTeamSetMode)
	{
		IsTeamSetMode = isTeamSetMode;
		if (ConfirmButton != null) ConfirmButton.gameObject.SetActive(isTeamSetMode);
		if (DimConfirmButton != null) DimConfirmButton.gameObject.SetActive(!isTeamSetMode);
		if (AutoSetButton != null) AutoSetButton.gameObject.SetActive(isTeamSetMode);
	}

	public void SetAllCeoList()
	{
		HasCeoList.Clear();
		RefreshCeoList();
	}

	public void RefreshCeoList()
	{
		// Update display
	}

	private void UpdateTeamData()
	{
		if (MyTeamList == null) return;
		for (int i = 0; i < MyTeamList.Count; i++)
		{
			if (MyTeamList[i] != null)
				MyTeamList[i].SetEmpty();
		}
	}

	private void OnClickedConfirmBtn()
	{
		OnChangedTeamDataEvent?.Invoke();
		OnHideCallback?.Invoke();
	}

	private void OnClickedAutoSetBtn()
	{
		UpdateTeamData();
		RefreshCeoList();
	}

	private void OnClickedTeamCeoItem(int ceoIdx, int slotIdx)
	{
		if (!IsTeamSetMode) return;
		if (ceoIdx > 0)
		{
			RemoveFromTeam(ceoIdx);
		}
	}

	private void OnClickedCeoListItem(int ceoIdx, int slotIdx)
	{
		if (!IsTeamSetMode) return;
		AddToTeam(ceoIdx);
	}

	private void AddToTeam(int ceoIdx)
	{
		UpdateTeamData();
		RefreshCeoList();
	}

	private void RemoveFromTeam(int ceoIdx)
	{
		UpdateTeamData();
		RefreshCeoList();
	}

	private ItemAcquisitionCEO FindHasCeoItem(int ceoIdx)
	{
		if (MyTeamList == null) return null;
		for (int i = 0; i < MyTeamList.Count; i++)
		{
			if (MyTeamList[i] != null && MyTeamList[i].CeoIdx == ceoIdx)
				return MyTeamList[i];
		}
		return null;
	}
}
