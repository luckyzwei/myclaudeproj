using System;
using Treeplla;
using UnityEngine;

public class Manager : Worker
{
	private InGameManagerUI ManagerUI;

	private int curMessageCoolTime;

	private int maxMessageCoolTime;

	private float realtime_dtime;

	public int OfficeIdx { get; private set; }

	public int ManagerIdx { get; private set; }

	public void Init(E_AppearType appearType, int managerIdx, int officeIdx, int officeOrder)
	{
		WorkerType = E_WorkerType.Manager;
		ManagerIdx = managerIdx;
		OfficeIdx = officeIdx;
		TargetOffice = officeIdx;
		WorkerInit();
		GetRandomCooltime();
		// 매니저 캐릭터 로드
		LoadChar(() =>
		{
			LoadManagerUI(() =>
			{
				// 출근 방식에 따라 등장 처리
				switch (appearType)
				{
					case E_AppearType.Seat:
						ChangeState(E_State.Work);
						break;
					case E_AppearType.Bus:
						GotoWorkOffBus(officeOrder);
						break;
					case E_AppearType.Walk:
						ChangeState(E_State.WalkToWorkOn);
						break;
				}
			});
		});
	}

	public override void WorkOut(int order, bool outcompany)
	{
		base.WorkOut(order, outcompany);
		ReturnManagerUI();
	}

	public void WorkOutImmediate()
	{
		// 즉시 퇴근 처리
		isOut = true;
		ReturnManagerUI();
		GotoWorkOffReturn();
	}

	private void GotoWorkOffReturn()
	{
		ChangeState(E_State.Workoff);
	}

	private void LoadChar(Action LoadComp)
	{
		// 매니저 캐릭터 어드레서블 로드
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.ManagerCardSystem == null)
		{
			LoadComp?.Invoke();
			return;
		}
		var managerData = root.ManagerCardSystem.GetManagerData(ManagerIdx);
		if (managerData == null)
		{
			LoadComp?.Invoke();
			return;
		}
		// 캐릭터 리소스 로드 후 콜백
		LoadComp?.Invoke();
	}

	private void UserManagerUI(Action action)
	{
		if (ManagerUI != null)
		{
			action?.Invoke();
			return;
		}
		LoadManagerUI(action);
	}

	private void LoadManagerUI(Action action)
	{
		// InGameManagerUI 프리팹 로드
		action?.Invoke();
	}

	private void ReturnManagerUI()
	{
		if (ManagerUI != null)
		{
			ManagerUI.Hide();
			ManagerUI = null;
		}
	}

	private void ShowMessage()
	{
		if (ManagerUI == null) return;
		if (state != E_State.Work) return;
		// 매니저 말풍선 메시지 표시
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		// 랜덤 메시지 선택 후 표시
		curMessageCoolTime = maxMessageCoolTime;
	}

	protected override void Update()
	{
		base.Update();
		if (state != E_State.Work) return;
		// 메시지 쿨타임 처리
		realtime_dtime += Time.deltaTime;
		if (realtime_dtime >= 1f)
		{
			realtime_dtime -= 1f;
			curMessageCoolTime--;
			if (curMessageCoolTime <= 0)
			{
				ShowMessage();
				GetRandomCooltime();
			}
		}
	}

	private void GetRandomCooltime()
	{
		// 랜덤 메시지 쿨타임 설정 (30~90초)
		maxMessageCoolTime = UnityEngine.Random.Range(30, 91);
		curMessageCoolTime = maxMessageCoolTime;
	}
}
