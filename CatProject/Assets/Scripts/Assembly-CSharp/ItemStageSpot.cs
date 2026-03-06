using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemStageSpot : MonoBehaviour
{
	[SerializeField]
	private Button stageBtn;

	[SerializeField]
	private Image bgImg;

	[SerializeField]
	private GameObject[] lockHideObjArr;

	[SerializeField]
	private Text Stage;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Image Icon;

	private int stage;

	private bool isLock;

	public Action<int, Transform> OnClick;

	private void Awake()
	{
		if (stageBtn != null)
			stageBtn.onClick.AddListener(OnClickStage);
	}

	public void SetStage(int stage)
	{
		this.stage = stage;
		if (Stage != null)
			Stage.text = stage.ToString();
	}

	private void OnClickStage()
	{
		if (!isLock)
			OnClick?.Invoke(stage, transform);
	}
}
