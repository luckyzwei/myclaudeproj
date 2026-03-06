using UnityEngine;

public class InGameVipCar : MonoBehaviour
{
	private enum Status
	{
		Idle = 0,
		Enter = 1,
		Wait = 2,
		Exit = 3
	}

	[SerializeField]
	private GameObject VipCar;

	[SerializeField]
	private InGamePath Path;

	[SerializeField]
	private Transform StopTrans;

	private int StopIndex;

	private float TargetIndex;

	private float DeltaTime;

	private Status CurStatus;

	private AdSupplyVIP AdSupplyVIP { get { return null; } }

	private void Awake()
	{
		CurStatus = Status.Idle;
		if (VipCar != null) VipCar.SetActive(false);
	}

	private void UpdateStatus(AdSupplySystem.Status status)
	{
		if (status == AdSupplySystem.Status.Show)
		{
			CurStatus = Status.Enter;
			if (VipCar != null) VipCar.SetActive(true);
			TargetIndex = 0f;
		}
		else
		{
			CurStatus = Status.Exit;
		}
	}

	private void Update()
	{
		if (CurStatus == Status.Idle) return;

		DeltaTime += Time.deltaTime;

		if (CurStatus == Status.Enter)
		{
			if (Path != null && Path.TotalDuration > 0f)
			{
				TargetIndex = DeltaTime / Path.TotalDuration;
				if (TargetIndex >= 1f)
				{
					CurStatus = Status.Wait;
					DeltaTime = 0f;
				}
			}
		}
		else if (CurStatus == Status.Exit)
		{
			if (Path != null && Path.TotalDuration > 0f)
			{
				TargetIndex = 1f - (DeltaTime / Path.TotalDuration);
				if (TargetIndex <= 0f)
				{
					CurStatus = Status.Idle;
					DeltaTime = 0f;
					if (VipCar != null) VipCar.SetActive(false);
				}
			}
		}
	}
}
