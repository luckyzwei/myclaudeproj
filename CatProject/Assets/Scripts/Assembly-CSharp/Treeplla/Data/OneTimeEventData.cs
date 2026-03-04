using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OneTimeEventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Currency { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Levelexp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Receivelevel { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Companyresetcount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Companyresettime { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public bool Activebonustheme { get { int o = __p.__offset(18); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static OneTimeEventData GetRootAsOneTimeEventData(ByteBuffer _bb)
		{
			return GetRootAsOneTimeEventData(_bb, new OneTimeEventData());
		}

		public static OneTimeEventData GetRootAsOneTimeEventData(ByteBuffer _bb, OneTimeEventData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public OneTimeEventData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateCompanyresetcount(int companyresetcount)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, companyresetcount);
				return true;
			}
			return false;
		}

		public bool MutateCompanyresettime(long companyresettime)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, companyresettime);
				return true;
			}
			return false;
		}

		public bool MutateActivebonustheme(bool activebonustheme)
		{
			int o = __p.__offset(18);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(activebonustheme ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<OneTimeEventData> CreateOneTimeEventData(FlatBufferBuilder builder, int idx = 0, int currency = 0, int level = 0, int levelexp = 0, int receivelevel = 0, int companyresetcount = 0, long companyresettime = 0L, bool activebonustheme = false)
		{
			builder.StartTable(8);
			AddActivebonustheme(builder, activebonustheme);
			AddCompanyresettime(builder, companyresettime);
			AddCompanyresetcount(builder, companyresetcount);
			AddReceivelevel(builder, receivelevel);
			AddLevelexp(builder, levelexp);
			AddLevel(builder, level);
			AddCurrency(builder, currency);
			AddIdx(builder, idx);
			return EndOneTimeEventData(builder);
		}

		public static void StartOneTimeEventData(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
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

		public static void AddCompanyresetcount(FlatBufferBuilder builder, int companyresetcount)
		{
			builder.AddInt(5, companyresetcount, 0);
		}

		public static void AddCompanyresettime(FlatBufferBuilder builder, long companyresettime)
		{
			builder.AddLong(6, companyresettime, 0);
		}

		public static void AddActivebonustheme(FlatBufferBuilder builder, bool activebonustheme)
		{
			builder.AddBool(7, activebonustheme, false);
		}

		public static Offset<OneTimeEventData> EndOneTimeEventData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<OneTimeEventData>(o);
		}

		public OneTimeEventDataT UnPack()
		{
			var _o = new OneTimeEventDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(OneTimeEventDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Currency = this.Currency;
			_o.Level = this.Level;
			_o.Levelexp = this.Levelexp;
			_o.Receivelevel = this.Receivelevel;
			_o.Companyresetcount = this.Companyresetcount;
			_o.Companyresettime = this.Companyresettime;
			_o.Activebonustheme = this.Activebonustheme;
		}

		public static Offset<OneTimeEventData> Pack(FlatBufferBuilder builder, OneTimeEventDataT _o)
		{
			if (_o == null) return default(Offset<OneTimeEventData>);
			StartOneTimeEventData(builder);
			AddIdx(builder, _o.Idx);
			AddCurrency(builder, _o.Currency);
			AddLevel(builder, _o.Level);
			AddLevelexp(builder, _o.Levelexp);
			AddReceivelevel(builder, _o.Receivelevel);
			AddCompanyresetcount(builder, _o.Companyresetcount);
			AddCompanyresettime(builder, _o.Companyresettime);
			AddActivebonustheme(builder, _o.Activebonustheme);
			return EndOneTimeEventData(builder);
		}
	}
}
