using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BoosterRegionBuffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Boosteridx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Boosteractiveregionidx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Boosterremaintimesec { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Boosternextresettime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Boosterdailyusecount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BoosterRegionBuffData GetRootAsBoosterRegionBuffData(ByteBuffer _bb)
		{
			return GetRootAsBoosterRegionBuffData(_bb, new BoosterRegionBuffData());
		}

		public static BoosterRegionBuffData GetRootAsBoosterRegionBuffData(ByteBuffer _bb, BoosterRegionBuffData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BoosterRegionBuffData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateBoosteridx(int boosteridx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, boosteridx);
				return true;
			}
			return false;
		}

		public bool MutateBoosteractiveregionidx(int boosteractiveregionidx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, boosteractiveregionidx);
				return true;
			}
			return false;
		}

		public bool MutateBoosterremaintimesec(int boosterremaintimesec)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, boosterremaintimesec);
				return true;
			}
			return false;
		}

		public bool MutateBoosternextresettime(long boosternextresettime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, boosternextresettime);
				return true;
			}
			return false;
		}

		public bool MutateBoosterdailyusecount(int boosterdailyusecount)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, boosterdailyusecount);
				return true;
			}
			return false;
		}

		public static Offset<BoosterRegionBuffData> CreateBoosterRegionBuffData(FlatBufferBuilder builder, int boosteridx = 0, int boosteractiveregionidx = 0, int boosterremaintimesec = 0, long boosternextresettime = 0L, int boosterdailyusecount = 0)
		{
			builder.StartTable(5);
			AddBoosterdailyusecount(builder, boosterdailyusecount);
			AddBoosternextresettime(builder, boosternextresettime);
			AddBoosterremaintimesec(builder, boosterremaintimesec);
			AddBoosteractiveregionidx(builder, boosteractiveregionidx);
			AddBoosteridx(builder, boosteridx);
			return EndBoosterRegionBuffData(builder);
		}

		public static void StartBoosterRegionBuffData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddBoosteridx(FlatBufferBuilder builder, int boosteridx)
		{
			builder.AddInt(0, boosteridx, 0);
		}

		public static void AddBoosteractiveregionidx(FlatBufferBuilder builder, int boosteractiveregionidx)
		{
			builder.AddInt(1, boosteractiveregionidx, 0);
		}

		public static void AddBoosterremaintimesec(FlatBufferBuilder builder, int boosterremaintimesec)
		{
			builder.AddInt(2, boosterremaintimesec, 0);
		}

		public static void AddBoosternextresettime(FlatBufferBuilder builder, long boosternextresettime)
		{
			builder.AddLong(3, boosternextresettime, 0);
		}

		public static void AddBoosterdailyusecount(FlatBufferBuilder builder, int boosterdailyusecount)
		{
			builder.AddInt(4, boosterdailyusecount, 0);
		}

		public static Offset<BoosterRegionBuffData> EndBoosterRegionBuffData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BoosterRegionBuffData>(o);
		}

		public BoosterRegionBuffDataT UnPack()
		{
			var _o = new BoosterRegionBuffDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BoosterRegionBuffDataT _o)
		{
			_o.Boosteridx = this.Boosteridx;
			_o.Boosteractiveregionidx = this.Boosteractiveregionidx;
			_o.Boosterremaintimesec = this.Boosterremaintimesec;
			_o.Boosternextresettime = this.Boosternextresettime;
			_o.Boosterdailyusecount = this.Boosterdailyusecount;
		}

		public static Offset<BoosterRegionBuffData> Pack(FlatBufferBuilder builder, BoosterRegionBuffDataT _o)
		{
			if (_o == null) return default(Offset<BoosterRegionBuffData>);
			StartBoosterRegionBuffData(builder);
			AddBoosteridx(builder, _o.Boosteridx);
			AddBoosteractiveregionidx(builder, _o.Boosteractiveregionidx);
			AddBoosterremaintimesec(builder, _o.Boosterremaintimesec);
			AddBoosternextresettime(builder, _o.Boosternextresettime);
			AddBoosterdailyusecount(builder, _o.Boosterdailyusecount);
			return EndBoosterRegionBuffData(builder);
		}
	}
}
