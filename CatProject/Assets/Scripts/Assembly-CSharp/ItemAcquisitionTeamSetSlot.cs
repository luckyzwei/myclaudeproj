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
		if (ReleaseButton != null) ReleaseButton.onClick.AddListener(OnClickedReleaseButton);
	}

	public void SetData(BizAcqCharacterData ceoData, int slotNumber)
	{
		if (ceoData == null) { SetEmpty(); return; }
		CeoIdx = ceoData.CeoIdx;
		if (SlotNumberText != null) SlotNumberText.text = slotNumber.ToString();
		if (CeoObj != null) CeoObj.SetActive(true);
		if (EmptyObj != null) EmptyObj.SetActive(false);
		if (ReleaseButton != null) ReleaseButton.gameObject.SetActive(true);
	}

	public void SetEmpty()
	{
		CeoIdx = 0;
		if (CeoObj != null) CeoObj.SetActive(false);
		if (EmptyObj != null) EmptyObj.SetActive(true);
		if (ReleaseButton != null) ReleaseButton.gameObject.SetActive(false);
	}

	private void OnClickedReleaseButton()
	{
		if (CeoIdx <= 0) return;
		OnClickedReleaseButtonEvent?.Invoke(CeoIdx);
	}
}
