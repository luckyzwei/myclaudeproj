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
		Disposables = new CompositeDisposable();
		CurStatus = Status.None;
		DeltaTime = 0f;
		WaitTime = 2f;
		bPlayGame = false;
		audio = GetComponent<AudioSource>();

		if (Path != null)
		{
			StopIndex = Path.GetRatioByIdx(StopTrans.position);
		}
		SetVisibleBus(false);
	}

	public void StartBus(bool bWorkOn, Action endCallback)
	{
		EndCallback = endCallback;
		DeltaTime = 0f;
		bPlayGame = true;
		SetVisibleBus(true);

		if (bWorkOn)
		{
			CurStatus = Status.Enter_WorkOn;
			TargetIndex = 0;
		}
		else
		{
			CurStatus = Status.Enter_WorkOff;
			TargetIndex = 0;
		}
	}

	public void ExitBus()
	{
		CurStatus = Status.Wait_Exit;
		DeltaTime = 0f;
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	private void Update()
	{
		if (!bPlayGame) return;
		if (Path == null) return;

		DeltaTime += Time.deltaTime;

		switch (CurStatus)
		{
			case Status.Enter_WorkOn:
			case Status.Enter_WorkOff:
			{
				Vector3 pos = Path.GetPathByTime(DeltaTime);
				transform.position = pos;
				int curIdx = Path.GetPathIdxAtTime(DeltaTime);
				if (curIdx >= StopIndex)
				{
					transform.position = StopTrans.position;
					DeltaTime = 0f;
					CurStatus = (CurStatus == Status.Enter_WorkOn) ? Status.Wait_WorkOn : Status.Wait_WorkOff;
					EndCallback?.Invoke();
					EndCallback = null;
				}
				break;
			}
			case Status.Wait_WorkOn:
			case Status.Wait_WorkOff:
				// Waiting at stop for passengers
				break;
			case Status.Wait_Exit:
			{
				if (DeltaTime >= WaitTime)
				{
					CurStatus = Status.Exit;
					DeltaTime = Path.GetTimebyIdx(StopIndex);
				}
				break;
			}
			case Status.Exit:
			{
				DeltaTime += Time.deltaTime;
				Vector3 pos = Path.GetPathByTime(DeltaTime);
				transform.position = pos;
				float ratio = Path.GetPathRatioByTime(DeltaTime);
				if (ratio >= 1f)
				{
					bPlayGame = false;
					CurStatus = Status.None;
					SetVisibleBus(false);
				}
				break;
			}
		}
	}

	private void SetVisibleBus(bool bActive)
	{
		if (Bus != null)
			Bus.gameObject.SetActive(bActive);
	}
}
