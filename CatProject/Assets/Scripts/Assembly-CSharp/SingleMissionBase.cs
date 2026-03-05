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
		Disposables = new CompositeDisposable();
		CurrentValue = new ReactiveProperty<BigInteger>(BigInteger.Zero);
		IsCompleted = new ReactiveProperty<bool>(false);
		IsRewarded = new ReactiveProperty<bool>(false);
		OnMissionActivated = new Subject<bool>();
	}

	public SingleMissionBase Init(SingleMissionInitParams data)
	{
		if (data == null) return this;
		SlotIdx = data.SlotIdx;
		MissionIdx = data.MissionIdx;
		MissionType = data.MissionType;
		TargetValue = data.TargetValue;
		ContentType = data.ContentType;
		MissionDescriptionKey = data.DescriptionKey;
		RewardItem = data.RewardItem;
		Args = data.Args;
		CurrentValue.Value = data.CurrentValue;
		IsCompleted.Value = data.IsCompleted;
		IsRewarded.Value = data.IsRewarded;
		OnInitAfter();
		Subscribe();
		return this;
	}

	public void Reset()
	{
		Unsubscribe();
		CurrentValue.Value = BigInteger.Zero;
		IsCompleted.Value = false;
		IsRewarded.Value = false;
	}

	public virtual string GetMissionDescriptionText()
	{
		return MissionDescriptionKey ?? "";
	}

	public virtual string GetMissionProgressText_CurrentValue()
	{
		return CurrentValue.Value.ToString();
	}

	public virtual string GetMissionProgressText_TargetValue()
	{
		return TargetValue.ToString();
	}

	public virtual string GetMissionProgressText()
	{
		return $"{GetMissionProgressText_CurrentValue()}/{GetMissionProgressText_TargetValue()}";
	}

	public virtual float GetMissionProgressValue()
	{
		if (TargetValue <= 0) return 1f;
		float progress = (float)CurrentValue.Value / TargetValue;
		return progress > 1f ? 1f : progress;
	}

	public virtual bool IsPossibleShortCut()
	{
		return bPossibleShortCut;
	}

	public virtual bool IsActiveMission()
	{
		return !IsCompleted.Value && !IsRewarded.Value;
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
		if (IsCompleted.Value || IsRewarded.Value) return;
		if (value >= TargetValue)
		{
			IsCompleted.Value = true;
		}
	}

	protected MissionTypeData GetMissionTypeData()
	{
		return null;
	}

	protected string GetMissionTypeDescription()
	{
		var data = GetMissionTypeData();
		if (data == null) return "";
		return data.DescriptionKey ?? "";
	}

	protected string GetMissionTypeDescription(params object[] args)
	{
		string desc = GetMissionTypeDescription();
		if (string.IsNullOrEmpty(desc) || args == null || args.Length == 0) return desc;
		return string.Format(desc, args);
	}

	public abstract void Subscribe();

	protected virtual void Unsubscribe()
	{
		Disposables?.Clear();
	}
}
