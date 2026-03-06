using UnityEngine;
using UnityEngine.UI;

public class ItemAcquisitionStageSlot : MonoBehaviour
{
	public enum E_SlotState
	{
		None = 0,
		Clear = 1,
		Current = 2,
		Next = 3
	}

	[SerializeField]
	private Image StageImage;

	[SerializeField]
	private AutoPlayBubble CurrentBubble;

	[SerializeField]
	private Text CurrentStageNameText;

	[SerializeField]
	private Text CurrentStageIdxText;

	[SerializeField]
	private GameObject ClearObj;

	[SerializeField]
	private Animator ClearAnimator;

	private const string BUSINESS_IMAGE_NAME = "Acquisition_Icon_Building_Front{0:D2}";

	public void Init(int slotStageIdx)
	{
		SetStageInfo(slotStageIdx);
	}

	public void SetStageInfo(int slotStageIdx)
	{
		// Update display
	}

	public void SetState(E_SlotState state, bool bPlayAnim)
	{
		SetActiveClearObj(state == E_SlotState.Clear, bPlayAnim);
		SetActiveCurrentBubble(state == E_SlotState.Current, bPlayAnim);
	}

	public E_SlotState GetSlotState(int slotStageIdx, int curStageIdx)
	{
		if (slotStageIdx < curStageIdx) return E_SlotState.Clear;
		if (slotStageIdx == curStageIdx) return E_SlotState.Current;
		if (slotStageIdx == curStageIdx + 1) return E_SlotState.Next;
		return E_SlotState.None;
	}

	private string GetBusinessImageName(int stageIdx)
	{
		return string.Format(BUSINESS_IMAGE_NAME, stageIdx);
	}

	private void SetActiveClearObj(bool isActive, bool bPlayAnim)
	{
		if (ClearObj != null) ClearObj.SetActive(isActive);
		if (isActive && bPlayAnim && ClearAnimator != null) ClearAnimator.SetTrigger("Clear");
	}

	private void SetActiveCurrentBubble(bool isActive, bool bPlayAnim)
	{
		if (CurrentBubble != null) CurrentBubble.gameObject.SetActive(isActive);
	}
}
