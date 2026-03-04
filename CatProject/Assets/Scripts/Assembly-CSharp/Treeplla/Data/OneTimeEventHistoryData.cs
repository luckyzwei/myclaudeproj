using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OneTimeEventHistoryData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Currency { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Levelexp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Receivelevel { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Activebonustheme { get { int o = __p.__offset(14); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static OneTimeEventHistoryData GetRootAsOneTimeEventHistoryData(ByteBuffer _bb)
		{
			return GetRootAsOneTimeEventHistoryData(_bb, new OneTimeEventHistoryData());
		}

		public static OneTimeEventHistoryData GetRootAsOneTimeEventHistoryData(ByteBuffer _bb, OneTimeEventHistoryData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public OneTimeEventHistoryData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIdx(int idx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, idx);
				return true;
			}
			return false;
		}

		public bool MutateCurrency(int currency)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, currency);
				return true;
			}
			return false;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public bool MutateLevelexp(int levelexp)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, levelexp);
				return true;
			}
			return false;
		}

		public bool MutateReceivelevel(int receivelevel)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, receivelevel);
				return true;
			}
			return false;
		}

		public bool MutateActivebonustheme(bool activebonustheme)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(activebonustheme ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<OneTimeEventHistoryData> CreateOneTimeEventHistoryData(FlatBufferBuilder builder, int idx = 0, int currency = 0, int level = 0, int levelexp = 0, int receivelevel = 0, bool activebonustheme = false)
		{
			builder.StartTable(6);
			AddActivebonustheme(builder, activebonustheme);
			AddReceivelevel(builder, receivelevel);
			AddLevelexp(builder, levelexp);
			AddLevel(builder, level);
			AddCurrency(builder, currency);
			AddIdx(builder, idx);
			return EndOneTimeEventHistoryData(builder);
		}

		public static void StartOneTimeEventHistoryData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddCurrency(FlatBufferBuilder builder, int currency)
		{
			builder.AddInt(1, currency, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(2, level, 0);
		}

		public static void AddLevelexp(FlatBufferBuilder builder, int levelexp)
		{
			builder.AddInt(3, levelexp, 0);
		}

		public static void AddReceivelevel(FlatBufferBuilder builder, int receivelevel)
		{
			builder.AddInt(4, receivelevel, 0);
		}

		public static void AddActivebonustheme(FlatBufferBuilder builder, bool activebonustheme)
		{
			builder.AddBool(5, activebonustheme, false);
		}

		public static Offset<OneTimeEventHistoryData> EndOneTimeEventHistoryData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<OneTimeEventHistoryData>(o);
		}

		public OneTimeEventHistoryDataT UnPack()
		{
			var _o = new OneTimeEventHistoryDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(OneTimeEventHistoryDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Currency = this.Currency;
			_o.Level = this.Level;
			_o.Levelexp = this.Levelexp;
			_o.Receivelevel = this.Receivelevel;
			_o.Activebonustheme = this.Activebonustheme;
		}

		public static Offset<OneTimeEventHistoryData> Pack(FlatBufferBuilder builder, OneTimeEventHistoryDataT _o)
		{
			if (_o == null) return default(Offset<OneTimeEventHistoryData>);
			StartOneTimeEventHistoryData(builder);
			AddIdx(builder, _o.Idx);
			AddCurrency(builder, _o.Currency);
			AddLevel(builder, _o.Level);
			AddLevelexp(builder, _o.Levelexp);
			AddReceivelevel(builder, _o.Receivelevel);
			AddActivebonustheme(builder, _o.Activebonustheme);
			return EndOneTimeEventHistoryData(builder);
		}
	}
}
