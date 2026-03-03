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
	}

	private void SetOpen()
	{
	}

	private void UpdateLevel(int level)
	{
	}

	private void SelectProduct(int idx)
	{
	}

	private void UpdateLack(bool isLack)
	{
	}

	private void UpdateFull(bool isFull)
	{
	}

	public void OnClick()
	{
	}

	private void PlaySound()
	{
	}

	protected virtual void Update()
	{
	}
}
