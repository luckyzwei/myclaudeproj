using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemPlant : MonoBehaviour
{
	[Header("Info")]
	[SerializeField]
	private Image PlantImg;

	[SerializeField]
	private Text PlantName;

	[SerializeField]
	private Text PlantLevel;

	[Header("Ability")]
	[SerializeField]
	private Image AbilityIcon;

	[SerializeField]
	private Text AbilityValue;

	[Header("Reddot")]
	[SerializeField]
	private GameNotificationMultiRegister Reddot;

	[SerializeField]
	private GameObject NewObj;

	[Header("GemReward")]
	[SerializeField]
	private GameObject GemRewardObj;

	[SerializeField]
	private Text GemRewardCount;

	[SerializeField]
	private Button GemRewardBtn;

	[Header("Btn")]
	[SerializeField]
	private Button ManageBtn;

	[SerializeField]
	private Button PreviewBtn;

	[Header("State Obj")]
	[SerializeField]
	private GameObject ManageBtnObj;

	[SerializeField]
	private GameObject DecoObj;

	private int Idx;

	public Action<int> clickCb;

	private IDisposable GemTimeDisposable;

	private void Awake()
	{
		if (ManageBtn != null) ManageBtn.onClick.AddListener(OnClickManage);
		if (PreviewBtn != null) PreviewBtn.onClick.AddListener(OnClickPreview);
		if (GemRewardBtn != null) GemRewardBtn.onClick.AddListener(OnClickGemReward);
	}

	private void OnDisable()
	{
		if (GemTimeDisposable != null) { GemTimeDisposable.Dispose(); GemTimeDisposable = null; }
	}

	public void Set(int plantidx)
	{
		Idx = plantidx;
	}

	private void OnClickPreview()
	{
		clickCb?.Invoke(Idx);
	}

	private void OnClickManage()
	{
		clickCb?.Invoke(Idx);
	}

	private void OnClickGemReward()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null) return;
	}
}
