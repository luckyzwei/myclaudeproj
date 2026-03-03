using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemSeasonalQuest : MonoBehaviour
{
	[SerializeField]
	private Text textRewardPoint;

	[SerializeField]
	private List<ItemArticle> listItemArticle;

	[SerializeField]
	private Button btnReceive;

	[SerializeField]
	private GameObject lockObj;

	[SerializeField]
	private GameObject clearObj;

	[SerializeField]
	private GameObject reddot;

	private int tableIdx;

	private bool IsLocked;

	private void Awake()
	{
	}

	public void Set(int _tableIdx)
	{
	}

	public bool IsActiveSlot()
	{
		return false;
	}

	public bool IsLockedSlot()
	{
		return false;
	}

	private void OnClickReceive()
	{
	}
}
