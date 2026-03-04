using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SuperStaffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SuperStaffData GetRootAsSuperStaffData(ByteBuffer _bb)
		{
			return GetRootAsSuperStaffData(_bb, new SuperStaffData());
		}

		public static SuperStaffData GetRootAsSuperStaffData(ByteBuffer _bb, SuperStaffData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SuperStaffData __assign(int _i, ByteBuffer _bb)
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

		public static Offset<SuperStaffData> CreateSuperStaffData(FlatBufferBuilder builder, int idx = 0, int level = 0)
		{
			builder.StartTable(2);
			AddLevel(builder, level);
			AddIdx(builder, idx);
			return EndSuperStaffData(builder);
		}

		public static void StartSuperStaffData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static Offset<SuperStaffData> EndSuperStaffData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SuperStaffData>(o);
		}

		public SuperStaffDataT UnPack()
		{
			var _o = new SuperStaffDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SuperStaffDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Level = this.Level;
		}

		public static Offset<SuperStaffData> Pack(FlatBufferBuilder builder, SuperStaffDataT _o)
		{
			if (_o == null) return default(Offset<SuperStaffData>);
			StartSuperStaffData(builder);
			AddIdx(builder, _o.Idx);
			AddLevel(builder, _o.Level);
			return EndSuperStaffData(builder);
		}
	}
}
