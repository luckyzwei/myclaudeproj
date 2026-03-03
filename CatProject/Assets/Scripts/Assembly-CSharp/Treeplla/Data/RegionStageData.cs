using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RegionStageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Region => 0;

		public string Money => null;

		public int Power => 0;

		public long Lastlogintime => 0L;

		public int Stageidx => 0;

		public int CompanylistLength => 0;

		public int CompaniesLength => 0;

		public int OfficesLength => 0;

		public int MissionsLength => 0;

		public OfflineData? Offlinedata => null;

		public int UnlockcompanyLength => 0;

		public MoneySafeData? Moneysafedata => null;

		public InvestData? Investdata => null;

		public int Equipcar => 0;

		public int Point => 0;

		public int AbilityinvestdataLength => 0;

		public int Recommentcompanyidx => 0;

		public int BuyparkinglotdataLength => 0;

		public RichWayData? Richwaydata => null;

		public RegionMissionData? Regionmissiondata => null;

		public static void ValidateVersion()
		{
		}

		public static RegionStageData GetRootAsRegionStageData(ByteBuffer _bb)
		{
			return default(RegionStageData);
		}

		public static RegionStageData GetRootAsRegionStageData(ByteBuffer _bb, RegionStageData obj)
		{
			return default(RegionStageData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public RegionStageData __assign(int _i, ByteBuffer _bb)
		{
			return default(RegionStageData);
		}

		public bool MutateRegion(int region)
		{
			return false;
		}

		public ArraySegment<byte>? GetMoneyBytes()
		{
			return null;
		}

		public byte[] GetMoneyArray()
		{
			return null;
		}

		public bool MutatePower(int power)
		{
			return false;
		}

		public bool MutateLastlogintime(long lastlogintime)
		{
			return false;
		}

		public bool MutateStageidx(int stageidx)
		{
			return false;
		}

		public int Companylist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetCompanylistBytes()
		{
			return null;
		}

		public int[] GetCompanylistArray()
		{
			return null;
		}

		public bool MutateCompanylist(int j, int companylist)
		{
			return false;
		}

		public CompanyData? Companies(int j)
		{
			return null;
		}

		public OfficeData? Offices(int j)
		{
			return null;
		}

		public MissionData? Missions(int j)
		{
			return null;
		}

		public int Unlockcompany(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetUnlockcompanyBytes()
		{
			return null;
		}

		public int[] GetUnlockcompanyArray()
		{
			return null;
		}

		public bool MutateUnlockcompany(int j, int unlockcompany)
		{
			return false;
		}

		public bool MutateEquipcar(int equipcar)
		{
			return false;
		}

		public bool MutatePoint(int point)
		{
			return false;
		}

		public InvestData? Abilityinvestdata(int j)
		{
			return null;
		}

		public bool MutateRecommentcompanyidx(int recommentcompanyidx)
		{
			return false;
		}

		public BuyParkingLotData? Buyparkinglotdata(int j)
		{
			return null;
		}

		public static Offset<RegionStageData> CreateRegionStageData(FlatBufferBuilder builder, int region = 0, StringOffset moneyOffset = default(StringOffset), int power = 0, long lastlogintime = 0L, int stageidx = 0, VectorOffset companylistOffset = default(VectorOffset), VectorOffset companiesOffset = default(VectorOffset), VectorOffset officesOffset = default(VectorOffset), VectorOffset missionsOffset = default(VectorOffset), Offset<OfflineData> offlinedataOffset = default(Offset<OfflineData>), VectorOffset unlockcompanyOffset = default(VectorOffset), Offset<MoneySafeData> moneysafedataOffset = default(Offset<MoneySafeData>), Offset<InvestData> investdataOffset = default(Offset<InvestData>), int equipcar = -1, int point = 0, VectorOffset abilityinvestdataOffset = default(VectorOffset), int recommentcompanyidx = 0, VectorOffset buyparkinglotdataOffset = default(VectorOffset), Offset<RichWayData> richwaydataOffset = default(Offset<RichWayData>), Offset<RegionMissionData> regionmissiondataOffset = default(Offset<RegionMissionData>))
		{
			return default(Offset<RegionStageData>);
		}

		public static void StartRegionStageData(FlatBufferBuilder builder)
		{
		}

		public static void AddRegion(FlatBufferBuilder builder, int region)
		{
		}

		public static void AddMoney(FlatBufferBuilder builder, StringOffset moneyOffset)
		{
		}

		public static void AddPower(FlatBufferBuilder builder, int power)
		{
		}

		public static void AddLastlogintime(FlatBufferBuilder builder, long lastlogintime)
		{
		}

		public static void AddStageidx(FlatBufferBuilder builder, int stageidx)
		{
		}

		public static void AddCompanylist(FlatBufferBuilder builder, VectorOffset companylistOffset)
		{
		}

		public static VectorOffset CreateCompanylistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCompanylistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddCompanies(FlatBufferBuilder builder, VectorOffset companiesOffset)
		{
		}

		public static VectorOffset CreateCompaniesVector(FlatBufferBuilder builder, Offset<CompanyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, Offset<CompanyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CompanyData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCompaniesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOffices(FlatBufferBuilder builder, VectorOffset officesOffset)
		{
		}

		public static VectorOffset CreateOfficesVector(FlatBufferBuilder builder, Offset<OfficeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, Offset<OfficeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OfficeData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOfficesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddMissions(FlatBufferBuilder builder, VectorOffset missionsOffset)
		{
		}

		public static VectorOffset CreateMissionsVector(FlatBufferBuilder builder, Offset<MissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, Offset<MissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<MissionData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartMissionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOfflinedata(FlatBufferBuilder builder, Offset<OfflineData> offlinedataOffset)
		{
		}

		public static void AddUnlockcompany(FlatBufferBuilder builder, VectorOffset unlockcompanyOffset)
		{
		}

		public static VectorOffset CreateUnlockcompanyVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartUnlockcompanyVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddMoneysafedata(FlatBufferBuilder builder, Offset<MoneySafeData> moneysafedataOffset)
		{
		}

		public static void AddInvestdata(FlatBufferBuilder builder, Offset<InvestData> investdataOffset)
		{
		}

		public static void AddEquipcar(FlatBufferBuilder builder, int equipcar)
		{
		}

		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
		}

		public static void AddAbilityinvestdata(FlatBufferBuilder builder, VectorOffset abilityinvestdataOffset)
		{
		}

		public static VectorOffset CreateAbilityinvestdataVector(FlatBufferBuilder builder, Offset<InvestData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, Offset<InvestData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<InvestData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartAbilityinvestdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddRecommentcompanyidx(FlatBufferBuilder builder, int recommentcompanyidx)
		{
		}

		public static void AddBuyparkinglotdata(FlatBufferBuilder builder, VectorOffset buyparkinglotdataOffset)
		{
		}

		public static VectorOffset CreateBuyparkinglotdataVector(FlatBufferBuilder builder, Offset<BuyParkingLotData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, Offset<BuyParkingLotData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BuyParkingLotData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartBuyparkinglotdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddRichwaydata(FlatBufferBuilder builder, Offset<RichWayData> richwaydataOffset)
		{
		}

		public static void AddRegionmissiondata(FlatBufferBuilder builder, Offset<RegionMissionData> regionmissiondataOffset)
		{
		}

		public static Offset<RegionStageData> EndRegionStageData(FlatBufferBuilder builder)
		{
			return default(Offset<RegionStageData>);
		}

		public RegionStageDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(RegionStageDataT _o)
		{
		}

		public static Offset<RegionStageData> Pack(FlatBufferBuilder builder, RegionStageDataT _o)
		{
			return default(Offset<RegionStageData>);
		}
	}
}
