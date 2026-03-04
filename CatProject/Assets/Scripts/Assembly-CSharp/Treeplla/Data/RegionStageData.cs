using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RegionStageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Region { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Money { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public int Power { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Lastlogintime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Stageidx { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int CompanylistLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int CompaniesLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int OfficesLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int MissionsLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

		public OfflineData? Offlinedata { get { int o = __p.__offset(22); return o != 0 ? (new OfflineData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int UnlockcompanyLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }

		public MoneySafeData? Moneysafedata { get { int o = __p.__offset(26); return o != 0 ? (new MoneySafeData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public InvestData? Investdata { get { int o = __p.__offset(28); return o != 0 ? (new InvestData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int Equipcar { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Point { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int AbilityinvestdataLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Recommentcompanyidx { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int BuyparkinglotdataLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }

		public RichWayData? Richwaydata { get { int o = __p.__offset(40); return o != 0 ? (new RichWayData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public RegionMissionData? Regionmissiondata { get { int o = __p.__offset(42); return o != 0 ? (new RegionMissionData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static RegionStageData GetRootAsRegionStageData(ByteBuffer _bb)
		{
			return GetRootAsRegionStageData(_bb, new RegionStageData());
		}

		public static RegionStageData GetRootAsRegionStageData(ByteBuffer _bb, RegionStageData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public RegionStageData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateRegion(int region)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, region);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetMoneyBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public byte[] GetMoneyArray()
		{
			return __p.__vector_as_array<byte>(6);
		}

		public bool MutatePower(int power)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, power);
				return true;
			}
			return false;
		}

		public bool MutateLastlogintime(long lastlogintime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastlogintime);
				return true;
			}
			return false;
		}

		public bool MutateStageidx(int stageidx)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, stageidx);
				return true;
			}
			return false;
		}

		public int Companylist(int j)
		{
			int o = __p.__offset(14);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetCompanylistBytes()
		{
			return __p.__vector_as_arraysegment(44);
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
			int o = __p.__offset(16);
			return o != 0 ? (new CompanyData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public OfficeData? Offices(int j)
		{
			int o = __p.__offset(18);
			return o != 0 ? (new OfficeData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public MissionData? Missions(int j)
		{
			int o = __p.__offset(20);
			return o != 0 ? (new MissionData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public int Unlockcompany(int j)
		{
			int o = __p.__offset(24);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetUnlockcompanyBytes()
		{
			return __p.__vector_as_arraysegment(52);
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
			int o = __p.__offset(30);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, equipcar);
				return true;
			}
			return false;
		}

		public bool MutatePoint(int point)
		{
			int o = __p.__offset(32);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, point);
				return true;
			}
			return false;
		}

		public InvestData? Abilityinvestdata(int j)
		{
			int o = __p.__offset(34);
			return o != 0 ? (new InvestData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateRecommentcompanyidx(int recommentcompanyidx)
		{
			int o = __p.__offset(36);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, recommentcompanyidx);
				return true;
			}
			return false;
		}

		public BuyParkingLotData? Buyparkinglotdata(int j)
		{
			int o = __p.__offset(38);
			return o != 0 ? (new BuyParkingLotData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<RegionStageData> CreateRegionStageData(FlatBufferBuilder builder, int region = 0, StringOffset moneyOffset = default(StringOffset), int power = 0, long lastlogintime = 0L, int stageidx = 0, VectorOffset companylistOffset = default(VectorOffset), VectorOffset companiesOffset = default(VectorOffset), VectorOffset officesOffset = default(VectorOffset), VectorOffset missionsOffset = default(VectorOffset), Offset<OfflineData> offlinedataOffset = default(Offset<OfflineData>), VectorOffset unlockcompanyOffset = default(VectorOffset), Offset<MoneySafeData> moneysafedataOffset = default(Offset<MoneySafeData>), Offset<InvestData> investdataOffset = default(Offset<InvestData>), int equipcar = -1, int point = 0, VectorOffset abilityinvestdataOffset = default(VectorOffset), int recommentcompanyidx = 0, VectorOffset buyparkinglotdataOffset = default(VectorOffset), Offset<RichWayData> richwaydataOffset = default(Offset<RichWayData>), Offset<RegionMissionData> regionmissiondataOffset = default(Offset<RegionMissionData>))
		{
			builder.StartTable(20);
			AddRegionmissiondata(builder, regionmissiondataOffset);
			AddRichwaydata(builder, richwaydataOffset);
			AddBuyparkinglotdata(builder, buyparkinglotdataOffset);
			AddRecommentcompanyidx(builder, recommentcompanyidx);
			AddAbilityinvestdata(builder, abilityinvestdataOffset);
			AddPoint(builder, point);
			AddEquipcar(builder, equipcar);
			AddInvestdata(builder, investdataOffset);
			AddMoneysafedata(builder, moneysafedataOffset);
			AddUnlockcompany(builder, unlockcompanyOffset);
			AddOfflinedata(builder, offlinedataOffset);
			AddMissions(builder, missionsOffset);
			AddOffices(builder, officesOffset);
			AddCompanies(builder, companiesOffset);
			AddCompanylist(builder, companylistOffset);
			AddStageidx(builder, stageidx);
			AddLastlogintime(builder, lastlogintime);
			AddPower(builder, power);
			AddMoney(builder, moneyOffset);
			AddRegion(builder, region);
			return EndRegionStageData(builder);
		}

		public static void StartRegionStageData(FlatBufferBuilder builder)
		{
			builder.StartTable(27);
		}

		public static void AddRegion(FlatBufferBuilder builder, int region)
		{
			builder.AddInt(0, region, 0);
		}

		public static void AddMoney(FlatBufferBuilder builder, StringOffset moneyOffset)
		{
			builder.AddOffset(1, moneyOffset.Value, 0);
		}

		public static void AddPower(FlatBufferBuilder builder, int power)
		{
			builder.AddInt(2, power, 0);
		}

		public static void AddLastlogintime(FlatBufferBuilder builder, long lastlogintime)
		{
			builder.AddLong(3, lastlogintime, 0);
		}

		public static void AddStageidx(FlatBufferBuilder builder, int stageidx)
		{
			builder.AddInt(4, stageidx, 0);
		}

		public static void AddCompanylist(FlatBufferBuilder builder, VectorOffset companylistOffset)
		{
			builder.AddOffset(5, companylistOffset.Value, 0);
		}

		public static VectorOffset CreateCompanylistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompanylistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCompanylistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddCompanies(FlatBufferBuilder builder, VectorOffset companiesOffset)
		{
			builder.AddOffset(6, companiesOffset.Value, 0);
		}

		public static VectorOffset CreateCompaniesVector(FlatBufferBuilder builder, Offset<CompanyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, Offset<CompanyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CompanyData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompaniesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCompaniesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOffices(FlatBufferBuilder builder, VectorOffset officesOffset)
		{
			builder.AddOffset(7, officesOffset.Value, 0);
		}

		public static VectorOffset CreateOfficesVector(FlatBufferBuilder builder, Offset<OfficeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, Offset<OfficeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<OfficeData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOfficesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOfficesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMissions(FlatBufferBuilder builder, VectorOffset missionsOffset)
		{
			builder.AddOffset(8, missionsOffset.Value, 0);
		}

		public static VectorOffset CreateMissionsVector(FlatBufferBuilder builder, Offset<MissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, Offset<MissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<MissionData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartMissionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOfflinedata(FlatBufferBuilder builder, Offset<OfflineData> offlinedataOffset)
		{
			builder.AddOffset(9, offlinedataOffset.Value, 0);
		}

		public static void AddUnlockcompany(FlatBufferBuilder builder, VectorOffset unlockcompanyOffset)
		{
			builder.AddOffset(10, unlockcompanyOffset.Value, 0);
		}

		public static VectorOffset CreateUnlockcompanyVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateUnlockcompanyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartUnlockcompanyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMoneysafedata(FlatBufferBuilder builder, Offset<MoneySafeData> moneysafedataOffset)
		{
			builder.AddOffset(11, moneysafedataOffset.Value, 0);
		}

		public static void AddInvestdata(FlatBufferBuilder builder, Offset<InvestData> investdataOffset)
		{
			builder.AddOffset(12, investdataOffset.Value, 0);
		}

		public static void AddEquipcar(FlatBufferBuilder builder, int equipcar)
		{
			builder.AddInt(13, equipcar, 0);
		}

		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
			builder.AddInt(14, point, 0);
		}

		public static void AddAbilityinvestdata(FlatBufferBuilder builder, VectorOffset abilityinvestdataOffset)
		{
			builder.AddOffset(15, abilityinvestdataOffset.Value, 0);
		}

		public static VectorOffset CreateAbilityinvestdataVector(FlatBufferBuilder builder, Offset<InvestData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, Offset<InvestData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<InvestData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAbilityinvestdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartAbilityinvestdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddRecommentcompanyidx(FlatBufferBuilder builder, int recommentcompanyidx)
		{
			builder.AddInt(16, recommentcompanyidx, 0);
		}

		public static void AddBuyparkinglotdata(FlatBufferBuilder builder, VectorOffset buyparkinglotdataOffset)
		{
			builder.AddOffset(17, buyparkinglotdataOffset.Value, 0);
		}

		public static VectorOffset CreateBuyparkinglotdataVector(FlatBufferBuilder builder, Offset<BuyParkingLotData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, Offset<BuyParkingLotData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BuyParkingLotData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuyparkinglotdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartBuyparkinglotdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddRichwaydata(FlatBufferBuilder builder, Offset<RichWayData> richwaydataOffset)
		{
			builder.AddOffset(18, richwaydataOffset.Value, 0);
		}

		public static void AddRegionmissiondata(FlatBufferBuilder builder, Offset<RegionMissionData> regionmissiondataOffset)
		{
			builder.AddOffset(19, regionmissiondataOffset.Value, 0);
		}

		public static Offset<RegionStageData> EndRegionStageData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<RegionStageData>(o);
		}

		public RegionStageDataT UnPack()
		{
			var _o = new RegionStageDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(RegionStageDataT _o)
		{
			_o.Region = this.Region;
			_o.Money = this.Money;
			_o.Power = this.Power;
			_o.Lastlogintime = this.Lastlogintime;
			_o.Stageidx = this.Stageidx;
			_o.Companylist = new List<int>();
			for (var _j = 0; _j < this.CompanylistLength; ++_j)
				_o.Companylist.Add(this.Companylist(_j));
			_o.Companies = new List<CompanyDataT>();
			for (var _j = 0; _j < this.CompaniesLength; ++_j)
				_o.Companies.Add(this.Companies(_j).HasValue ? this.Companies(_j).Value.UnPack() : null);
			_o.Offices = new List<OfficeDataT>();
			for (var _j = 0; _j < this.OfficesLength; ++_j)
				_o.Offices.Add(this.Offices(_j).HasValue ? this.Offices(_j).Value.UnPack() : null);
			_o.Missions = new List<MissionDataT>();
			for (var _j = 0; _j < this.MissionsLength; ++_j)
				_o.Missions.Add(this.Missions(_j).HasValue ? this.Missions(_j).Value.UnPack() : null);
			_o.Offlinedata = this.Offlinedata.HasValue ? this.Offlinedata.Value.UnPack() : null;
			_o.Unlockcompany = new List<int>();
			for (var _j = 0; _j < this.UnlockcompanyLength; ++_j)
				_o.Unlockcompany.Add(this.Unlockcompany(_j));
			_o.Moneysafedata = this.Moneysafedata.HasValue ? this.Moneysafedata.Value.UnPack() : null;
			_o.Investdata = this.Investdata.HasValue ? this.Investdata.Value.UnPack() : null;
			_o.Equipcar = this.Equipcar;
			_o.Point = this.Point;
			_o.Abilityinvestdata = new List<InvestDataT>();
			for (var _j = 0; _j < this.AbilityinvestdataLength; ++_j)
				_o.Abilityinvestdata.Add(this.Abilityinvestdata(_j).HasValue ? this.Abilityinvestdata(_j).Value.UnPack() : null);
			_o.Recommentcompanyidx = this.Recommentcompanyidx;
			_o.Buyparkinglotdata = new List<BuyParkingLotDataT>();
			for (var _j = 0; _j < this.BuyparkinglotdataLength; ++_j)
				_o.Buyparkinglotdata.Add(this.Buyparkinglotdata(_j).HasValue ? this.Buyparkinglotdata(_j).Value.UnPack() : null);
			_o.Richwaydata = this.Richwaydata.HasValue ? this.Richwaydata.Value.UnPack() : null;
			_o.Regionmissiondata = this.Regionmissiondata.HasValue ? this.Regionmissiondata.Value.UnPack() : null;
		}

		public static Offset<RegionStageData> Pack(FlatBufferBuilder builder, RegionStageDataT _o)
		{
			if (_o == null) return default(Offset<RegionStageData>);
			var _money = _o.Money == null ? default(StringOffset) : builder.CreateString(_o.Money);
			var _companylist = default(VectorOffset);
			if (_o.Companylist != null)
			{
				var __companylist = _o.Companylist.ToArray();
				_companylist = CreateCompanylistVector(builder, __companylist);
			}
			var _companies = default(VectorOffset);
			if (_o.Companies != null)
			{
				var __companies = new Offset<CompanyData>[_o.Companies.Count];
				for (var _j = 0; _j < _o.Companies.Count; ++_j)
					__companies[_j] = CompanyData.Pack(builder, _o.Companies[_j]);
				_companies = CreateCompaniesVector(builder, __companies);
			}
			var _offices = default(VectorOffset);
			if (_o.Offices != null)
			{
				var __offices = new Offset<OfficeData>[_o.Offices.Count];
				for (var _j = 0; _j < _o.Offices.Count; ++_j)
					__offices[_j] = OfficeData.Pack(builder, _o.Offices[_j]);
				_offices = CreateOfficesVector(builder, __offices);
			}
			var _missions = default(VectorOffset);
			if (_o.Missions != null)
			{
				var __missions = new Offset<MissionData>[_o.Missions.Count];
				for (var _j = 0; _j < _o.Missions.Count; ++_j)
					__missions[_j] = MissionData.Pack(builder, _o.Missions[_j]);
				_missions = CreateMissionsVector(builder, __missions);
			}
			var _offlinedata = _o.Offlinedata == null ? default(Offset<OfflineData>) : OfflineData.Pack(builder, _o.Offlinedata);
			var _unlockcompany = default(VectorOffset);
			if (_o.Unlockcompany != null)
			{
				var __unlockcompany = _o.Unlockcompany.ToArray();
				_unlockcompany = CreateUnlockcompanyVector(builder, __unlockcompany);
			}
			var _moneysafedata = _o.Moneysafedata == null ? default(Offset<MoneySafeData>) : MoneySafeData.Pack(builder, _o.Moneysafedata);
			var _investdata = _o.Investdata == null ? default(Offset<InvestData>) : InvestData.Pack(builder, _o.Investdata);
			var _abilityinvestdata = default(VectorOffset);
			if (_o.Abilityinvestdata != null)
			{
				var __abilityinvestdata = new Offset<InvestData>[_o.Abilityinvestdata.Count];
				for (var _j = 0; _j < _o.Abilityinvestdata.Count; ++_j)
					__abilityinvestdata[_j] = InvestData.Pack(builder, _o.Abilityinvestdata[_j]);
				_abilityinvestdata = CreateAbilityinvestdataVector(builder, __abilityinvestdata);
			}
			var _buyparkinglotdata = default(VectorOffset);
			if (_o.Buyparkinglotdata != null)
			{
				var __buyparkinglotdata = new Offset<BuyParkingLotData>[_o.Buyparkinglotdata.Count];
				for (var _j = 0; _j < _o.Buyparkinglotdata.Count; ++_j)
					__buyparkinglotdata[_j] = BuyParkingLotData.Pack(builder, _o.Buyparkinglotdata[_j]);
				_buyparkinglotdata = CreateBuyparkinglotdataVector(builder, __buyparkinglotdata);
			}
			var _richwaydata = _o.Richwaydata == null ? default(Offset<RichWayData>) : RichWayData.Pack(builder, _o.Richwaydata);
			var _regionmissiondata = _o.Regionmissiondata == null ? default(Offset<RegionMissionData>) : RegionMissionData.Pack(builder, _o.Regionmissiondata);
			StartRegionStageData(builder);
			AddRegion(builder, _o.Region);
			AddMoney(builder, _money);
			AddPower(builder, _o.Power);
			AddLastlogintime(builder, _o.Lastlogintime);
			AddStageidx(builder, _o.Stageidx);
			AddCompanylist(builder, _companylist);
			AddCompanies(builder, _companies);
			AddOffices(builder, _offices);
			AddMissions(builder, _missions);
			AddOfflinedata(builder, _offlinedata);
			AddUnlockcompany(builder, _unlockcompany);
			AddMoneysafedata(builder, _moneysafedata);
			AddInvestdata(builder, _investdata);
			AddEquipcar(builder, _o.Equipcar);
			AddPoint(builder, _o.Point);
			AddAbilityinvestdata(builder, _abilityinvestdata);
			AddRecommentcompanyidx(builder, _o.Recommentcompanyidx);
			AddBuyparkinglotdata(builder, _buyparkinglotdata);
			AddRichwaydata(builder, _richwaydata);
			AddRegionmissiondata(builder, _regionmissiondata);
			return EndRegionStageData(builder);
		}
	}
}
