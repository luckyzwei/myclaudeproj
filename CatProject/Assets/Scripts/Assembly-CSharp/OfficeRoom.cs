using System.Collections.Generic;
using UnityEngine;

public class OfficeRoom : Room
{
	[SerializeField]
	private List<Transform> CharTrans;

	[SerializeField]
	private Transform managerDeskTrans;

	private BoosterOfficeEffect BoosterOfficeEffect;

	public Transform ManagerDeskTrans => null;

	private void Awake()
	{
	}

	public override void Init(int officeIndex)
	{
	}

	public Transform GetSeat(int seat)
	{
		return null;
	}

	protected override void SetOpened(bool value)
	{
	}

	public override void OnClickOffice()
	{
	}

	private void InitFindManagerUI()
	{
	}

	public void UseFindManagerUI()
	{
	}

	private void LoadFindManagerUI()
	{
	}

	public void SetBoosterOfficeEffectMoney(bool isActive)
	{
	}

	public void SetBoosterOfficeEffectExp(bool isActive)
	{
	}
}
