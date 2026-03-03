using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;
using Google.FlatBuffers;
using Treeplla.Data;

public static class SeasonalUserDataConvertFactory
{
	private static InGameSeasonalData SeasonalData => null;

	public static Offset<SeasonalData> CreateSeasonalFlatBufferData(FlatBufferBuilder builder)
	{
		return default(Offset<SeasonalData>);
	}

	private static VectorOffset CreateSeasonalStageDataFlatBufferVector(FlatBufferBuilder builder)
	{
		return default(VectorOffset);
	}

	private static VectorOffset CreateSeasonalCoinRankUserData(FlatBufferBuilder builder, List<SeasonalCoinRankUserData> userDataList)
	{
		return default(VectorOffset);
	}

	private static VectorOffset CreateSeasonalCurrencyFlatBufferData(FlatBufferBuilder builder, ReadOnlyDictionary<int, BigInteger> currencyMap, List<Dictionary<int, BigInteger>> delayedRewardInventory)
	{
		return default(VectorOffset);
	}

	private static VectorOffset CreateSeasonalBuildingFlatBufferData(FlatBufferBuilder builder, List<SeasonalBuildingData> buildingDataMap)
	{
		return default(VectorOffset);
	}

	private static Offset<Treeplla.Data.SeasonalMilestoneData> CreateSeasonalMilestoneFlatBufferData(FlatBufferBuilder builder, SeasonalMilestoneData milestoneData)
	{
		return default(Offset<Treeplla.Data.SeasonalMilestoneData>);
	}

	private static VectorOffset CreateSeasonalSkillFlatBufferData(FlatBufferBuilder builder, ReadOnlyDictionary<int, SeasonalSkillData> skillDataMap)
	{
		return default(VectorOffset);
	}

	private static VectorOffset CreateSeasonalMissionSaveData(FlatBufferBuilder builder, Dictionary<int, SeasonalMissionSaveData> missionSaveDataMap)
	{
		return default(VectorOffset);
	}

	private static VectorOffset CreateSeasonalShopDataFlatBufferVector(FlatBufferBuilder builder)
	{
		return default(VectorOffset);
	}

	private static VectorOffset CreateSeasonalWorkerFlatBufferData(FlatBufferBuilder builder, ReadOnlyDictionary<int, SeasonalWorkerData> workerDataMap)
	{
		return default(VectorOffset);
	}

	private static VectorOffset CreateSeasonalDistributorProduactsFlastBufferVector(FlatBufferBuilder builder, Dictionary<int, SeasonalDistributorProductData> productsMap)
	{
		return default(VectorOffset);
	}

	public static InGameSeasonalData CreateSeasonalGameData(SeasonalData? seasonalData)
	{
		return null;
	}
}
