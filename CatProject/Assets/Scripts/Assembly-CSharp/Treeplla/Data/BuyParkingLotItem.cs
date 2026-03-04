using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BuyParkingLotItem : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Parkinglotspaceidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Isbuy { get { int o = __p.__offset(6); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BuyParkingLotItem GetRootAsBuyParkingLotItem(ByteBuffer _bb)
		{
			return GetRootAsBuyParkingLotItem(_bb, new BuyParkingLotItem());
		}

		public static BuyParkingLotItem GetRootAsBuyParkingLotItem(ByteBuffer _bb, BuyParkingLotItem obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BuyParkingLotItem __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateParkinglotspaceidx(int parkinglotspaceidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, parkinglotspaceidx);
				return true;
			}
			return false;
		}

		public bool MutateIsbuy(bool isbuy)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isbuy ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<BuyParkingLotItem> CreateBuyParkingLotItem(FlatBufferBuilder builder, int parkinglotspaceidx = 0, bool isbuy = false)
		{
			builder.StartTable(2);
			AddIsbuy(builder, isbuy);
			AddParkinglotspaceidx(builder, parkinglotspaceidx);
			return EndBuyParkingLotItem(builder);
		}

		public static void StartBuyParkingLotItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddParkinglotspaceidx(FlatBufferBuilder builder, int parkinglotspaceidx)
		{
			builder.AddInt(0, parkinglotspaceidx, 0);
		}

		public static void AddIsbuy(FlatBufferBuilder builder, bool isbuy)
		{
			builder.AddBool(1, isbuy, false);
		}

		public static Offset<BuyParkingLotItem> EndBuyParkingLotItem(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BuyParkingLotItem>(o);
		}

		public BuyParkingLotItemT UnPack()
		{
			var _o = new BuyParkingLotItemT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BuyParkingLotItemT _o)
		{
			_o.Parkinglotspaceidx = this.Parkinglotspaceidx;
			_o.Isbuy = this.Isbuy;
		}

		public static Offset<BuyParkingLotItem> Pack(FlatBufferBuilder builder, BuyParkingLotItemT _o)
		{
			if (_o == null) return default(Offset<BuyParkingLotItem>);
			StartBuyParkingLotItem(builder);
			AddParkinglotspaceidx(builder, _o.Parkinglotspaceidx);
			AddIsbuy(builder, _o.Isbuy);
			return EndBuyParkingLotItem(builder);
		}
	}
}
