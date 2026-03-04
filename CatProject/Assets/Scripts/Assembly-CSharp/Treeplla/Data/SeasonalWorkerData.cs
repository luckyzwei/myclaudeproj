using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalWorkerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Workeridx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Assignedbuildingidx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Assignedbuildingtransformidx { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Mood { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Lastuserestauranttime { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalWorkerData GetRootAsSeasonalWorkerData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalWorkerData(_bb, new SeasonalWorkerData());
		}

		public static SeasonalWorkerData GetRootAsSeasonalWorkerData(ByteBuffer _bb, SeasonalWorkerData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalWorkerData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateWorkeridx(int workeridx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, workeridx);
				return true;
			}
			return false;
		}

		public bool MutateAssignedbuildingidx(int assignedbuildingidx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, assignedbuildingidx);
				return true;
			}
			return false;
		}

		public bool MutateAssignedbuildingtransformidx(int assignedbuildingtransformidx)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, assignedbuildingtransformidx);
				return true;
			}
			return false;
		}

		public bool MutateMood(int mood)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, mood);
				return true;
			}
			return false;
		}

		public bool MutateLastuserestauranttime(long lastuserestauranttime)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastuserestauranttime);
				return true;
			}
			return false;
		}

		public static Offset<SeasonalWorkerData> CreateSeasonalWorkerData(FlatBufferBuilder builder, int workeridx = 0, int assignedbuildingidx = 0, int assignedbuildingtransformidx = 0, int mood = 0, long lastuserestauranttime = 0L)
		{
			builder.StartTable(5);
			AddLastuserestauranttime(builder, lastuserestauranttime);
			AddMood(builder, mood);
			AddAssignedbuildingtransformidx(builder, assignedbuildingtransformidx);
			AddAssignedbuildingidx(builder, assignedbuildingidx);
			AddWorkeridx(builder, workeridx);
			return EndSeasonalWorkerData(builder);
		}

		public static void StartSeasonalWorkerData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddWorkeridx(FlatBufferBuilder builder, int workeridx)
		{
			builder.AddInt(0, workeridx, 0);
		}

		public static void AddAssignedbuildingidx(FlatBufferBuilder builder, int assignedbuildingidx)
		{
			builder.AddInt(1, assignedbuildingidx, 0);
		}

		public static void AddAssignedbuildingtransformidx(FlatBufferBuilder builder, int assignedbuildingtransformidx)
		{
			builder.AddInt(2, assignedbuildingtransformidx, 0);
		}

		public static void AddMood(FlatBufferBuilder builder, int mood)
		{
			builder.AddInt(3, mood, 0);
		}

		public static void AddLastuserestauranttime(FlatBufferBuilder builder, long lastuserestauranttime)
		{
			builder.AddLong(4, lastuserestauranttime, 0);
		}

		public static Offset<SeasonalWorkerData> EndSeasonalWorkerData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalWorkerData>(o);
		}

		public SeasonalWorkerDataT UnPack()
		{
			var _o = new SeasonalWorkerDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalWorkerDataT _o)
		{
			_o.Workeridx = this.Workeridx;
			_o.Assignedbuildingidx = this.Assignedbuildingidx;
			_o.Assignedbuildingtransformidx = this.Assignedbuildingtransformidx;
			_o.Mood = this.Mood;
			_o.Lastuserestauranttime = this.Lastuserestauranttime;
		}

		public static Offset<SeasonalWorkerData> Pack(FlatBufferBuilder builder, SeasonalWorkerDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalWorkerData>);
			StartSeasonalWorkerData(builder);
			AddWorkeridx(builder, _o.Workeridx);
			AddAssignedbuildingidx(builder, _o.Assignedbuildingidx);
			AddAssignedbuildingtransformidx(builder, _o.Assignedbuildingtransformidx);
			AddMood(builder, _o.Mood);
			AddLastuserestauranttime(builder, _o.Lastuserestauranttime);
			return EndSeasonalWorkerData(builder);
		}
	}
}
