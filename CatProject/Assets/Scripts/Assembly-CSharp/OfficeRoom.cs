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
		BoosterOfficeEffect = GetComponentInChildren<BoosterOfficeEffect>();
	}

	public override void Init(int officeIndex)
	{
		base.Init(officeIndex);
		InitFindManagerUI();
	}

	public Transform GetSeat(int seat)
	{
		if (CharTrans == null || seat < 0 || seat >= CharTrans.Count) return null;
		return CharTrans[seat];
	}

	protected override void SetOpened(bool value)
	{
		gameObject.SetActive(value);
	}

	public override void OnClickOffice()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null) return;
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
