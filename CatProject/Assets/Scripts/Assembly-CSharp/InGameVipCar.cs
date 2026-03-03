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

	private AdSupplyVIP AdSupplyVIP => null;

	private void Awake()
	{
	}

	private void UpdateStatus(AdSupplySystem.Status status)
	{
	}

	private void Update()
	{
	}
}
