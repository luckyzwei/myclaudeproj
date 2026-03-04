using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct DigTreasureHuntCellData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Itemindex { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Isopened { get { int o = __p.__offset(6); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static DigTreasureHuntCellData GetRootAsDigTreasureHuntCellData(ByteBuffer _bb)
		{
			return GetRootAsDigTreasureHuntCellData(_bb, new DigTreasureHuntCellData());
		}

		public static DigTreasureHuntCellData GetRootAsDigTreasureHuntCellData(ByteBuffer _bb, DigTreasureHuntCellData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public DigTreasureHuntCellData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateItemindex(int itemindex)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, itemindex);
				return true;
			}
			return false;
		}

		public bool MutateIsopened(bool isopened)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isopened ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<DigTreasureHuntCellData> CreateDigTreasureHuntCellData(FlatBufferBuilder builder, int itemindex = 0, bool isopened = false)
		{
			builder.StartTable(2);
			AddIsopened(builder, isopened);
			AddItemindex(builder, itemindex);
			return EndDigTreasureHuntCellData(builder);
		}

		public static void StartDigTreasureHuntCellData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddItemindex(FlatBufferBuilder builder, int itemindex)
		{
			builder.AddInt(0, itemindex, 0);
		}

		public static void AddIsopened(FlatBufferBuilder builder, bool isopened)
		{
			builder.AddBool(1, isopened, false);
		}

		public static Offset<DigTreasureHuntCellData> EndDigTreasureHuntCellData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<DigTreasureHuntCellData>(o);
		}

		public DigTreasureHuntCellDataT UnPack()
		{
			var _o = new DigTreasureHuntCellDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(DigTreasureHuntCellDataT _o)
		{
			_o.Itemindex = this.Itemindex;
			_o.Isopened = this.Isopened;
		}

		public static Offset<DigTreasureHuntCellData> Pack(FlatBufferBuilder builder, DigTreasureHuntCellDataT _o)
		{
			if (_o == null) return default(Offset<DigTreasureHuntCellData>);
			StartDigTreasureHuntCellData(builder);
			AddItemindex(builder, _o.Itemindex);
			AddIsopened(builder, _o.Isopened);
			return EndDigTreasureHuntCellData(builder);
		}
	}
}
