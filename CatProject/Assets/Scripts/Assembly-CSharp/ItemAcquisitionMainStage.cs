using Treeplla;
using UnityEngine;
using UnityEngine.UI;

public class ItemAcquisitionMainStage : MonoBehaviour
{
	[SerializeField]
	private Text StageIdxText;

	[SerializeField]
	private GameObject LeftLineObj;

	[SerializeField]
	private GameObject RightLineObj;

	[SerializeField]
	private GameObject BossStageObj;

	[SerializeField]
	private GameObject CurStageObj;

	[SerializeField]
	private GameObject ClearStageObj;

	public void SetData(AcquisitionInfoData acqData, int curStageIdx)
	{
	}
}
