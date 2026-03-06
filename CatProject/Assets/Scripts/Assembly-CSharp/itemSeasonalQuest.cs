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
		if (btnReceive != null)
			btnReceive.onClick.AddListener(OnClickReceive);
	}

	public void Set(int _tableIdx)
	{
		tableIdx = _tableIdx;
		if (lockObj != null)
			lockObj.SetActive(IsLocked);
		if (clearObj != null)
			clearObj.SetActive(false);
	}

	public bool IsActiveSlot()
	{
		return !IsLocked;
	}

	public bool IsLockedSlot()
	{
		return IsLocked;
	}

	private void OnClickReceive()
	{
		if (IsLocked) return;
	}
}
