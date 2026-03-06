using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemWorkshopWorkerFacilitySlot : MonoBehaviour
{
	public enum E_SlotState
	{
		None = 0,
		Hired = 1,
		UnableHire = 2,
		CanBeHired = 3,
		PauseProduction = 4
	}

	[SerializeField]
	private GameObject HiredObj;

	[SerializeField]
	private GameObject CanBeHireObj;

	[SerializeField]
	private GameObject UnableHireObj;

	[SerializeField]
	private GameObject PauseProductionObj;

	[SerializeField]
	private Button SlotButton;

	private List<GameObject> ObjList;

	private E_SlotState SlotState;

	public UnityAction<E_SlotState> OnClickedEvent;

	private void Awake()
	{
		ObjList = new List<GameObject> { HiredObj, CanBeHireObj, UnableHireObj, PauseProductionObj };
		if (SlotButton != null)
			SlotButton.onClick.AddListener(OnClickedSlotButton);
	}

	public void SetIconState(E_SlotState slotState)
	{
		SlotState = slotState;
		if (ObjList != null)
		{
			for (int i = 0; i < ObjList.Count; i++)
			{
				if (ObjList[i] != null)
					ObjList[i].SetActive(false);
			}
		}
		switch (slotState)
		{
			case E_SlotState.Hired:
				if (HiredObj != null) HiredObj.SetActive(true);
				break;
			case E_SlotState.CanBeHired:
				if (CanBeHireObj != null) CanBeHireObj.SetActive(true);
				break;
			case E_SlotState.UnableHire:
				if (UnableHireObj != null) UnableHireObj.SetActive(true);
				break;
			case E_SlotState.PauseProduction:
				if (PauseProductionObj != null) PauseProductionObj.SetActive(true);
				break;
		}
	}

	private void OnClickedSlotButton()
	{
		OnClickedEvent?.Invoke(SlotState);
	}
}
