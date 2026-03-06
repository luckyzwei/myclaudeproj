using System.Collections.Generic;
using UnityEngine;

public class OfficeRoom : Room
{
	[SerializeField]
	private List<Transform> CharTrans;

	[SerializeField]
	private Transform managerDeskTrans;

	private BoosterOfficeEffect BoosterOfficeEffect;

	public Transform ManagerDeskTrans { get { return managerDeskTrans; } }

	private void Awake()
	{
	}

	public override void Init(int officeIndex)
	{
		base.Init(officeIndex);
	}

	public Transform GetSeat(int seat)
	{
		if (CharTrans == null || seat < 0 || seat >= CharTrans.Count) return null;
		return CharTrans[seat];
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
		LoadFindManagerUI();
	}

	private void LoadFindManagerUI()
	{
	}

	public void SetBoosterOfficeEffectMoney(bool isActive)
	{
		if (BoosterOfficeEffect != null)
			BoosterOfficeEffect.SetActiveMoneyFx(isActive);
	}

	public void SetBoosterOfficeEffectExp(bool isActive)
	{
		if (BoosterOfficeEffect != null)
			BoosterOfficeEffect.SetActiveExpFx(isActive);
	}
}
