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
	}

	public void Set(int questorder)
	{
	}

	private string GetQuestDesc(params object[] args)
	{
		return null;
	}

	public void UpdateValue()
	{
	}

	private void OnClickComplete()
	{
	}

	public void Reset()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClickShortcut()
	{
	}
}
