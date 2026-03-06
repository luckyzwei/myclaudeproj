using System;
using System.Collections.Generic;
using UnityEngine;

public class Secretary : Worker
{
	[Serializable]
	private class OfficeStatus
	{
		public Config.SecretaryConversationType type;

		public int target;
	}

	[SerializeField]
	private Animator Charcater;

	private InGameExclamationUI ExclamationUI;

	private List<OfficeStatus> Alarms;

	private bool isActiveExclamation;

	private void Awake()
	{
		Alarms = new List<OfficeStatus>();
		isActiveExclamation = false;
	}

	public void UpdateExclamation()
	{
		bool shouldShow = Alarms != null && Alarms.Count > 0;
		if (shouldShow != isActiveExclamation)
		{
			isActiveExclamation = shouldShow;
			if (ExclamationUI != null)
				ExclamationUI.gameObject.SetActive(isActiveExclamation);
		}
	}

	public void Init(E_AppearType appearType, int order)
	{
		WorkerType = E_WorkerType.Secretary;
		WorkerInit();
		Alarms = new List<OfficeStatus>();
		isActiveExclamation = false;
		LoadUI();
		ChangeState(E_State.Idle);
	}

	protected override void UpdateFloor()
	{
	}

	private void LoadUI()
	{
	}

	private void UpdateSecretaryAlarm()
	{
		UpdateExclamation();
	}

	public void AddMaxOffice(int office, int company)
	{
		if (Alarms == null)
			Alarms = new List<OfficeStatus>();

		for (int i = 0; i < Alarms.Count; i++)
		{
			if (Alarms[i].type == Config.SecretaryConversationType.Guide && Alarms[i].target == office)
				return;
		}

		Alarms.Add(new OfficeStatus
		{
			type = Config.SecretaryConversationType.Guide,
			target = office
		});
		UpdateExclamation();
	}

	public void DelMaxOffice(int office, int company)
	{
		if (Alarms == null) return;

		for (int i = Alarms.Count - 1; i >= 0; i--)
		{
			if (Alarms[i].type == Config.SecretaryConversationType.Guide && Alarms[i].target == office)
			{
				Alarms.RemoveAt(i);
				break;
			}
		}
		UpdateExclamation();
	}

	public void DelNotEnoughItemOffice(int office)
	{
		if (Alarms == null) return;

		for (int i = Alarms.Count - 1; i >= 0; i--)
		{
			if (Alarms[i].target == office)
			{
				Alarms.RemoveAt(i);
				break;
			}
		}
		UpdateExclamation();
	}

	protected override void ChangeState(E_State _state, bool isForce = false)
	{
		base.ChangeState(_state, isForce);
		if (Charcater != null)
		{
			SetAni(_state, dir);
		}
	}

	private void OnClickExclamation()
	{
		if (Alarms == null || Alarms.Count == 0)
			return;

		var alarm = Alarms[0];
		Alarms.RemoveAt(0);
		UpdateExclamation();
	}

	public override void WorkOut(int order, bool outcompany = false)
	{
		ChangeState(E_State.Workoff);
		if (outcompany)
			GotoWorkOffBus(order);
	}

	public override void Return()
	{
		if (ExclamationUI != null)
		{
			ExclamationUI.gameObject.SetActive(false);
		}
		Alarms?.Clear();
		isActiveExclamation = false;
		base.Return();
	}
}
