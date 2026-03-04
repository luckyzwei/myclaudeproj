using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BizAcqData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Curstageidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public BizAcqTeamData? Teamdata { get { int o = __p.__offset(6); return o != 0 ? (new BizAcqTeamData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public long Lastrewardgettime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Laststagecleartime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int AccumulaterewardsLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Autoplayguideshowntime { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Multiplerewardgetcount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Multiplerewardlastgettime { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int PassreceiveLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Autoplayon { get { int o = __p.__offset(22); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Battlespeedindex { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Accumulatereinstone { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public long Lastrewardaccumulatetime { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Weeklyshopshowntime { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public string Jewelryboxvalue { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public int Jewelryboxlevel { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Jewelryboxstagestep { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Jewelryboxstagelastshownstep { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Activespeedtrial { get { int o = __p.__offset(40); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BizAcqData GetRootAsBizAcqData(ByteBuffer _bb)
		{
			return GetRootAsBizAcqData(_bb, new BizAcqData());
		}

		public static BizAcqData GetRootAsBizAcqData(ByteBuffer _bb, BizAcqData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BizAcqData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateCurstageidx(int curstageidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, curstageidx);
				return true;
			}
			return false;
		}

		public bool MutateLastrewardgettime(long lastrewardgettime)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastrewardgettime);
				return true;
			}
			return false;
		}

		public bool MutateLaststagecleartime(long laststagecleartime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, laststagecleartime);
				return true;
			}
			return false;
		}

		public CurrencyData? Accumulaterewards(int j)
		{
			int o = __p.__offset(12);
			return o != 0 ? (new CurrencyData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateAutoplayguideshowntime(long autoplayguideshowntime)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, autoplayguideshowntime);
				return true;
			}
			return false;
		}

		public bool MutateMultiplerewardgetcount(int multiplerewardgetcount)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, multiplerewardgetcount);
				return true;
			}
			return false;
		}

		public bool MutateMultiplerewardlastgettime(long multiplerewardlastgettime)
		{
			int o = __p.__offset(18);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, multiplerewardlastgettime);
				return true;
			}
			return false;
		}

		public PassReceiveData? Passreceive(int j)
		{
			int o = __p.__offset(20);
			return o != 0 ? (new PassReceiveData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateAutoplayon(bool autoplayon)
		{
			int o = __p.__offset(22);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(autoplayon ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateBattlespeedindex(int battlespeedindex)
		{
			int o = __p.__offset(24);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, battlespeedindex);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetAccumulatereinstoneBytes()
		{
			return __p.__vector_as_arraysegment(26);
		}

		public byte[] GetAccumulatereinstoneArray()
		{
			return __p.__vector_as_array<byte>(26);
		}

		public bool MutateLastrewardaccumulatetime(long lastrewardaccumulatetime)
		{
			int o = __p.__offset(28);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastrewardaccumulatetime);
				return true;
			}
			return false;
		}

		public bool MutateWeeklyshopshowntime(long weeklyshopshowntime)
		{
			int o = __p.__offset(30);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, weeklyshopshowntime);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetJewelryboxvalueBytes()
		{
			return __p.__vector_as_arraysegment(32);
		}

		public byte[] GetJewelryboxvalueArray()
		{
			return __p.__vector_as_array<byte>(32);
		}

		public bool MutateJewelryboxlevel(int jewelryboxlevel)
		{
			int o = __p.__offset(34);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, jewelryboxlevel);
				return true;
			}
			return false;
		}

		public bool MutateJewelryboxstagestep(int jewelryboxstagestep)
		{
			int o = __p.__offset(36);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, jewelryboxstagestep);
				return true;
			}
			return false;
		}

		public bool MutateJewelryboxstagelastshownstep(int jewelryboxstagelastshownstep)
		{
			int o = __p.__offset(38);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, jewelryboxstagelastshownstep);
				return true;
			}
			return false;
		}

		public bool MutateActivespeedtrial(bool activespeedtrial)
		{
			int o = __p.__offset(40);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(activespeedtrial ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<BizAcqData> CreateBizAcqData(FlatBufferBuilder builder, int curstageidx = 0, Offset<BizAcqTeamData> teamdataOffset = default(Offset<BizAcqTeamData>), long lastrewardgettime = 0L, long laststagecleartime = 0L, VectorOffset accumulaterewardsOffset = default(VectorOffset), long autoplayguideshowntime = 0L, int multiplerewardgetcount = 0, long multiplerewardlastgettime = 0L, VectorOffset passreceiveOffset = default(VectorOffset), bool autoplayon = false, int battlespeedindex = 0, StringOffset accumulatereinstoneOffset = default(StringOffset), long lastrewardaccumulatetime = 0L, long weeklyshopshowntime = 0L, StringOffset jewelryboxvalueOffset = default(StringOffset), int jewelryboxlevel = 1, int jewelryboxstagestep = 0, int jewelryboxstagelastshownstep = 0, bool activespeedtrial = false)
		{
			builder.StartTable(19);
			AddActivespeedtrial(builder, activespeedtrial);
			AddJewelryboxstagelastshownstep(builder, jewelryboxstagelastshownstep);
			AddJewelryboxstagestep(builder, jewelryboxstagestep);
			AddJewelryboxlevel(builder, jewelryboxlevel);
			AddJewelryboxvalue(builder, jewelryboxvalueOffset);
			AddWeeklyshopshowntime(builder, weeklyshopshowntime);
			AddLastrewardaccumulatetime(builder, lastrewardaccumulatetime);
			AddAccumulatereinstone(builder, accumulatereinstoneOffset);
			AddBattlespeedindex(builder, battlespeedindex);
			AddAutoplayon(builder, autoplayon);
			AddPassreceive(builder, passreceiveOffset);
			AddMultiplerewardlastgettime(builder, multiplerewardlastgettime);
			AddMultiplerewardgetcount(builder, multiplerewardgetcount);
			AddAutoplayguideshowntime(builder, autoplayguideshowntime);
			AddAccumulaterewards(builder, accumulaterewardsOffset);
			AddLaststagecleartime(builder, laststagecleartime);
			AddLastrewardgettime(builder, lastrewardgettime);
			AddTeamdata(builder, teamdataOffset);
			AddCurstageidx(builder, curstageidx);
			return EndBizAcqData(builder);
		}

		public static void StartBizAcqData(FlatBufferBuilder builder)
		{
			builder.StartTable(21);
		}

		public static void AddCurstageidx(FlatBufferBuilder builder, int curstageidx)
		{
			builder.AddInt(0, curstageidx, 0);
		}

		public static void AddTeamdata(FlatBufferBuilder builder, Offset<BizAcqTeamData> teamdataOffset)
		{
			builder.AddOffset(1, teamdataOffset.Value, 0);
		}

		public static void AddLastrewardgettime(FlatBufferBuilder builder, long lastrewardgettime)
		{
			builder.AddLong(2, lastrewardgettime, 0);
		}

		public static void AddLaststagecleartime(FlatBufferBuilder builder, long laststagecleartime)
		{
			builder.AddLong(3, laststagecleartime, 0);
		}

		public static void AddAccumulaterewards(FlatBufferBuilder builder, VectorOffset accumulaterewardsOffset)
		{
			builder.AddOffset(4, accumulaterewardsOffset.Value, 0);
		}

		public static VectorOffset CreateAccumulaterewardsVector(FlatBufferBuilder builder, Offset<CurrencyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateAccumulaterewardsVectorBlock(FlatBufferBuilder builder, Offset<CurrencyData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAccumulaterewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CurrencyData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAccumulaterewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartAccumulaterewardsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddAutoplayguideshowntime(FlatBufferBuilder builder, long autoplayguideshowntime)
		{
			builder.AddLong(5, autoplayguideshowntime, 0);
		}

		public static void AddMultiplerewardgetcount(FlatBufferBuilder builder, int multiplerewardgetcount)
		{
			builder.AddInt(6, multiplerewardgetcount, 0);
		}

		public static void AddMultiplerewardlastgettime(FlatBufferBuilder builder, long multiplerewardlastgettime)
		{
			builder.AddLong(7, multiplerewardlastgettime, 0);
		}

		public static void AddPassreceive(FlatBufferBuilder builder, VectorOffset passreceiveOffset)
		{
			builder.AddOffset(8, passreceiveOffset.Value, 0);
		}

		public static VectorOffset CreatePassreceiveVector(FlatBufferBuilder builder, Offset<PassReceiveData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreatePassreceiveVectorBlock(FlatBufferBuilder builder, Offset<PassReceiveData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreatePassreceiveVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<PassReceiveData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreatePassreceiveVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartPassreceiveVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddAutoplayon(FlatBufferBuilder builder, bool autoplayon)
		{
			builder.AddBool(9, autoplayon, false);
		}

		public static void AddBattlespeedindex(FlatBufferBuilder builder, int battlespeedindex)
		{
			builder.AddInt(10, battlespeedindex, 0);
		}

		public static void AddAccumulatereinstone(FlatBufferBuilder builder, StringOffset accumulatereinstoneOffset)
		{
			builder.AddOffset(11, accumulatereinstoneOffset.Value, 0);
		}

		public static void AddLastrewardaccumulatetime(FlatBufferBuilder builder, long lastrewardaccumulatetime)
		{
			builder.AddLong(12, lastrewardaccumulatetime, 0);
		}

		public static void AddWeeklyshopshowntime(FlatBufferBuilder builder, long weeklyshopshowntime)
		{
			builder.AddLong(13, weeklyshopshowntime, 0);
		}

		public static void AddJewelryboxvalue(FlatBufferBuilder builder, StringOffset jewelryboxvalueOffset)
		{
			builder.AddOffset(14, jewelryboxvalueOffset.Value, 0);
		}

		public static void AddJewelryboxlevel(FlatBufferBuilder builder, int jewelryboxlevel)
		{
			builder.AddInt(15, jewelryboxlevel, 0);
		}

		public static void AddJewelryboxstagestep(FlatBufferBuilder builder, int jewelryboxstagestep)
		{
			builder.AddInt(16, jewelryboxstagestep, 0);
		}

		public static void AddJewelryboxstagelastshownstep(FlatBufferBuilder builder, int jewelryboxstagelastshownstep)
		{
			builder.AddInt(17, jewelryboxstagelastshownstep, 0);
		}

		public static void AddActivespeedtrial(FlatBufferBuilder builder, bool activespeedtrial)
		{
			builder.AddBool(18, activespeedtrial, false);
		}

		public static Offset<BizAcqData> EndBizAcqData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BizAcqData>(o);
		}

		public BizAcqDataT UnPack()
		{
			var _o = new BizAcqDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BizAcqDataT _o)
		{
			_o.Curstageidx = this.Curstageidx;
			_o.Teamdata = this.Teamdata.HasValue ? this.Teamdata.Value.UnPack() : null;
			_o.Lastrewardgettime = this.Lastrewardgettime;
			_o.Laststagecleartime = this.Laststagecleartime;
			_o.Accumulaterewards = new List<CurrencyDataT>();
			for (var _j = 0; _j < this.AccumulaterewardsLength; ++_j)
				_o.Accumulaterewards.Add(this.Accumulaterewards(_j).HasValue ? this.Accumulaterewards(_j).Value.UnPack() : null);
			_o.Autoplayguideshowntime = this.Autoplayguideshowntime;
			_o.Multiplerewardgetcount = this.Multiplerewardgetcount;
			_o.Multiplerewardlastgettime = this.Multiplerewardlastgettime;
			_o.Passreceive = new List<PassReceiveDataT>();
			for (var _j = 0; _j < this.PassreceiveLength; ++_j)
				_o.Passreceive.Add(this.Passreceive(_j).HasValue ? this.Passreceive(_j).Value.UnPack() : null);
			_o.Autoplayon = this.Autoplayon;
			_o.Battlespeedindex = this.Battlespeedindex;
			_o.Accumulatereinstone = this.Accumulatereinstone;
			_o.Lastrewardaccumulatetime = this.Lastrewardaccumulatetime;
			_o.Weeklyshopshowntime = this.Weeklyshopshowntime;
			_o.Jewelryboxvalue = this.Jewelryboxvalue;
			_o.Jewelryboxlevel = this.Jewelryboxlevel;
			_o.Jewelryboxstagestep = this.Jewelryboxstagestep;
			_o.Jewelryboxstagelastshownstep = this.Jewelryboxstagelastshownstep;
			_o.Activespeedtrial = this.Activespeedtrial;
		}

		public static Offset<BizAcqData> Pack(FlatBufferBuilder builder, BizAcqDataT _o)
		{
			if (_o == null) return default(Offset<BizAcqData>);
			var _teamdata = _o.Teamdata == null ? default(Offset<BizAcqTeamData>) : BizAcqTeamData.Pack(builder, _o.Teamdata);
			var _accumulaterewards = default(VectorOffset);
			if (_o.Accumulaterewards != null)
			{
				var __accumulaterewards = new Offset<CurrencyData>[_o.Accumulaterewards.Count];
				for (var _j = 0; _j < _o.Accumulaterewards.Count; ++_j)
					__accumulaterewards[_j] = CurrencyData.Pack(builder, _o.Accumulaterewards[_j]);
				_accumulaterewards = CreateAccumulaterewardsVector(builder, __accumulaterewards);
			}
			var _passreceive = default(VectorOffset);
			if (_o.Passreceive != null)
			{
				var __passreceive = new Offset<PassReceiveData>[_o.Passreceive.Count];
				for (var _j = 0; _j < _o.Passreceive.Count; ++_j)
					__passreceive[_j] = PassReceiveData.Pack(builder, _o.Passreceive[_j]);
				_passreceive = CreatePassreceiveVector(builder, __passreceive);
			}
			var _accumulatereinstone = _o.Accumulatereinstone == null ? default(StringOffset) : builder.CreateString(_o.Accumulatereinstone);
			var _jewelryboxvalue = _o.Jewelryboxvalue == null ? default(StringOffset) : builder.CreateString(_o.Jewelryboxvalue);
			StartBizAcqData(builder);
			AddCurstageidx(builder, _o.Curstageidx);
			AddTeamdata(builder, _teamdata);
			AddLastrewardgettime(builder, _o.Lastrewardgettime);
			AddLaststagecleartime(builder, _o.Laststagecleartime);
			AddAccumulaterewards(builder, _accumulaterewards);
			AddAutoplayguideshowntime(builder, _o.Autoplayguideshowntime);
			AddMultiplerewardgetcount(builder, _o.Multiplerewardgetcount);
			AddMultiplerewardlastgettime(builder, _o.Multiplerewardlastgettime);
			AddPassreceive(builder, _passreceive);
			AddAutoplayon(builder, _o.Autoplayon);
			AddBattlespeedindex(builder, _o.Battlespeedindex);
			AddAccumulatereinstone(builder, _accumulatereinstone);
			AddLastrewardaccumulatetime(builder, _o.Lastrewardaccumulatetime);
			AddWeeklyshopshowntime(builder, _o.Weeklyshopshowntime);
			AddJewelryboxvalue(builder, _jewelryboxvalue);
			AddJewelryboxlevel(builder, _o.Jewelryboxlevel);
			AddJewelryboxstagestep(builder, _o.Jewelryboxstagestep);
			AddJewelryboxstagelastshownstep(builder, _o.Jewelryboxstagelastshownstep);
			AddActivespeedtrial(builder, _o.Activespeedtrial);
			return EndBizAcqData(builder);
		}
	}
}
