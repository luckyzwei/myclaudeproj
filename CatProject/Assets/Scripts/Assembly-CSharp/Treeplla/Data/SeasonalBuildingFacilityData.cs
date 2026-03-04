using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalBuildingFacilityData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Facilityidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalBuildingFacilityData GetRootAsSeasonalBuildingFacilityData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalBuildingFacilityData(_bb, new SeasonalBuildingFacilityData());
		}

		public static SeasonalBuildingFacilityData GetRootAsSeasonalBuildingFacilityData(ByteBuffer _bb, SeasonalBuildingFacilityData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalBuildingFacilityData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateFacilityidx(int facilityidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, facilityidx);
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

		public static Offset<SeasonalBuildingFacilityData> CreateSeasonalBuildingFacilityData(FlatBufferBuilder builder, int facilityidx = 0, int level = 0)
		{
			builder.StartTable(2);
			AddLevel(builder, level);
			AddFacilityidx(builder, facilityidx);
			return EndSeasonalBuildingFacilityData(builder);
		}

		public static void StartSeasonalBuildingFacilityData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddFacilityidx(FlatBufferBuilder builder, int facilityidx)
		{
			builder.AddInt(0, facilityidx, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static Offset<SeasonalBuildingFacilityData> EndSeasonalBuildingFacilityData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalBuildingFacilityData>(o);
		}

		public SeasonalBuildingFacilityDataT UnPack()
		{
			var _o = new SeasonalBuildingFacilityDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalBuildingFacilityDataT _o)
		{
			_o.Facilityidx = this.Facilityidx;
			_o.Level = this.Level;
		}

		public static Offset<SeasonalBuildingFacilityData> Pack(FlatBufferBuilder builder, SeasonalBuildingFacilityDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalBuildingFacilityData>);
			StartSeasonalBuildingFacilityData(builder);
			AddFacilityidx(builder, _o.Facilityidx);
			AddLevel(builder, _o.Level);
			return EndSeasonalBuildingFacilityData(builder);
		}
	}
}
