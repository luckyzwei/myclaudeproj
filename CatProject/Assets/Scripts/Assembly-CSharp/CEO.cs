using System;
using Treeplla;
using UnityEngine;

public class CEO : Worker
{
	[HideInInspector]
	public int TutoRepairOfficeIdx;

	public void Init(E_AppearType appearType, int order)
	{
		WorkerType = E_WorkerType.Ceo;
		WorkerInit();
		LoadChar(() =>
		{
			ChangeState(E_State.Idle);
		});
	}

	public void OnChangeCostume()
	{
		UnloadChar();
		LoadChar(() =>
		{
			ChangeState(E_State.Idle, true);
		});
	}

	private void LoadChar(Action LoadComp)
	{
		if (CharLoadObj == null)
			CharLoadObj = new AddressableLoadGameObject();

		var userData = Singleton<GameRoot>.Instance.UserData;
		int costumeIdx = 0;
		if (userData != null && userData.CeoCostumeData != null)
			costumeIdx = userData.CeoCostumeData.EquippedCostumeIdx;

		string key = string.Format("Character/Ceo_{0}", costumeIdx);
		CharLoadObj.InstantiateAsync(key, CharRoot, false, (go) =>
		{
			if (go != null)
			{
				CharAni = go.GetComponent<Animator>();
			}
			LoadComp?.Invoke();
		});
	}

	public override void GotoRepairOffice(int OfficeIdx)
	{
		TutoRepairOfficeIdx = OfficeIdx;
		TargetOffice = OfficeIdx;
		base.GotoRepairOffice(OfficeIdx);
	}

	public override void WorkOut(int order, bool outcompany = false)
	{
		ChangeState(E_State.Workoff);
		if (outcompany)
			GotoWorkOffBus(order);
	}
}
