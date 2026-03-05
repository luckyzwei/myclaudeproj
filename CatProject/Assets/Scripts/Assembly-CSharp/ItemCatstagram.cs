using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemCatstagram : MonoBehaviour
{
	[SerializeField]
	private GameObject MainRoot;

	[SerializeField]
	private GameObject EventRoot;

	[Header("Main")]
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Image CatstaBg;

	[SerializeField]
	private Button Btn;

	[Header("Event")]
	[SerializeField]
	private Image CatstaImg;

	[SerializeField]
	private GameObject DimObj;

	[Header("Reward")]
	[SerializeField]
	private GameObject RewardGemRoot;

	private int CatstaOrder;

	private int EventCatstaIdx;

	public Action<int> ClickAction;

	private void Awake()
	{
		if (Btn != null) Btn.onClick.AddListener(OnClickBtn);
	}

	public void Set(int order)
	{
		CatstaOrder = order;
		if (MainRoot != null) MainRoot.SetActive(true);
		if (EventRoot != null) EventRoot.SetActive(false);
		Refresh();
	}

	public void Refresh()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.CatstaData == null) return;
		if (CatstaOrder < 0 || CatstaOrder >= root.UserData.CatstaData.Count) return;
		var data = root.UserData.CatstaData[CatstaOrder];
		if (data == null) return;
		bool hasReward = data.Like && !data.GetReward;
		if (RewardGemRoot != null) RewardGemRoot.SetActive(hasReward);
	}

	private void OnClickBtn()
	{
		ClickAction?.Invoke(CatstaOrder);
	}

	private void OnClickGemBtn()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.CatstaData == null) return;
		if (CatstaOrder < 0 || CatstaOrder >= root.UserData.CatstaData.Count) return;
		var data = root.UserData.CatstaData[CatstaOrder];
		if (data != null && data.Like && !data.GetReward)
		{
			data.GetReward = true;
			Refresh();
		}
	}

	public void SetEvent(int idx)
	{
		EventCatstaIdx = idx;
		if (MainRoot != null) MainRoot.SetActive(false);
		if (EventRoot != null) EventRoot.SetActive(true);
		if (DimObj != null) DimObj.SetActive(false);
	}

	private void OnClickEventBtn()
	{
		ClickAction?.Invoke(EventCatstaIdx);
	}

	private int GetLogCnt(int targetIdx)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.CatstaData == null) return 0;
		int count = 0;
		for (int i = 0; i < root.UserData.CatstaData.Count; i++)
		{
			if (root.UserData.CatstaData[i] != null && root.UserData.CatstaData[i].Idx == targetIdx)
				count++;
		}
		return count;
	}
}
