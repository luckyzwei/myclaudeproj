using System.Numerics;
using Treeplla;
using UniRx;

public abstract class SingleMissionBase
{
	protected CompositeDisposable Disposables;

	public object[] Args;

	protected bool bPossibleShortCut;

	public E_ContentsMissionType ContentType { get; protected set; }

	public int SlotIdx { get; protected set; }

	public int MissionIdx { get; protected set; }

	public MissionSystem.E_MissionType MissionType { get; protected set; }

	public int TargetValue { get; protected set; }

	public ReactiveProperty<BigInteger> CurrentValue { get; protected set; }

	public ReactiveProperty<bool> IsCompleted { get; protected set; }

	public ReactiveProperty<bool> IsRewarded { get; protected set; }

	public Subject<bool> OnMissionActivated { get; protected set; }

	public IRewardItemData RewardItem { get; protected set; }

	public string MissionDescriptionKey { get; protected set; }

	public SingleMissionBase()
	{
	}

	public SingleMissionBase Init(SingleMissionInitParams data)
	{
		return null;
	}

	public void Reset()
	{
	}

	public virtual string GetMissionDescriptionText()
	{
		return null;
	}

	public virtual string GetMissionProgressText_CurrentValue()
	{
		return null;
	}

	public virtual string GetMissionProgressText_TargetValue()
	{
		return null;
	}

	public virtual string GetMissionProgressText()
	{
		return null;
	}

	public virtual float GetMissionProgressValue()
	{
		return 0f;
	}

	public virtual bool IsPossibleShortCut()
	{
		return false;
	}

	public virtual bool IsActiveMission()
	{
		return false;
	}

	public virtual bool IsExistOpenCondition()
	{
		return false;
	}

	protected virtual void OnInitAfter()
	{
	}

	protected void OnCurrentValueChanged(BigInteger value)
	{
	}

	protected MissionTypeData GetMissionTypeData()
	{
		return null;
	}

	protected string GetMissionTypeDescription()
	{
		return null;
	}

	protected string GetMissionTypeDescription(params object[] args)
	{
		return null;
	}

	public abstract void Subscribe();

	protected virtual void Unsubscribe()
	{
	}
}
