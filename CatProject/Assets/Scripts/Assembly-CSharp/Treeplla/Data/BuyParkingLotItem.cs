using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BuyParkingLotItem : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Parkinglotspaceidx => 0;

		public bool Isbuy => false;

		public static void ValidateVersion()
		{
		}

		public static BuyParkingLotItem GetRootAsBuyParkingLotItem(ByteBuffer _bb)
		{
			return default(BuyParkingLotItem);
		}

		public static BuyParkingLotItem GetRootAsBuyParkingLotItem(ByteBuffer _bb, BuyParkingLotItem obj)
		{
			return default(BuyParkingLotItem);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BuyParkingLotItem __assign(int _i, ByteBuffer _bb)
		{
			return default(BuyParkingLotItem);
		}

		public bool MutateParkinglotspaceidx(int parkinglotspaceidx)
		{
			return false;
		}

		public bool MutateIsbuy(bool isbuy)
		{
			return false;
		}

		public static Offset<BuyParkingLotItem> CreateBuyParkingLotItem(FlatBufferBuilder builder, int parkinglotspaceidx = 0, bool isbuy = false)
		{
			return default(Offset<BuyParkingLotItem>);
		}

		public static void StartBuyParkingLotItem(FlatBufferBuilder builder)
		{
		}

		public static void AddParkinglotspaceidx(FlatBufferBuilder builder, int parkinglotspaceidx)
		{
		}

		public static void AddIsbuy(FlatBufferBuilder builder, bool isbuy)
		{
		}

		public static Offset<BuyParkingLotItem> EndBuyParkingLotItem(FlatBufferBuilder builder)
		{
			return default(Offset<BuyParkingLotItem>);
		}

		public BuyParkingLotItemT UnPack()
		{
			return null;
		}

		public void UnPackTo(BuyParkingLotItemT _o)
		{
		}

		public static Offset<BuyParkingLotItem> Pack(FlatBufferBuilder builder, BuyParkingLotItemT _o)
		{
			return default(Offset<BuyParkingLotItem>);
		}
	}
}
