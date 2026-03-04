using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OfficeItemData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Type { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static OfficeItemData GetRootAsOfficeItemData(ByteBuffer _bb)
		{
			return GetRootAsOfficeItemData(_bb, new OfficeItemData());
		}

		public static OfficeItemData GetRootAsOfficeItemData(ByteBuffer _bb, OfficeItemData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public OfficeItemData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateType(int type)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, type);
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

		public static Offset<OfficeItemData> CreateOfficeItemData(FlatBufferBuilder builder, int idx = 0, int type = 0, int level = 0)
		{
			builder.StartTable(3);
			AddLevel(builder, level);
			AddType(builder, type);
			AddIdx(builder, idx);
			return EndOfficeItemData(builder);
		}

		public static void StartOfficeItemData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddType(FlatBufferBuilder builder, int type)
		{
			builder.AddInt(1, type, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(2, level, 0);
		}

		public static Offset<OfficeItemData> EndOfficeItemData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<OfficeItemData>(o);
		}

		public OfficeItemDataT UnPack()
		{
			var _o = new OfficeItemDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(OfficeItemDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Type = this.Type;
			_o.Level = this.Level;
		}

		public static Offset<OfficeItemData> Pack(FlatBufferBuilder builder, OfficeItemDataT _o)
		{
			if (_o == null) return default(Offset<OfficeItemData>);
			StartOfficeItemData(builder);
			AddIdx(builder, _o.Idx);
			AddType(builder, _o.Type);
			AddLevel(builder, _o.Level);
			return EndOfficeItemData(builder);
		}
	}
}
