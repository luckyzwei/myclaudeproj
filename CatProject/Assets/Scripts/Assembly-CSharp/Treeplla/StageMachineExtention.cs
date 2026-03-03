using System.Collections.Generic;
using System.Numerics;

namespace Treeplla
{
	public static class StageMachineExtention
	{
		private static Dictionary<int, Dictionary<int, StageMachineAlreadyData>> cachedStageMachineDatas;

		private static List<int> stepLevels;

		public static int MaxLevel { get; private set; }

		public static BigInteger GetInstallPrice(this StageMachine tableData, int machineIdx)
		{
			return default(BigInteger);
		}

		public static StageMachineAlreadyData GetUpgradeData(this StageMachine tableData, int machineIdx, int level)
		{
			return null;
		}

		public static void GetLimitLevel(this StageMachine tableData, int curLv, out int preLimitValue, out int limitValue)
		{
			preLimitValue = default(int);
			limitValue = default(int);
		}

		private static void SetStepLevels()
		{
		}

		public static int GetTotalStepLevel(this StageMachine tableData)
		{
			return 0;
		}

		public static int GetStep(this StageMachine tableData, int level)
		{
			return 0;
		}

		public static void CalculateUpgradeTable(this StageMachine tableData, int stage_idx)
		{
		}
	}
}
