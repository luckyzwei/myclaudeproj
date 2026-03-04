using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct InvestData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Selectcompany { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Rewardmoney { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public long Refreshtime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Startttime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Multiplevalue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Startinvesttime { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public string Investmoney { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static InvestData GetRootAsInvestData(ByteBuffer _bb)
		{
			return GetRootAsInvestData(_bb, new InvestData());
		}

		public static InvestData GetRootAsInvestData(ByteBuffer _bb, InvestData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public InvestData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSelectcompany(int selectcompany)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, selectcompany);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetRewardmoneyBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public byte[] GetRewardmoneyArray()
		{
			return __p.__vector_as_array<byte>(6);
		}

		public bool MutateRefreshtime(long refreshtime)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, refreshtime);
				return true;
			}
			return false;
		}

		public bool MutateStartttime(long startttime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, startttime);
				return true;
			}
			return false;
		}

		public bool MutateMultiplevalue(int multiplevalue)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, multiplevalue);
				return true;
			}
			return false;
		}

		public bool MutateStartinvesttime(long startinvesttime)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, startinvesttime);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetInvestmoneyBytes()
		{
			return __p.__vector_as_arraysegment(16);
		}

		public byte[] GetInvestmoneyArray()
		{
			return __p.__vector_as_array<byte>(16);
		}

		public static Offset<InvestData> CreateInvestData(FlatBufferBuilder builder, int selectcompany = -1, StringOffset rewardmoneyOffset = default(StringOffset), long refreshtime = 0L, long startttime = 0L, int multiplevalue = -1, long startinvesttime = 0L, StringOffset investmoneyOffset = default(StringOffset))
		{
			builder.StartTable(7);
			AddInvestmoney(builder, investmoneyOffset);
			AddStartinvesttime(builder, startinvesttime);
			AddMultiplevalue(builder, multiplevalue);
			AddStartttime(builder, startttime);
			AddRefreshtime(builder, refreshtime);
			AddRewardmoney(builder, rewardmoneyOffset);
			AddSelectcompany(builder, selectcompany);
			return EndInvestData(builder);
		}

		public static void StartInvestData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		public static void AddSelectcompany(FlatBufferBuilder builder, int selectcompany)
		{
			builder.AddInt(0, selectcompany, 0);
		}

		public static void AddRewardmoney(FlatBufferBuilder builder, StringOffset rewardmoneyOffset)
		{
			builder.AddOffset(1, rewardmoneyOffset.Value, 0);
		}

		public static void AddRefreshtime(FlatBufferBuilder builder, long refreshtime)
		{
			builder.AddLong(2, refreshtime, 0);
		}

		public static void AddStartttime(FlatBufferBuilder builder, long startttime)
		{
			builder.AddLong(3, startttime, 0);
		}

		public static void AddMultiplevalue(FlatBufferBuilder builder, int multiplevalue)
		{
			builder.AddInt(4, multiplevalue, 0);
		}

		public static void AddStartinvesttime(FlatBufferBuilder builder, long startinvesttime)
		{
			builder.AddLong(5, startinvesttime, 0);
		}

		public static void AddInvestmoney(FlatBufferBuilder builder, StringOffset investmoneyOffset)
		{
			builder.AddOffset(6, investmoneyOffset.Value, 0);
		}

		public static Offset<InvestData> EndInvestData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<InvestData>(o);
		}

		public InvestDataT UnPack()
		{
			var _o = new InvestDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(InvestDataT _o)
		{
			_o.Selectcompany = this.Selectcompany;
			_o.Rewardmoney = this.Rewardmoney;
			_o.Refreshtime = this.Refreshtime;
			_o.Startttime = this.Startttime;
			_o.Multiplevalue = this.Multiplevalue;
			_o.Startinvesttime = this.Startinvesttime;
			_o.Investmoney = this.Investmoney;
		}

		public static Offset<InvestData> Pack(FlatBufferBuilder builder, InvestDataT _o)
		{
			if (_o == null) return default(Offset<InvestData>);
			var _rewardmoney = _o.Rewardmoney == null ? default(StringOffset) : builder.CreateString(_o.Rewardmoney);
			var _investmoney = _o.Investmoney == null ? default(StringOffset) : builder.CreateString(_o.Investmoney);
			StartInvestData(builder);
			AddSelectcompany(builder, _o.Selectcompany);
			AddRewardmoney(builder, _rewardmoney);
			AddRefreshtime(builder, _o.Refreshtime);
			AddStartttime(builder, _o.Startttime);
			AddMultiplevalue(builder, _o.Multiplevalue);
			AddStartinvesttime(builder, _o.Startinvesttime);
			AddInvestmoney(builder, _investmoney);
			return EndInvestData(builder);
		}
	}
}
