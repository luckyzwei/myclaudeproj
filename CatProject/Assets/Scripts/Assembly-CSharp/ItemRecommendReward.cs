using UnityEngine;
using UnityEngine.UI;

public class ItemRecommendReward : MonoBehaviour
{
	[SerializeField]
	private ItemArticle ItemArticle;

	[SerializeField]
	private Button CountBtn;

	[SerializeField]
	private ProgressText ProgressText;

	[SerializeField]
	private Button ReceiveBtn;

	[SerializeField]
	private GameObject DoneObj;

	private int idx;

	private void Awake()
	{
		if (ReceiveBtn != null)
			ReceiveBtn.onClick.AddListener(OnClickReward);
	}

	public void UpdateItem(int _idx)
	{
		idx = _idx;
	}

	private void OnClickReward()
	{
		// Handle click
	}
}
