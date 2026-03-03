using System.Collections.Generic;
using UnityEngine;

public class WaitingRoom : Room
{
	[SerializeField]
	public Transform WaitStartTrans;

	[SerializeField]
	private InGamePath WaitingLine;

	protected Queue<Employee> WaitingEmployees;

	public override void Init(int office)
	{
	}

	public void AddToWaitLine(Employee employee)
	{
	}

	protected Employee DequeueEmployee()
	{
		return null;
	}

	public virtual void CallNextEmployee()
	{
	}

	public virtual void ResetInUseItem()
	{
	}

	public override void EndRepairing()
	{
	}

	public virtual bool isInUse()
	{
		return false;
	}

	private void UpdateWaitNum()
	{
	}
}
