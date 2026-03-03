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
	}

	public void UpdateExclamation()
	{
	}

	public void Init(E_AppearType appearType, int order)
	{
	}

	protected override void UpdateFloor()
	{
	}

	private void LoadUI()
	{
	}

	private void UpdateSecretaryAlarm()
	{
	}

	public void AddMaxOffice(int office, int company)
	{
	}

	public void DelMaxOffice(int office, int company)
	{
	}

	public void DelNotEnoughItemOffice(int office)
	{
	}

	protected override void ChangeState(E_State _state, bool isForce = false)
	{
	}

	private void OnClickExclamation()
	{
	}

	public override void WorkOut(int order, bool outcompany = false)
	{
	}

	public override void Return()
	{
	}
}
