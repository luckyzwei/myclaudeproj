using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalArcadeMachineData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Bettingmultiplevalue { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Receivedfirstfixedreward { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Roulettecount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Usefirstfreechance { get { int o = __p.__offset(12); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Firstfreechancecheckcount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalArcadeMachineData GetRootAsSeasonalArcadeMachineData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalArcadeMachineData(_bb, new SeasonalArcadeMachineData());
		}

		public static SeasonalArcadeMachineData GetRootAsSeasonalArcadeMachineData(ByteBuffer _bb, SeasonalArcadeMachineData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalArcadeMachineData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public bool MutateBettingmultiplevalue(int bettingmultiplevalue)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, bettingmultiplevalue);
				return true;
			}
			return false;
		}

		public bool MutateReceivedfirstfixedreward(bool receivedfirstfixedreward)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(receivedfirstfixedreward ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateRoulettecount(int roulettecount)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, roulettecount);
				return true;
			}
			return false;
		}

		public bool MutateUsefirstfreechance(bool usefirstfreechance)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(usefirstfreechance ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateFirstfreechancecheckcount(int firstfreechancecheckcount)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, firstfreechancecheckcount);
				return true;
			}
			return false;
		}

		public static Offset<SeasonalArcadeMachineData> CreateSeasonalArcadeMachineData(FlatBufferBuilder builder, int level = 0, int bettingmultiplevalue = 0, bool receivedfirstfixedreward = false, int roulettecount = 0, bool usefirstfreechance = false, int firstfreechancecheckcount = 0)
		{
			builder.StartTable(6);
			AddFirstfreechancecheckcount(builder, firstfreechancecheckcount);
			AddUsefirstfreechance(builder, usefirstfreechance);
			AddRoulettecount(builder, roulettecount);
			AddReceivedfirstfixedreward(builder, receivedfirstfixedreward);
			AddBettingmultiplevalue(builder, bettingmultiplevalue);
			AddLevel(builder, level);
			return EndSeasonalArcadeMachineData(builder);
		}

		public static void StartSeasonalArcadeMachineData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(0, level, 0);
		}

		public static void AddBettingmultiplevalue(FlatBufferBuilder builder, int bettingmultiplevalue)
		{
			builder.AddInt(1, bettingmultiplevalue, 0);
		}

		public static void AddReceivedfirstfixedreward(FlatBufferBuilder builder, bool receivedfirstfixedreward)
		{
			builder.AddBool(2, receivedfirstfixedreward, false);
		}

		public static void AddRoulettecount(FlatBufferBuilder builder, int roulettecount)
		{
			builder.AddInt(3, roulettecount, 0);
		}

		public static void AddUsefirstfreechance(FlatBufferBuilder builder, bool usefirstfreechance)
		{
			builder.AddBool(4, usefirstfreechance, false);
		}

		public static void AddFirstfreechancecheckcount(FlatBufferBuilder builder, int firstfreechancecheckcount)
		{
			builder.AddInt(5, firstfreechancecheckcount, 0);
		}

		public static Offset<SeasonalArcadeMachineData> EndSeasonalArcadeMachineData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalArcadeMachineData>(o);
		}

		public SeasonalArcadeMachineDataT UnPack()
		{
			var _o = new SeasonalArcadeMachineDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalArcadeMachineDataT _o)
		{
			_o.Level = this.Level;
			_o.Bettingmultiplevalue = this.Bettingmultiplevalue;
			_o.Receivedfirstfixedreward = this.Receivedfirstfixedreward;
			_o.Roulettecount = this.Roulettecount;
			_o.Usefirstfreechance = this.Usefirstfreechance;
			_o.Firstfreechancecheckcount = this.Firstfreechancecheckcount;
		}

		public static Offset<SeasonalArcadeMachineData> Pack(FlatBufferBuilder builder, SeasonalArcadeMachineDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalArcadeMachineData>);
			StartSeasonalArcadeMachineData(builder);
			AddLevel(builder, _o.Level);
			AddBettingmultiplevalue(builder, _o.Bettingmultiplevalue);
			AddReceivedfirstfixedreward(builder, _o.Receivedfirstfixedreward);
			AddRoulettecount(builder, _o.Roulettecount);
			AddUsefirstfreechance(builder, _o.Usefirstfreechance);
			AddFirstfreechancecheckcount(builder, _o.Firstfreechancecheckcount);
			return EndSeasonalArcadeMachineData(builder);
		}
	}
}
