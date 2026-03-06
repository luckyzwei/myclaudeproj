using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemDailyQuest : MonoBehaviour
{
	[SerializeField]
	private Text RewardCount;

	[SerializeField]
	private Text Desc;

	[SerializeField]
	private Slider Progress;

	[SerializeField]
	private Text ProgressValue;

	[SerializeField]
	private Button ShortcutBtn;

	[SerializeField]
	private Button GetBtn;

	[SerializeField]
	private GameObject ReceiveObj;

	[Header("OneTimeEvent")]
	[SerializeField]
	private OnetimeCurrencyComponent oneTimeComponent;

	public Action<int> CompleteAction;

	public Action<int> ShortcutAction;

	private int Order;

	private CompositeDisposable disposables;

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (GetBtn != null) GetBtn.onClick.AddListener(OnClickComplete);
		if (ShortcutBtn != null) ShortcutBtn.onClick.AddListener(OnClickShortcut);
	}

	public void Set(int questorder)
	{
		Order = questorder;
		if (ReceiveObj != null) ReceiveObj.SetActive(false);
		if (oneTimeComponent != null) oneTimeComponent.gameObject.SetActive(false);
		UpdateValue();
	}

	private string GetQuestDesc(params object[] args)
	{
		return "";
	}

	public void UpdateValue()
	{
		if (Progress != null) Progress.value = 0f;
		if (ProgressValue != null) ProgressValue.text = "0/0";
	}

	private void OnClickComplete()
	{
		CompleteAction?.Invoke(Order);
	}

	public void Reset()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnClickShortcut()
	{
		ShortcutAction?.Invoke(Order);
	}
}
