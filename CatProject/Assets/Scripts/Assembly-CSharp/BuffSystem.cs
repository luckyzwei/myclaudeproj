using System;
using System.Collections.Generic;
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
		if (buffInfos == null) return;

		DateTime now = DateTime.UtcNow;
		var toRemove = new List<BuffInfo>();

		foreach (var info in buffInfos)
		{
			if (info.Infinity) continue;

			int remain = (int)(info.EndTime - now).TotalSeconds;
			info.RemainTime.Value = Math.Max(0, remain);

			if (remain <= 0)
			{
				toRemove.Add(info);
			}
		}

		foreach (var info in toRemove)
		{
			buffInfos.Remove(info);
		}
	}

	public float GetValueTarget(BuffType bft, BuffTarget bt)
	{
		return GetValueTarget(bft, bt, -1);
	}

	public float GetValueIdx(BuffType bft, BuffIdx bi)
	{
		float total = 0f;
		if (buffInfos == null) return total;

		foreach (var info in buffInfos)
		{
			if (info.BuffType == bft && info.BuffIdx == (int)bi)
			{
				if (IsMultiple(bft))
					total = total == 0f ? info.Value : total * info.Value;
				else
					total += info.Value;
			}
		}
		return total;
	}

	public float GetValueTarget(BuffType bft, BuffTarget bt, int idx = -1)
	{
		float total = 0f;
		if (buffInfos == null) return total;

		foreach (var info in buffInfos)
		{
			if (info.BuffType != bft) continue;
			if (info.TargetType != bt) continue;
			if (idx >= 0 && info.TargetIdx != idx) continue;

			if (IsMultiple(bft))
				total = total == 0f ? info.Value : total * info.Value;
			else
				total += info.Value;
		}
		return total;
	}

	public float GetValueForSlotIdx()
	{
		return GetValueTarget(BuffType.FacilityObjectValue, BuffTarget.AllSlot);
	}

	public float GetValueForTip()
	{
		return GetValueTarget(BuffType.StaffObjectValue, BuffTarget.AllStaff);
	}

	public float GetValueByBuffType(BuffType type, int targetIdx = -1, bool allInfluence = false)
	{
		float total = 0f;
		if (buffInfos == null) return total;

		foreach (var info in buffInfos)
		{
			if (info.BuffType != type) continue;
			if (!allInfluence && targetIdx >= 0 && info.TargetIdx != targetIdx) continue;

			if (IsMultiple(type))
				total = total == 0f ? info.Value : total * info.Value;
			else
				total += info.Value;
		}
		return total;
	}

	public void AddBuff(BuffType buffType, int buffIdx, float multiValue, BuffTarget buffTarget, int targetIdx = -1, long endtime = 0L)
	{
		if (buffInfos == null) return;

		DateTime endDateTime;
		bool infinity;
		if (endtime <= 0)
		{
			infinity = true;
			endDateTime = DateTime.MaxValue;
		}
		else
		{
			infinity = false;
			endDateTime = DateTimeOffset.FromUnixTimeSeconds(endtime).UtcDateTime;
		}

		foreach (var info in buffInfos)
		{
			if (info.BuffIdx == buffIdx && info.TargetIdx == targetIdx && info.BuffType == buffType)
			{
				info.SetValue(multiValue);
				info.SetEndTime(endDateTime);
				return;
			}
		}

		var newBuff = new BuffInfo(buffIdx, buffType, buffTarget, targetIdx, multiValue, infinity, endDateTime);
		buffInfos.Add(newBuff);
	}

	public void RemoveBuff(int buffIdx, int targetIdx = -1)
	{
		if (buffInfos == null) return;

		for (int i = buffInfos.Count - 1; i >= 0; i--)
		{
			var info = buffInfos[i];
			if (info.BuffIdx == buffIdx && (targetIdx < 0 || info.TargetIdx == targetIdx))
			{
				buffInfos.RemoveAt(i);
			}
		}
	}

	public void RemoveBuff(int bufftype, int buffIdx, int targetIdx = -1)
	{
		if (buffInfos == null) return;

		for (int i = buffInfos.Count - 1; i >= 0; i--)
		{
			var info = buffInfos[i];
			if ((int)info.BuffType == bufftype && info.BuffIdx == buffIdx && (targetIdx < 0 || info.TargetIdx == targetIdx))
			{
				buffInfos.RemoveAt(i);
			}
		}
	}

	public void RemoveBuffFind(int buffIdx, int targetIdx = -1)
	{
		RemoveBuff(buffIdx, targetIdx);
	}

	public bool HasBuff(int buffIdx, int targetIdx)
	{
		if (buffInfos == null) return false;

		foreach (var info in buffInfos)
		{
			if (info.BuffIdx == buffIdx && info.TargetIdx == targetIdx)
				return true;
		}
		return false;
	}

	public bool HasBuff(BuffType type, BuffTarget target)
	{
		if (buffInfos == null) return false;

		foreach (var info in buffInfos)
		{
			if (info.BuffType == type && info.TargetType == target)
				return true;
		}
		return false;
	}

	public static bool IsMultiple(BuffType type)
	{
		return type == BuffType.Boost;
	}
}
