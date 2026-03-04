using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalWorkshopManagerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Manageridx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalWorkshopManagerData GetRootAsSeasonalWorkshopManagerData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalWorkshopManagerData(_bb, new SeasonalWorkshopManagerData());
		}

		public static SeasonalWorkshopManagerData GetRootAsSeasonalWorkshopManagerData(ByteBuffer _bb, SeasonalWorkshopManagerData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalWorkshopManagerData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateManageridx(int manageridx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, manageridx);
				return true;
			}
			return false;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public static Offset<SeasonalWorkshopManagerData> CreateSeasonalWorkshopManagerData(FlatBufferBuilder builder, int manageridx = 0, int level = 0)
		{
			builder.StartTable(2);
			AddLevel(builder, level);
			AddManageridx(builder, manageridx);
			return EndSeasonalWorkshopManagerData(builder);
		}

		public static void StartSeasonalWorkshopManagerData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddManageridx(FlatBufferBuilder builder, int manageridx)
		{
			builder.AddInt(0, manageridx, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static Offset<SeasonalWorkshopManagerData> EndSeasonalWorkshopManagerData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalWorkshopManagerData>(o);
		}

		public SeasonalWorkshopManagerDataT UnPack()
		{
			var _o = new SeasonalWorkshopManagerDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalWorkshopManagerDataT _o)
		{
			_o.Manageridx = this.Manageridx;
			_o.Level = this.Level;
		}

		public static Offset<SeasonalWorkshopManagerData> Pack(FlatBufferBuilder builder, SeasonalWorkshopManagerDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalWorkshopManagerData>);
			StartSeasonalWorkshopManagerData(builder);
			AddManageridx(builder, _o.Manageridx);
			AddLevel(builder, _o.Level);
			return EndSeasonalWorkshopManagerData(builder);
		}
	}
}
