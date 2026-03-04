using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ManagerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Count { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Reinforcelevel { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Skilllevel { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Reinforceresetlasttime { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static ManagerData GetRootAsManagerData(ByteBuffer _bb)
		{
			return GetRootAsManagerData(_bb, new ManagerData());
		}

		public static ManagerData GetRootAsManagerData(ByteBuffer _bb, ManagerData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public ManagerData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateCount(int count)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, count);
				return true;
			}
			return false;
		}

		public bool MutateReinforcelevel(int reinforcelevel)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, reinforcelevel);
				return true;
			}
			return false;
		}

		public bool MutateSkilllevel(int skilllevel)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, skilllevel);
				return true;
			}
			return false;
		}

		public bool MutateReinforceresetlasttime(long reinforceresetlasttime)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, reinforceresetlasttime);
				return true;
			}
			return false;
		}

		public static Offset<ManagerData> CreateManagerData(FlatBufferBuilder builder, int idx = 0, int level = 0, int count = 0, int reinforcelevel = 0, int skilllevel = 0, long reinforceresetlasttime = 0L)
		{
			builder.StartTable(6);
			AddReinforceresetlasttime(builder, reinforceresetlasttime);
			AddSkilllevel(builder, skilllevel);
			AddReinforcelevel(builder, reinforcelevel);
			AddCount(builder, count);
			AddLevel(builder, level);
			AddIdx(builder, idx);
			return EndManagerData(builder);
		}

		public static void StartManagerData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		public static void AddReinforcelevel(FlatBufferBuilder builder, int reinforcelevel)
		{
			builder.AddInt(3, reinforcelevel, 0);
		}

		public static void AddSkilllevel(FlatBufferBuilder builder, int skilllevel)
		{
			builder.AddInt(4, skilllevel, 0);
		}

		public static void AddReinforceresetlasttime(FlatBufferBuilder builder, long reinforceresetlasttime)
		{
			builder.AddLong(5, reinforceresetlasttime, 0);
		}

		public static Offset<ManagerData> EndManagerData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<ManagerData>(o);
		}

		public ManagerDataT UnPack()
		{
			var _o = new ManagerDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(ManagerDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Level = this.Level;
			_o.Count = this.Count;
			_o.Reinforcelevel = this.Reinforcelevel;
			_o.Skilllevel = this.Skilllevel;
			_o.Reinforceresetlasttime = this.Reinforceresetlasttime;
		}

		public static Offset<ManagerData> Pack(FlatBufferBuilder builder, ManagerDataT _o)
		{
			if (_o == null) return default(Offset<ManagerData>);
			StartManagerData(builder);
			AddIdx(builder, _o.Idx);
			AddLevel(builder, _o.Level);
			AddCount(builder, _o.Count);
			AddReinforcelevel(builder, _o.Reinforcelevel);
			AddSkilllevel(builder, _o.Skilllevel);
			AddReinforceresetlasttime(builder, _o.Reinforceresetlasttime);
			return EndManagerData(builder);
		}
	}
}
