using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalBuildingWorkerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Facilityidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Hiredcount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalBuildingWorkerData GetRootAsSeasonalBuildingWorkerData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalBuildingWorkerData(_bb, new SeasonalBuildingWorkerData());
		}

		public static SeasonalBuildingWorkerData GetRootAsSeasonalBuildingWorkerData(ByteBuffer _bb, SeasonalBuildingWorkerData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalBuildingWorkerData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateHiredcount(int hiredcount)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, hiredcount);
				return true;
			}
			return false;
		}

		public static Offset<SeasonalBuildingWorkerData> CreateSeasonalBuildingWorkerData(FlatBufferBuilder builder, int facilityidx = 0, int hiredcount = 0)
		{
			builder.StartTable(2);
			AddHiredcount(builder, hiredcount);
			AddFacilityidx(builder, facilityidx);
			return EndSeasonalBuildingWorkerData(builder);
		}

		public static void StartSeasonalBuildingWorkerData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddFacilityidx(FlatBufferBuilder builder, int facilityidx)
		{
			builder.AddInt(0, facilityidx, 0);
		}

		public static void AddHiredcount(FlatBufferBuilder builder, int hiredcount)
		{
			builder.AddInt(1, hiredcount, 0);
		}

		public static Offset<SeasonalBuildingWorkerData> EndSeasonalBuildingWorkerData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalBuildingWorkerData>(o);
		}

		public SeasonalBuildingWorkerDataT UnPack()
		{
			var _o = new SeasonalBuildingWorkerDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalBuildingWorkerDataT _o)
		{
			_o.Facilityidx = this.Facilityidx;
			_o.Hiredcount = this.Hiredcount;
		}

		public static Offset<SeasonalBuildingWorkerData> Pack(FlatBufferBuilder builder, SeasonalBuildingWorkerDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalBuildingWorkerData>);
			StartSeasonalBuildingWorkerData(builder);
			AddFacilityidx(builder, _o.Facilityidx);
			AddHiredcount(builder, _o.Hiredcount);
			return EndSeasonalBuildingWorkerData(builder);
		}
	}
}
