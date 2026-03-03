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
	}

	private void LoadCar()
	{
	}

	public void StartBus()
	{
	}

	public void StartWorkOffBus()
	{
	}

	public void StartWaitCounting()
	{
	}

	public void Return()
	{
	}

	private void Update()
	{
	}

	public void UpdateSpecialTheme(bool isSpecialTheme)
	{
	}

	private void OnDestroy()
	{
	}
}
