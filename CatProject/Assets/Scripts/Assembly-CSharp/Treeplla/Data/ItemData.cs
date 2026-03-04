using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ItemData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Count { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static ItemData GetRootAsItemData(ByteBuffer _bb)
		{
			return GetRootAsItemData(_bb, new ItemData());
		}

		public static ItemData GetRootAsItemData(ByteBuffer _bb, ItemData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public ItemData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateCount(int count)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, count);
				return true;
			}
			return false;
		}

		public static Offset<ItemData> CreateItemData(FlatBufferBuilder builder, int idx = 0, int count = 0)
		{
			builder.StartTable(2);
			AddCount(builder, count);
			AddIdx(builder, idx);
			return EndItemData(builder);
		}

		public static void StartItemData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		public static Offset<ItemData> EndItemData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<ItemData>(o);
		}

		public ItemDataT UnPack()
		{
			var _o = new ItemDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(ItemDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Count = this.Count;
		}

		public static Offset<ItemData> Pack(FlatBufferBuilder builder, ItemDataT _o)
		{
			if (_o == null) return default(Offset<ItemData>);
			StartItemData(builder);
			AddIdx(builder, _o.Idx);
			AddCount(builder, _o.Count);
			return EndItemData(builder);
		}
	}
}
