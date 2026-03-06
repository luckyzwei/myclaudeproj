using Treeplla;
using UnityEngine;

public class FactoryBuilding : MonoBehaviour
{
	[SerializeField]
	private GameObject UnLockObj;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private Transform UITrans;

	[SerializeField]
	private Transform OpenUITrans;

	[SerializeField]
	private GameObject OpenEffect;

	private bool isOpen;

	private InGameOpenFactory OpenUI;

	private InGameFactoryProductionUI CooltimeUI;

	private FactoryBuildingData FactoryData;

	public int FactoryIdx { get; private set; }

	public void Init(int idx)
	{
		FactoryIdx = idx;
		var userData = Singleton<GameRoot>.Instance.UserData;
		if (userData == null || userData.FactoryData == null) return;
		SetOpen();
	}

	private void SetOpen()
	{
		if (FactoryData == null) return;
		bool open = FactoryData.Level > 0;
		isOpen = open;
		if (UnLockObj != null) UnLockObj.SetActive(open);
		if (LockObj != null) LockObj.SetActive(!open);
	}

	private void UpdateLevel(int level)
	{
		if (FactoryData == null) return;
		SetOpen();
	}

	private void SelectProduct(int idx)
	{
		if (FactoryData == null) return;
	}

	private void UpdateLack(bool isLack)
	{
	}

	private void UpdateFull(bool isFull)
	{
	}

	public void OnClick()
	{
		if (!isOpen)
		{
			if (OpenUI != null) OpenUI.gameObject.SetActive(true);
			return;
		}
		Singleton<GameRoot>.Instance?.WaitAndOpenUICoroutine<PopupFactoryWorkPlace>();
		PlaySound();
	}

	private void PlaySound()
	{
	}

	protected virtual void Update()
	{
	}
}
