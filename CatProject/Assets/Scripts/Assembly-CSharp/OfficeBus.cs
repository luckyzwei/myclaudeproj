using System;
using UnityEngine;

public class OfficeBus : MonoBehaviour
{
	private enum Status
	{
		Idle = 0,
		Enter = 1,
		Wait = 2,
		Exit = 3,
		WorkOffEnter = 4,
		WorkOffExit = 5,
		WorkOffWait = 6
	}

	[SerializeField]
	private Animator Bus;

	[SerializeField]
	private InGamePath Path;

	[SerializeField]
	private Transform StopTrans;

	[SerializeField]
	public Transform CharSpawnTrans;

	[SerializeField]
	public Transform CeoSpawnTrans;

	[SerializeField]
	public Transform CeoCarRoot;

	private Status CurStatus;

	private float WaitTime;

	private float WorkOffWaitTime;

	private int StopIndex;

	private int TargetIndex;

	private float TargetTime;

	private float DeltaTime;

	private float WaitDeltaTime;

	private bool WorkOffCountStart;

	private Action NextAction;

	private AudioSource audio;

	private SpriteRenderer spriteRenderer;

	private GameObject CarObj;

	public void Init()
	{
		CurStatus = Status.Idle;
		DeltaTime = 0f;
		WaitDeltaTime = 0f;
		WaitTime = 2f;
		WorkOffWaitTime = 3f;
		WorkOffCountStart = false;
		StopIndex = 0;
		spriteRenderer = GetComponentInChildren<SpriteRenderer>();
		LoadCar();
	}

	private void LoadCar()
	{
		// TODO
	}

	public void StartBus()
	{
		CurStatus = Status.Enter;
		DeltaTime = 0f;
		if (Path != null)
		{
			TargetTime = Path.TotalDuration;
		}
	}

	public void StartWorkOffBus()
	{
		CurStatus = Status.WorkOffEnter;
		DeltaTime = 0f;
		WorkOffCountStart = false;
	}

	public void StartWaitCounting()
	{
		WorkOffCountStart = true;
		WaitDeltaTime = 0f;
	}

	public void Return()
	{
		CurStatus = Status.Idle;
		DeltaTime = 0f;
		WaitDeltaTime = 0f;
		WorkOffCountStart = false;
	}

	private void Update()
	{
		switch (CurStatus)
		{
			case Status.Enter:
				DeltaTime += Time.deltaTime;
				break;
			case Status.Wait:
				WaitDeltaTime += Time.deltaTime;
				if (WaitDeltaTime >= WaitTime)
				{
					CurStatus = Status.Exit;
					DeltaTime = 0f;
				}
				break;
			case Status.Exit:
				DeltaTime += Time.deltaTime;
				break;
			case Status.WorkOffEnter:
				DeltaTime += Time.deltaTime;
				break;
			case Status.WorkOffWait:
				if (WorkOffCountStart)
				{
					WaitDeltaTime += Time.deltaTime;
					if (WaitDeltaTime >= WorkOffWaitTime)
					{
						CurStatus = Status.WorkOffExit;
						DeltaTime = 0f;
					}
				}
				break;
			case Status.WorkOffExit:
				DeltaTime += Time.deltaTime;
				break;
		}
	}

	public void UpdateSpecialTheme(bool isSpecialTheme)
	{
		// Update display
	}

	private void OnDestroy()
	{
		if (CarObj != null)
			Destroy(CarObj);
	}
}
