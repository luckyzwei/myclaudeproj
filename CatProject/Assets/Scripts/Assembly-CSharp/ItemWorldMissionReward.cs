using UnityEngine;
using UnityEngine.UI;

public class ItemWorldMissionReward : MonoBehaviour
{
	[Header("State")]
	[SerializeField]
	private GameObject obj_active;

	[SerializeField]
	private GameObject obj_after;

	[Header("Info")]
	[SerializeField]
	private Text text_need_point;

	[SerializeField]
	private Text text_reward_count;

	[SerializeField]
	private Image icon_reward;

	[SerializeField]
	private Image icon_reward_received;

	[SerializeField]
	private Image icon_reward_active;

	[Header("Button")]
	[SerializeField]
	private Button btn_reward;

	private int _idx;

	private bool isReceived;

	private int needPoint;

	private void Awake()
	{
	}

	public void SetInfo(int rewardIndex)
	{
	}

	public void SetState()
	{
	}

	private void OnClickReward()
	{
	}
}
