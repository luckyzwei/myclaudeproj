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
	}

	public void SetStageInfo(int slotStageIdx)
	{
	}

	public void SetState(E_SlotState state, bool bPlayAnim)
	{
	}

	public E_SlotState GetSlotState(int slotStageIdx, int curStageIdx)
	{
		return default(E_SlotState);
	}

	private string GetBusinessImageName(int stageIdx)
	{
		return null;
	}

	private void SetActiveClearObj(bool isActive, bool bPlayAnim)
	{
	}

	private void SetActiveCurrentBubble(bool isActive, bool bPlayAnim)
	{
	}
}
