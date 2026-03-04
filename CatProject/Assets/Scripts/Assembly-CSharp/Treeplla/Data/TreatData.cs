using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct TreatData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Adusetime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Buffendtime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Count { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static TreatData GetRootAsTreatData(ByteBuffer _bb)
		{
			return GetRootAsTreatData(_bb, new TreatData());
		}

		public static TreatData GetRootAsTreatData(ByteBuffer _bb, TreatData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public TreatData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateAdusetime(long adusetime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, adusetime);
				return true;
			}
			return false;
		}

		public bool MutateBuffendtime(long buffendtime)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, buffendtime);
				return true;
			}
			return false;
		}

		public bool MutateCount(int count)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, count);
				return true;
			}
			return false;
		}

		public static Offset<TreatData> CreateTreatData(FlatBufferBuilder builder, int idx = 0, long adusetime = 0L, long buffendtime = 0L, int count = 0)
		{
			builder.StartTable(4);
			AddCount(builder, count);
			AddBuffendtime(builder, buffendtime);
			AddAdusetime(builder, adusetime);
			AddIdx(builder, idx);
			return EndTreatData(builder);
		}

		public static void StartTreatData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddAdusetime(FlatBufferBuilder builder, long adusetime)
		{
			builder.AddLong(1, adusetime, 0);
		}

		public static void AddBuffendtime(FlatBufferBuilder builder, long buffendtime)
		{
			builder.AddLong(2, buffendtime, 0);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(3, count, 0);
		}

		public static Offset<TreatData> EndTreatData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<TreatData>(o);
		}

		public TreatDataT UnPack()
		{
			var _o = new TreatDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(TreatDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Adusetime = this.Adusetime;
			_o.Buffendtime = this.Buffendtime;
			_o.Count = this.Count;
		}

		public static Offset<TreatData> Pack(FlatBufferBuilder builder, TreatDataT _o)
		{
			if (_o == null) return default(Offset<TreatData>);
			StartTreatData(builder);
			AddIdx(builder, _o.Idx);
			AddAdusetime(builder, _o.Adusetime);
			AddBuffendtime(builder, _o.Buffendtime);
			AddCount(builder, _o.Count);
			return EndTreatData(builder);
		}
	}
}
