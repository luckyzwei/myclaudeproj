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
		base.Init(office);
		WaitingEmployees = new Queue<Employee>();
	}

	public void AddToWaitLine(Employee employee)
	{
		if (employee == null) return;
		WaitingEmployees.Enqueue(employee);
		employee.SetWaitLine(WaitingLine);
		employee.SetWaitNum(WaitingEmployees.Count - 1);
		UpdateWaitNum();
	}

	protected Employee DequeueEmployee()
	{
		if (WaitingEmployees == null || WaitingEmployees.Count == 0) return null;
		var emp = WaitingEmployees.Dequeue();
		UpdateWaitNum();
		return emp;
	}

	public virtual void CallNextEmployee()
	{
		DequeueEmployee();
	}

	public virtual void ResetInUseItem()
	{
	}

	public override void EndRepairing()
	{
		base.EndRepairing();
	}

	public virtual bool isInUse()
	{
		return WaitingEmployees != null && WaitingEmployees.Count > 0;
	}

	private void UpdateWaitNum()
	{
		if (WaitingEmployees == null) return;
		int num = 0;
		foreach (var emp in WaitingEmployees)
		{
			if (emp != null) emp.SetWaitNum(num);
			num++;
		}
	}
}
