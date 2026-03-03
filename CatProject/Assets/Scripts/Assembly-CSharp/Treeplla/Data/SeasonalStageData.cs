using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalStageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Seasoninfoidx => 0;

		public long Adsupplytime => 0L;

		public int CurrencydataLength => 0;

		public SeasonalArcadeMachineData? Arcademachinedata => null;

		public int BuildingdataLength => 0;

		public SeasonalMilestoneData? Milestonedata => null;

		public int SkilldataLength => 0;

		public int MissiondataLength => 0;

		public long Lastlogintime => 0L;

		public long Adsupplyresettime => 0L;

		public int Adsupplycount => 0;

		public long Gamestarttime => 0L;

		public AdsupplyPiggy? Seasonaladsupplypiggy => null;

		public bool Overtimeworkactive => false;

		public int CompleterewardlistLength => 0;

		public int Seasonpoint => 0;

		public int WorkerdataLength => 0;

		public int DistributorproductsdataLength => 0;

		public long Daystarttime => 0L;

		public long Slotcoinbufftime => 0L;

		public long Missioncoinbufftime => 0L;

		public bool Useabtest => false;

		public bool Abtestype => false;

		public SeasonalCoinRankData? Coinrankdata => null;

		public bool Isshownseasonendnotice => false;

		public bool Isshownseasonstartnotice => false;

		public static void ValidateVersion()
		{
		}

		public static SeasonalStageData GetRootAsSeasonalStageData(ByteBuffer _bb)
		{
			return default(SeasonalStageData);
		}

		public static SeasonalStageData GetRootAsSeasonalStageData(ByteBuffer _bb, SeasonalStageData obj)
		{
			return default(SeasonalStageData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalStageData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalStageData);
		}

		public bool MutateSeasoninfoidx(int seasoninfoidx)
		{
			return false;
		}

		public bool MutateAdsupplytime(long adsupplytime)
		{
			return false;
		}

		public SeasonalCurrencyData? Currencydata(int j)
		{
			return null;
		}

		public SeasonalBuildingData? Buildingdata(int j)
		{
			return null;
		}

		public SeasonalSkillData? Skilldata(int j)
		{
			return null;
		}

		public SeasonalMissionData? Missiondata(int j)
		{
			return null;
		}

		public bool MutateLastlogintime(long lastlogintime)
		{
			return false;
		}

		public bool MutateAdsupplyresettime(long adsupplyresettime)
		{
			return false;
		}

		public bool MutateAdsupplycount(int adsupplycount)
		{
			return false;
		}

		public bool MutateGamestarttime(long gamestarttime)
		{
			return false;
		}

		public bool MutateOvertimeworkactive(bool overtimeworkactive)
		{
			return false;
		}

		public int Completerewardlist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetCompleterewardlistBytes()
		{
			return null;
		}

		public int[] GetCompleterewardlistArray()
		{
			return null;
		}

		public bool MutateCompleterewardlist(int j, int completerewardlist)
		{
			return false;
		}

		public bool MutateSeasonpoint(int seasonpoint)
		{
			return false;
		}

		public SeasonalWorkerData? Workerdata(int j)
		{
			return null;
		}

		public SeasonalDistributorProductsData? Distributorproductsdata(int j)
		{
			return null;
		}

		public bool MutateDaystarttime(long daystarttime)
		{
			return false;
		}

		public bool MutateSlotcoinbufftime(long slotcoinbufftime)
		{
			return false;
		}

		public bool MutateMissioncoinbufftime(long missioncoinbufftime)
		{
			return false;
		}

		public bool MutateUseabtest(bool useabtest)
		{
			return false;
		}

		public bool MutateAbtestype(bool abtestype)
		{
			return false;
		}

		public bool MutateIsshownseasonendnotice(bool isshownseasonendnotice)
		{
			return false;
		}

		public bool MutateIsshownseasonstartnotice(bool isshownseasonstartnotice)
		{
			return false;
		}

		public static Offset<SeasonalStageData> CreateSeasonalStageData(FlatBufferBuilder builder, int seasoninfoidx = 0, long adsupplytime = 0L, VectorOffset currencydataOffset = default(VectorOffset), Offset<SeasonalArcadeMachineData> arcademachinedataOffset = default(Offset<SeasonalArcadeMachineData>), VectorOffset buildingdataOffset = default(VectorOffset), Offset<SeasonalMilestoneData> milestonedataOffset = default(Offset<SeasonalMilestoneData>), VectorOffset skilldataOffset = default(VectorOffset), VectorOffset missiondataOffset = default(VectorOffset), long lastlogintime = 0L, long adsupplyresettime = 0L, int adsupplycount = 0, long gamestarttime = 0L, Offset<AdsupplyPiggy> seasonaladsupplypiggyOffset = default(Offset<AdsupplyPiggy>), bool overtimeworkactive = false, VectorOffset completerewardlistOffset = default(VectorOffset), int seasonpoint = 0, VectorOffset workerdataOffset = default(VectorOffset), VectorOffset distributorproductsdataOffset = default(VectorOffset), long daystarttime = 0L, long slotcoinbufftime = 0L, long missioncoinbufftime = 0L, bool useabtest = false, bool abtestype = false, Offset<SeasonalCoinRankData> coinrankdataOffset = default(Offset<SeasonalCoinRankData>), bool isshownseasonendnotice = false, bool isshownseasonstartnotice = false)
		{
			return default(Offset<SeasonalStageData>);
		}

		public static void StartSeasonalStageData(FlatBufferBuilder builder)
		{
		}

		public static void AddSeasoninfoidx(FlatBufferBuilder builder, int seasoninfoidx)
		{
		}

		public static void AddAdsupplytime(FlatBufferBuilder builder, long adsupplytime)
		{
		}

		public static void AddCurrencydata(FlatBufferBuilder builder, VectorOffset currencydataOffset)
		{
		}

		public static VectorOffset CreateCurrencydataVector(FlatBufferBuilder builder, Offset<SeasonalCurrencyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalCurrencyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalCurrencyData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCurrencydataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddArcademachinedata(FlatBufferBuilder builder, Offset<SeasonalArcadeMachineData> arcademachinedataOffset)
		{
		}

		public static void AddBuildingdata(FlatBufferBuilder builder, VectorOffset buildingdataOffset)
		{
		}

		public static VectorOffset CreateBuildingdataVector(FlatBufferBuilder builder, Offset<SeasonalBuildingData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuildingdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalBuildingData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuildingdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalBuildingData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuildingdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartBuildingdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddMilestonedata(FlatBufferBuilder builder, Offset<SeasonalMilestoneData> milestonedataOffset)
		{
		}

		public static void AddSkilldata(FlatBufferBuilder builder, VectorOffset skilldataOffset)
		{
		}

		public static VectorOffset CreateSkilldataVector(FlatBufferBuilder builder, Offset<SeasonalSkillData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSkilldataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalSkillData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSkilldataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalSkillData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSkilldataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartSkilldataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddMissiondata(FlatBufferBuilder builder, VectorOffset missiondataOffset)
		{
		}

		public static VectorOffset CreateMissiondataVector(FlatBufferBuilder builder, Offset<SeasonalMissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissiondataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalMissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissiondataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalMissionData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissiondataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartMissiondataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddLastlogintime(FlatBufferBuilder builder, long lastlogintime)
		{
		}

		public static void AddAdsupplyresettime(FlatBufferBuilder builder, long adsupplyresettime)
		{
		}

		public static void AddAdsupplycount(FlatBufferBuilder builder, int adsupplycount)
		{
		}

		public static void AddGamestarttime(FlatBufferBuilder builder, long gamestarttime)
		{
		}

		public static void AddSeasonaladsupplypiggy(FlatBufferBuilder builder, Offset<AdsupplyPiggy> seasonaladsupplypiggyOffset)
		{
		}

		public static void AddOvertimeworkactive(FlatBufferBuilder builder, bool overtimeworkactive)
		{
		}

		public static void AddCompleterewardlist(FlatBufferBuilder builder, VectorOffset completerewardlistOffset)
		{
		}

		public static VectorOffset CreateCompleterewardlistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompleterewardlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompleterewardlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompleterewardlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCompleterewardlistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddSeasonpoint(FlatBufferBuilder builder, int seasonpoint)
		{
		}

		public static void AddWorkerdata(FlatBufferBuilder builder, VectorOffset workerdataOffset)
		{
		}

		public static VectorOffset CreateWorkerdataVector(FlatBufferBuilder builder, Offset<SeasonalWorkerData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateWorkerdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalWorkerData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateWorkerdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalWorkerData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateWorkerdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartWorkerdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddDistributorproductsdata(FlatBufferBuilder builder, VectorOffset distributorproductsdataOffset)
		{
		}

		public static VectorOffset CreateDistributorproductsdataVector(FlatBufferBuilder builder, Offset<SeasonalDistributorProductsData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateDistributorproductsdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalDistributorProductsData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateDistributorproductsdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalDistributorProductsData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateDistributorproductsdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartDistributorproductsdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddDaystarttime(FlatBufferBuilder builder, long daystarttime)
		{
		}

		public static void AddSlotcoinbufftime(FlatBufferBuilder builder, long slotcoinbufftime)
		{
		}

		public static void AddMissioncoinbufftime(FlatBufferBuilder builder, long missioncoinbufftime)
		{
		}

		public static void AddUseabtest(FlatBufferBuilder builder, bool useabtest)
		{
		}

		public static void AddAbtestype(FlatBufferBuilder builder, bool abtestype)
		{
		}

		public static void AddCoinrankdata(FlatBufferBuilder builder, Offset<SeasonalCoinRankData> coinrankdataOffset)
		{
		}

		public static void AddIsshownseasonendnotice(FlatBufferBuilder builder, bool isshownseasonendnotice)
		{
		}

		public static void AddIsshownseasonstartnotice(FlatBufferBuilder builder, bool isshownseasonstartnotice)
		{
		}

		public static Offset<SeasonalStageData> EndSeasonalStageData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalStageData>);
		}

		public SeasonalStageDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalStageDataT _o)
		{
		}

		public static Offset<SeasonalStageData> Pack(FlatBufferBuilder builder, SeasonalStageDataT _o)
		{
			return default(Offset<SeasonalStageData>);
		}
	}
}
