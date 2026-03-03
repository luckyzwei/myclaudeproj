using System;
using UniRx;
using UnityEngine;

public class SeasonalBus : MonoBehaviour
{
	private enum Status
	{
		None = 0,
		Enter_WorkOn = 1,
		Enter_WorkOff = 2,
		Wait_WorkOn = 3,
		Wait_WorkOff = 4,
		Wait_Exit = 5,
		Exit = 6
	}

	[SerializeField]
	private Animator Bus;

	[SerializeField]
	private InGamePath Path;

	[SerializeField]
	private Transform StopTrans;

	[SerializeField]
	public Transform CharSpawnTrans;

	private bool bPlayGame;

	private int StopIndex;

	private int TargetIndex;

	private Status CurStatus;

	private float DeltaTime;

	private float WaitTime;

	private Action EndCallback;

	private AudioSource audio;

	private CompositeDisposable Disposables;

	public void Init()
	{
	}

	public void StartBus(bool bWorkOn, Action endCallback)
	{
	}

	public void ExitBus()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void SetVisibleBus(bool bActive)
	{
	}
}
