using System;
using UniRx;

public class BuffSystem
{
	public enum BuffIdx
	{
		Boost = 20000,
		AbilityCustomerSpeed = 20001,
		Treat = 20002
	}

	public enum BuffTarget
	{
		None = 0,
		InternalClinic = 1,
		DentalClinic = 2,
		EyeClinic = 3,
		RaditionClinic = 4,
		OperationClinic = 5,
		AllUpgrade = 101,
		AllCustomer = 102,
		AllDoctor = 103,
		AllSlot = 104,
		SlotGroup = 105,
		SlotGroupAll = 106,
		Cashier = 107,
		AllStaff = 108,
		RareManager = 1001
	}

	public enum BuffType
	{
		None = 0,
		FacilityObjectValue = 1,
		StaffObjectValue = 2,
		Boost = 3,
		CasierProductSpeed = 301,
		CasierMoveSpeed = 302,
		StageUpgradePrice = 303,
		ManagerFacilityValue = 1001,
		ManagerProductSpeed = 1002,
		ManagerUpgradeValue = 1003,
		ManagerSpeedValue = 1004,
		ManagerImmediateTreatment = 1005
	}

	public class BuffInfo
	{
		public IReactiveProperty<int> RemainTime;

		public int BuffIdx { get; private set; }

		public BuffType BuffType { get; private set; }

		public BuffTarget TargetType { get; private set; }

		public int TargetIdx { get; private set; }

		public float Value { get; private set; }

		public bool Infinity { get; private set; }

		public DateTime EndTime { get; private set; }

		public BuffInfo(int buffIdx, BuffType buffType, BuffTarget target, int tidx, float value, bool infinity, DateTime endTime)
		{
			BuffIdx = buffIdx;
			BuffType = buffType;
			TargetType = target;
			TargetIdx = tidx;
			Value = value;
			Infinity = infinity;
			EndTime = endTime;
			RemainTime = new ReactiveProperty<int>();
		}

		public void SetValue(float value)
		{
			Value = value;
		}

		public void SetEndTime(DateTime value)
		{
			EndTime = value;
		}
	}

	private IReactiveCollection<BuffInfo> buffInfos;

	private CompositeDisposable disposables;

	public IReactiveCollection<BuffInfo> BuffList { get { return buffInfos; } }

	public void Create()
	{
		buffInfos = new ReactiveCollection<BuffInfo>();
		disposables = new CompositeDisposable();
	}

	public void UpdateBoostBuff()
	{
	}

	public void UpdateOneSeconds()
	{
	}

	public float GetValueTarget(BuffType bft, BuffTarget bt)
	{
		return 0f;
	}

	public float GetValueIdx(BuffType bft, BuffIdx bi)
	{
		return 0f;
	}

	public float GetValueTarget(BuffType bft, BuffTarget bt, int idx = -1)
	{
		return 0f;
	}

	public float GetValueForSlotIdx()
	{
		return 0f;
	}

	public float GetValueForTip()
	{
		return 0f;
	}

	public float GetValueByBuffType(BuffType type, int targetIdx = -1, bool allInfluence = false)
	{
		return 0f;
	}

	public void AddBuff(BuffType buffType, int buffIdx, float multiValue, BuffTarget buffTarget, int targetIdx = -1, long endtime = 0L)
	{
	}

	public void RemoveBuff(int buffIdx, int targetIdx = -1)
	{
	}

	public void RemoveBuff(int bufftype, int buffIdx, int targetIdx = -1)
	{
	}

	public void RemoveBuffFind(int buffIdx, int targetIdx = -1)
	{
	}

	public bool HasBuff(int buffIdx, int targetIdx)
	{
		return false;
	}

	public bool HasBuff(BuffType type, BuffTarget target)
	{
		return false;
	}

	public static bool IsMultiple(BuffType type)
	{
		return false;
	}
}
