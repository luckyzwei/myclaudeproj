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
	}

	public void OnDisable()
	{
	}

	public void SetTeamData()
	{
	}

	public void SetTeamSetMode(bool isTeamSetMode)
	{
	}

	public void SetAllCeoList()
	{
	}

	public void RefreshCeoList()
	{
	}

	private void UpdateTeamData()
	{
	}

	private void OnClickedConfirmBtn()
	{
	}

	private void OnClickedAutoSetBtn()
	{
	}

	private void OnClickedTeamCeoItem(int ceoIdx, int slotIdx)
	{
	}

	private void OnClickedCeoListItem(int ceoIdx, int slotIdx)
	{
	}

	private void AddToTeam(int ceoIdx)
	{
	}

	private void RemoveFromTeam(int ceoIdx)
	{
	}

	private ItemAcquisitionCEO FindHasCeoItem(int ceoIdx)
	{
		return null;
	}
}
