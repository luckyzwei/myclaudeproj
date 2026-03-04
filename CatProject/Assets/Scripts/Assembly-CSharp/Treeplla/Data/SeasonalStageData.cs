using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalStageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Seasoninfoidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Adsupplytime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int CurrencydataLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public SeasonalArcadeMachineData? Arcademachinedata { get { int o = __p.__offset(10); return o != 0 ? (new SeasonalArcadeMachineData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int BuildingdataLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }

		public SeasonalMilestoneData? Milestonedata { get { int o = __p.__offset(14); return o != 0 ? (new SeasonalMilestoneData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public int SkilldataLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int MissiondataLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Lastlogintime { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Adsupplyresettime { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Adsupplycount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Gamestarttime { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public AdsupplyPiggy? Seasonaladsupplypiggy { get { int o = __p.__offset(28); return o != 0 ? (new AdsupplyPiggy()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public bool Overtimeworkactive { get { int o = __p.__offset(30); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int CompleterewardlistLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Seasonpoint { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int WorkerdataLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int DistributorproductsdataLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Daystarttime { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Slotcoinbufftime { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Missioncoinbufftime { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public bool Useabtest { get { int o = __p.__offset(46); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Abtestype { get { int o = __p.__offset(48); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public SeasonalCoinRankData? Coinrankdata { get { int o = __p.__offset(50); return o != 0 ? (new SeasonalCoinRankData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public bool Isshownseasonendnotice { get { int o = __p.__offset(52); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Isshownseasonstartnotice { get { int o = __p.__offset(54); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalStageData GetRootAsSeasonalStageData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalStageData(_bb, new SeasonalStageData());
		}

		public static SeasonalStageData GetRootAsSeasonalStageData(ByteBuffer _bb, SeasonalStageData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalStageData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSeasoninfoidx(int seasoninfoidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, seasoninfoidx);
				return true;
			}
			return false;
		}

		public bool MutateAdsupplytime(long adsupplytime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, adsupplytime);
				return true;
			}
			return false;
		}

		public SeasonalCurrencyData? Currencydata(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new SeasonalCurrencyData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public SeasonalBuildingData? Buildingdata(int j)
		{
			int o = __p.__offset(12);
			return o != 0 ? (new SeasonalBuildingData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public SeasonalSkillData? Skilldata(int j)
		{
			int o = __p.__offset(16);
			return o != 0 ? (new SeasonalSkillData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public SeasonalMissionData? Missiondata(int j)
		{
			int o = __p.__offset(18);
			return o != 0 ? (new SeasonalMissionData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateLastlogintime(long lastlogintime)
		{
			int o = __p.__offset(20);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastlogintime);
				return true;
			}
			return false;
		}

		public bool MutateAdsupplyresettime(long adsupplyresettime)
		{
			int o = __p.__offset(22);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, adsupplyresettime);
				return true;
			}
			return false;
		}

		public bool MutateAdsupplycount(int adsupplycount)
		{
			int o = __p.__offset(24);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, adsupplycount);
				return true;
			}
			return false;
		}

		public bool MutateGamestarttime(long gamestarttime)
		{
			int o = __p.__offset(26);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, gamestarttime);
				return true;
			}
			return false;
		}

		public bool MutateOvertimeworkactive(bool overtimeworkactive)
		{
			int o = __p.__offset(30);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(overtimeworkactive ? 1 : 0));
				return true;
			}
			return false;
		}

		public int Completerewardlist(int j)
		{
			int o = __p.__offset(32);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetCompleterewardlistBytes()
		{
			return __p.__vector_as_arraysegment(64);
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
			int o = __p.__offset(34);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, seasonpoint);
				return true;
			}
			return false;
		}

		public SeasonalWorkerData? Workerdata(int j)
		{
			int o = __p.__offset(36);
			return o != 0 ? (new SeasonalWorkerData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public SeasonalDistributorProductsData? Distributorproductsdata(int j)
		{
			int o = __p.__offset(38);
			return o != 0 ? (new SeasonalDistributorProductsData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateDaystarttime(long daystarttime)
		{
			int o = __p.__offset(40);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, daystarttime);
				return true;
			}
			return false;
		}

		public bool MutateSlotcoinbufftime(long slotcoinbufftime)
		{
			int o = __p.__offset(42);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, slotcoinbufftime);
				return true;
			}
			return false;
		}

		public bool MutateMissioncoinbufftime(long missioncoinbufftime)
		{
			int o = __p.__offset(44);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, missioncoinbufftime);
				return true;
			}
			return false;
		}

		public bool MutateUseabtest(bool useabtest)
		{
			int o = __p.__offset(46);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(useabtest ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateAbtestype(bool abtestype)
		{
			int o = __p.__offset(48);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(abtestype ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateIsshownseasonendnotice(bool isshownseasonendnotice)
		{
			int o = __p.__offset(52);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isshownseasonendnotice ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateIsshownseasonstartnotice(bool isshownseasonstartnotice)
		{
			int o = __p.__offset(54);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isshownseasonstartnotice ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<SeasonalStageData> CreateSeasonalStageData(FlatBufferBuilder builder, int seasoninfoidx = 0, long adsupplytime = 0L, VectorOffset currencydataOffset = default(VectorOffset), Offset<SeasonalArcadeMachineData> arcademachinedataOffset = default(Offset<SeasonalArcadeMachineData>), VectorOffset buildingdataOffset = default(VectorOffset), Offset<SeasonalMilestoneData> milestonedataOffset = default(Offset<SeasonalMilestoneData>), VectorOffset skilldataOffset = default(VectorOffset), VectorOffset missiondataOffset = default(VectorOffset), long lastlogintime = 0L, long adsupplyresettime = 0L, int adsupplycount = 0, long gamestarttime = 0L, Offset<AdsupplyPiggy> seasonaladsupplypiggyOffset = default(Offset<AdsupplyPiggy>), bool overtimeworkactive = false, VectorOffset completerewardlistOffset = default(VectorOffset), int seasonpoint = 0, VectorOffset workerdataOffset = default(VectorOffset), VectorOffset distributorproductsdataOffset = default(VectorOffset), long daystarttime = 0L, long slotcoinbufftime = 0L, long missioncoinbufftime = 0L, bool useabtest = false, bool abtestype = false, Offset<SeasonalCoinRankData> coinrankdataOffset = default(Offset<SeasonalCoinRankData>), bool isshownseasonendnotice = false, bool isshownseasonstartnotice = false)
		{
			builder.StartTable(26);
			AddIsshownseasonstartnotice(builder, isshownseasonstartnotice);
			AddIsshownseasonendnotice(builder, isshownseasonendnotice);
			AddCoinrankdata(builder, coinrankdataOffset);
			AddAbtestype(builder, abtestype);
			AddUseabtest(builder, useabtest);
			AddMissioncoinbufftime(builder, missioncoinbufftime);
			AddSlotcoinbufftime(builder, slotcoinbufftime);
			AddDaystarttime(builder, daystarttime);
			AddDistributorproductsdata(builder, distributorproductsdataOffset);
			AddWorkerdata(builder, workerdataOffset);
			AddSeasonpoint(builder, seasonpoint);
			AddCompleterewardlist(builder, completerewardlistOffset);
			AddOvertimeworkactive(builder, overtimeworkactive);
			AddSeasonaladsupplypiggy(builder, seasonaladsupplypiggyOffset);
			AddGamestarttime(builder, gamestarttime);
			AddAdsupplycount(builder, adsupplycount);
			AddAdsupplyresettime(builder, adsupplyresettime);
			AddLastlogintime(builder, lastlogintime);
			AddMissiondata(builder, missiondataOffset);
			AddSkilldata(builder, skilldataOffset);
			AddMilestonedata(builder, milestonedataOffset);
			AddBuildingdata(builder, buildingdataOffset);
			AddArcademachinedata(builder, arcademachinedataOffset);
			AddCurrencydata(builder, currencydataOffset);
			AddAdsupplytime(builder, adsupplytime);
			AddSeasoninfoidx(builder, seasoninfoidx);
			return EndSeasonalStageData(builder);
		}

		public static void StartSeasonalStageData(FlatBufferBuilder builder)
		{
			builder.StartTable(33);
		}

		public static void AddSeasoninfoidx(FlatBufferBuilder builder, int seasoninfoidx)
		{
			builder.AddInt(0, seasoninfoidx, 0);
		}

		public static void AddAdsupplytime(FlatBufferBuilder builder, long adsupplytime)
		{
			builder.AddLong(1, adsupplytime, 0);
		}

		public static void AddCurrencydata(FlatBufferBuilder builder, VectorOffset currencydataOffset)
		{
			builder.AddOffset(2, currencydataOffset.Value, 0);
		}

		public static VectorOffset CreateCurrencydataVector(FlatBufferBuilder builder, Offset<SeasonalCurrencyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalCurrencyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalCurrencyData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateCurrencydataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCurrencydataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddArcademachinedata(FlatBufferBuilder builder, Offset<SeasonalArcadeMachineData> arcademachinedataOffset)
		{
			builder.AddOffset(3, arcademachinedataOffset.Value, 0);
		}

		public static void AddBuildingdata(FlatBufferBuilder builder, VectorOffset buildingdataOffset)
		{
			builder.AddOffset(4, buildingdataOffset.Value, 0);
		}

		public static VectorOffset CreateBuildingdataVector(FlatBufferBuilder builder, Offset<SeasonalBuildingData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateBuildingdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalBuildingData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuildingdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalBuildingData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBuildingdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartBuildingdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMilestonedata(FlatBufferBuilder builder, Offset<SeasonalMilestoneData> milestonedataOffset)
		{
			builder.AddOffset(5, milestonedataOffset.Value, 0);
		}

		public static void AddSkilldata(FlatBufferBuilder builder, VectorOffset skilldataOffset)
		{
			builder.AddOffset(6, skilldataOffset.Value, 0);
		}

		public static VectorOffset CreateSkilldataVector(FlatBufferBuilder builder, Offset<SeasonalSkillData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateSkilldataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalSkillData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSkilldataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalSkillData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSkilldataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartSkilldataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMissiondata(FlatBufferBuilder builder, VectorOffset missiondataOffset)
		{
			builder.AddOffset(7, missiondataOffset.Value, 0);
		}

		public static VectorOffset CreateMissiondataVector(FlatBufferBuilder builder, Offset<SeasonalMissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateMissiondataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalMissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissiondataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalMissionData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissiondataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartMissiondataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddLastlogintime(FlatBufferBuilder builder, long lastlogintime)
		{
			builder.AddLong(8, lastlogintime, 0);
		}

		public static void AddAdsupplyresettime(FlatBufferBuilder builder, long adsupplyresettime)
		{
			builder.AddLong(9, adsupplyresettime, 0);
		}

		public static void AddAdsupplycount(FlatBufferBuilder builder, int adsupplycount)
		{
			builder.AddInt(10, adsupplycount, 0);
		}

		public static void AddGamestarttime(FlatBufferBuilder builder, long gamestarttime)
		{
			builder.AddLong(11, gamestarttime, 0);
		}

		public static void AddSeasonaladsupplypiggy(FlatBufferBuilder builder, Offset<AdsupplyPiggy> seasonaladsupplypiggyOffset)
		{
			builder.AddOffset(12, seasonaladsupplypiggyOffset.Value, 0);
		}

		public static void AddOvertimeworkactive(FlatBufferBuilder builder, bool overtimeworkactive)
		{
			builder.AddBool(13, overtimeworkactive, false);
		}

		public static void AddCompleterewardlist(FlatBufferBuilder builder, VectorOffset completerewardlistOffset)
		{
			builder.AddOffset(14, completerewardlistOffset.Value, 0);
		}

		public static VectorOffset CreateCompleterewardlistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCompleterewardlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompleterewardlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompleterewardlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCompleterewardlistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddSeasonpoint(FlatBufferBuilder builder, int seasonpoint)
		{
			builder.AddInt(15, seasonpoint, 0);
		}

		public static void AddWorkerdata(FlatBufferBuilder builder, VectorOffset workerdataOffset)
		{
			builder.AddOffset(16, workerdataOffset.Value, 0);
		}

		public static VectorOffset CreateWorkerdataVector(FlatBufferBuilder builder, Offset<SeasonalWorkerData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateWorkerdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalWorkerData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateWorkerdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalWorkerData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateWorkerdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartWorkerdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddDistributorproductsdata(FlatBufferBuilder builder, VectorOffset distributorproductsdataOffset)
		{
			builder.AddOffset(17, distributorproductsdataOffset.Value, 0);
		}

		public static VectorOffset CreateDistributorproductsdataVector(FlatBufferBuilder builder, Offset<SeasonalDistributorProductsData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateDistributorproductsdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalDistributorProductsData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateDistributorproductsdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalDistributorProductsData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateDistributorproductsdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartDistributorproductsdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddDaystarttime(FlatBufferBuilder builder, long daystarttime)
		{
			builder.AddLong(18, daystarttime, 0);
		}

		public static void AddSlotcoinbufftime(FlatBufferBuilder builder, long slotcoinbufftime)
		{
			builder.AddLong(19, slotcoinbufftime, 0);
		}

		public static void AddMissioncoinbufftime(FlatBufferBuilder builder, long missioncoinbufftime)
		{
			builder.AddLong(20, missioncoinbufftime, 0);
		}

		public static void AddUseabtest(FlatBufferBuilder builder, bool useabtest)
		{
			builder.AddBool(21, useabtest, false);
		}

		public static void AddAbtestype(FlatBufferBuilder builder, bool abtestype)
		{
			builder.AddBool(22, abtestype, false);
		}

		public static void AddCoinrankdata(FlatBufferBuilder builder, Offset<SeasonalCoinRankData> coinrankdataOffset)
		{
			builder.AddOffset(23, coinrankdataOffset.Value, 0);
		}

		public static void AddIsshownseasonendnotice(FlatBufferBuilder builder, bool isshownseasonendnotice)
		{
			builder.AddBool(24, isshownseasonendnotice, false);
		}

		public static void AddIsshownseasonstartnotice(FlatBufferBuilder builder, bool isshownseasonstartnotice)
		{
			builder.AddBool(25, isshownseasonstartnotice, false);
		}

		public static Offset<SeasonalStageData> EndSeasonalStageData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalStageData>(o);
		}

		public SeasonalStageDataT UnPack()
		{
			var _o = new SeasonalStageDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalStageDataT _o)
		{
			_o.Seasoninfoidx = this.Seasoninfoidx;
			_o.Adsupplytime = this.Adsupplytime;
			_o.Currencydata = new List<SeasonalCurrencyDataT>();
			for (var _j = 0; _j < this.CurrencydataLength; ++_j)
				_o.Currencydata.Add(this.Currencydata(_j).HasValue ? this.Currencydata(_j).Value.UnPack() : null);
			_o.Arcademachinedata = this.Arcademachinedata.HasValue ? this.Arcademachinedata.Value.UnPack() : null;
			_o.Buildingdata = new List<SeasonalBuildingDataT>();
			for (var _j = 0; _j < this.BuildingdataLength; ++_j)
				_o.Buildingdata.Add(this.Buildingdata(_j).HasValue ? this.Buildingdata(_j).Value.UnPack() : null);
			_o.Milestonedata = this.Milestonedata.HasValue ? this.Milestonedata.Value.UnPack() : null;
			_o.Skilldata = new List<SeasonalSkillDataT>();
			for (var _j = 0; _j < this.SkilldataLength; ++_j)
				_o.Skilldata.Add(this.Skilldata(_j).HasValue ? this.Skilldata(_j).Value.UnPack() : null);
			_o.Missiondata = new List<SeasonalMissionDataT>();
			for (var _j = 0; _j < this.MissiondataLength; ++_j)
				_o.Missiondata.Add(this.Missiondata(_j).HasValue ? this.Missiondata(_j).Value.UnPack() : null);
			_o.Lastlogintime = this.Lastlogintime;
			_o.Adsupplyresettime = this.Adsupplyresettime;
			_o.Adsupplycount = this.Adsupplycount;
			_o.Gamestarttime = this.Gamestarttime;
			_o.Seasonaladsupplypiggy = this.Seasonaladsupplypiggy.HasValue ? this.Seasonaladsupplypiggy.Value.UnPack() : null;
			_o.Overtimeworkactive = this.Overtimeworkactive;
			_o.Completerewardlist = new List<int>();
			for (var _j = 0; _j < this.CompleterewardlistLength; ++_j)
				_o.Completerewardlist.Add(this.Completerewardlist(_j));
			_o.Seasonpoint = this.Seasonpoint;
			_o.Workerdata = new List<SeasonalWorkerDataT>();
			for (var _j = 0; _j < this.WorkerdataLength; ++_j)
				_o.Workerdata.Add(this.Workerdata(_j).HasValue ? this.Workerdata(_j).Value.UnPack() : null);
			_o.Distributorproductsdata = new List<SeasonalDistributorProductsDataT>();
			for (var _j = 0; _j < this.DistributorproductsdataLength; ++_j)
				_o.Distributorproductsdata.Add(this.Distributorproductsdata(_j).HasValue ? this.Distributorproductsdata(_j).Value.UnPack() : null);
			_o.Daystarttime = this.Daystarttime;
			_o.Slotcoinbufftime = this.Slotcoinbufftime;
			_o.Missioncoinbufftime = this.Missioncoinbufftime;
			_o.Useabtest = this.Useabtest;
			_o.Abtestype = this.Abtestype;
			_o.Coinrankdata = this.Coinrankdata.HasValue ? this.Coinrankdata.Value.UnPack() : null;
			_o.Isshownseasonendnotice = this.Isshownseasonendnotice;
			_o.Isshownseasonstartnotice = this.Isshownseasonstartnotice;
		}

		public static Offset<SeasonalStageData> Pack(FlatBufferBuilder builder, SeasonalStageDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalStageData>);
			var _currencydata = default(VectorOffset);
			if (_o.Currencydata != null)
			{
				var __currencydata = new Offset<SeasonalCurrencyData>[_o.Currencydata.Count];
				for (var _j = 0; _j < _o.Currencydata.Count; ++_j)
					__currencydata[_j] = SeasonalCurrencyData.Pack(builder, _o.Currencydata[_j]);
				_currencydata = CreateCurrencydataVector(builder, __currencydata);
			}
			var _arcademachinedata = _o.Arcademachinedata == null ? default(Offset<SeasonalArcadeMachineData>) : SeasonalArcadeMachineData.Pack(builder, _o.Arcademachinedata);
			var _buildingdata = default(VectorOffset);
			if (_o.Buildingdata != null)
			{
				var __buildingdata = new Offset<SeasonalBuildingData>[_o.Buildingdata.Count];
				for (var _j = 0; _j < _o.Buildingdata.Count; ++_j)
					__buildingdata[_j] = SeasonalBuildingData.Pack(builder, _o.Buildingdata[_j]);
				_buildingdata = CreateBuildingdataVector(builder, __buildingdata);
			}
			var _milestonedata = _o.Milestonedata == null ? default(Offset<SeasonalMilestoneData>) : SeasonalMilestoneData.Pack(builder, _o.Milestonedata);
			var _skilldata = default(VectorOffset);
			if (_o.Skilldata != null)
			{
				var __skilldata = new Offset<SeasonalSkillData>[_o.Skilldata.Count];
				for (var _j = 0; _j < _o.Skilldata.Count; ++_j)
					__skilldata[_j] = SeasonalSkillData.Pack(builder, _o.Skilldata[_j]);
				_skilldata = CreateSkilldataVector(builder, __skilldata);
			}
			var _missiondata = default(VectorOffset);
			if (_o.Missiondata != null)
			{
				var __missiondata = new Offset<SeasonalMissionData>[_o.Missiondata.Count];
				for (var _j = 0; _j < _o.Missiondata.Count; ++_j)
					__missiondata[_j] = SeasonalMissionData.Pack(builder, _o.Missiondata[_j]);
				_missiondata = CreateMissiondataVector(builder, __missiondata);
			}
			var _seasonaladsupplypiggy = _o.Seasonaladsupplypiggy == null ? default(Offset<AdsupplyPiggy>) : AdsupplyPiggy.Pack(builder, _o.Seasonaladsupplypiggy);
			var _completerewardlist = default(VectorOffset);
			if (_o.Completerewardlist != null)
			{
				var __completerewardlist = _o.Completerewardlist.ToArray();
				_completerewardlist = CreateCompleterewardlistVector(builder, __completerewardlist);
			}
			var _workerdata = default(VectorOffset);
			if (_o.Workerdata != null)
			{
				var __workerdata = new Offset<SeasonalWorkerData>[_o.Workerdata.Count];
				for (var _j = 0; _j < _o.Workerdata.Count; ++_j)
					__workerdata[_j] = SeasonalWorkerData.Pack(builder, _o.Workerdata[_j]);
				_workerdata = CreateWorkerdataVector(builder, __workerdata);
			}
			var _distributorproductsdata = default(VectorOffset);
			if (_o.Distributorproductsdata != null)
			{
				var __distributorproductsdata = new Offset<SeasonalDistributorProductsData>[_o.Distributorproductsdata.Count];
				for (var _j = 0; _j < _o.Distributorproductsdata.Count; ++_j)
					__distributorproductsdata[_j] = SeasonalDistributorProductsData.Pack(builder, _o.Distributorproductsdata[_j]);
				_distributorproductsdata = CreateDistributorproductsdataVector(builder, __distributorproductsdata);
			}
			var _coinrankdata = _o.Coinrankdata == null ? default(Offset<SeasonalCoinRankData>) : SeasonalCoinRankData.Pack(builder, _o.Coinrankdata);
			StartSeasonalStageData(builder);
			AddSeasoninfoidx(builder, _o.Seasoninfoidx);
			AddAdsupplytime(builder, _o.Adsupplytime);
			AddCurrencydata(builder, _currencydata);
			AddArcademachinedata(builder, _arcademachinedata);
			AddBuildingdata(builder, _buildingdata);
			AddMilestonedata(builder, _milestonedata);
			AddSkilldata(builder, _skilldata);
			AddMissiondata(builder, _missiondata);
			AddLastlogintime(builder, _o.Lastlogintime);
			AddAdsupplyresettime(builder, _o.Adsupplyresettime);
			AddAdsupplycount(builder, _o.Adsupplycount);
			AddGamestarttime(builder, _o.Gamestarttime);
			AddSeasonaladsupplypiggy(builder, _seasonaladsupplypiggy);
			AddOvertimeworkactive(builder, _o.Overtimeworkactive);
			AddCompleterewardlist(builder, _completerewardlist);
			AddSeasonpoint(builder, _o.Seasonpoint);
			AddWorkerdata(builder, _workerdata);
			AddDistributorproductsdata(builder, _distributorproductsdata);
			AddDaystarttime(builder, _o.Daystarttime);
			AddSlotcoinbufftime(builder, _o.Slotcoinbufftime);
			AddMissioncoinbufftime(builder, _o.Missioncoinbufftime);
			AddUseabtest(builder, _o.Useabtest);
			AddAbtestype(builder, _o.Abtestype);
			AddCoinrankdata(builder, _coinrankdata);
			AddIsshownseasonendnotice(builder, _o.Isshownseasonendnotice);
			AddIsshownseasonstartnotice(builder, _o.Isshownseasonstartnotice);
			return EndSeasonalStageData(builder);
		}
	}
}
