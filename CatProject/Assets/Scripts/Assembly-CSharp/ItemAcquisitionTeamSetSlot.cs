using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemAcquisitionTeamSetSlot : MonoBehaviour
{
	[SerializeField]
	private Image CeoImage;

	[SerializeField]
	private Text SlotNumberText;

	[SerializeField]
	private GameObject CeoObj;

	[SerializeField]
	private GameObject EmptyObj;

	[SerializeField]
	private Button ReleaseButton;

	public Action<int> OnClickedReleaseButtonEvent;

	public int CeoIdx { get; private set; }

	private void Awake()
	{
	}

	public void SetData(BizAcqCharacterData ceoData, int slotNumber)
	{
	}

	public void SetEmpty()
	{
	}

	private void OnClickedReleaseButton()
	{
	}
}
