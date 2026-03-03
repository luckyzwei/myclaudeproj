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
	}

	public void SetIconState(E_SlotState slotState)
	{
	}

	private void OnClickedSlotButton()
	{
	}
}
