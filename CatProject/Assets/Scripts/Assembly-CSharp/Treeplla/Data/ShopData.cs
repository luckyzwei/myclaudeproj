using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ShopData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int FreeitemtimesLength => 0;

		public int Piggyvalue => 0;

		public int PackagesLength => 0;

		public int ExpirepackageLength => 0;

		public int Piggylevel => 0;

		public int PiggyrewardLength => 0;

		public long Noadssaleend => 0L;

		public long Playerlvpasssaleend => 0L;

		public int ShopsalepackagetimesLength => 0;

		public int CyclelimitedshopgoodsLength => 0;

		public int EndlessofferdataLength => 0;

		public static void ValidateVersion()
		{
		}

		public static ShopData GetRootAsShopData(ByteBuffer _bb)
		{
			return default(ShopData);
		}

		public static ShopData GetRootAsShopData(ByteBuffer _bb, ShopData obj)
		{
			return default(ShopData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public ShopData __assign(int _i, ByteBuffer _bb)
		{
			return default(ShopData);
		}

		public KeyValueLong? Freeitemtimes(int j)
		{
			return null;
		}

		public bool MutatePiggyvalue(int piggyvalue)
		{
			return false;
		}

		public PackageData? Packages(int j)
		{
			return null;
		}

		public int Expirepackage(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetExpirepackageBytes()
		{
			return null;
		}

		public int[] GetExpirepackageArray()
		{
			return null;
		}

		public bool MutateExpirepackage(int j, int expirepackage)
		{
			return false;
		}

		public bool MutatePiggylevel(int piggylevel)
		{
			return false;
		}

		public int Piggyreward(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetPiggyrewardBytes()
		{
			return null;
		}

		public int[] GetPiggyrewardArray()
		{
			return null;
		}

		public bool MutatePiggyreward(int j, int piggyreward)
		{
			return false;
		}

		public bool MutateNoadssaleend(long noadssaleend)
		{
			return false;
		}

		public bool MutatePlayerlvpasssaleend(long playerlvpasssaleend)
		{
			return false;
		}

		public KeyValueLong? Shopsalepackagetimes(int j)
		{
			return null;
		}

		public CycleLimitedShopGoods? Cyclelimitedshopgoods(int j)
		{
			return null;
		}

		public EndlessOfferData? Endlessofferdata(int j)
		{
			return null;
		}

		public static Offset<ShopData> CreateShopData(FlatBufferBuilder builder, VectorOffset freeitemtimesOffset = default(VectorOffset), int piggyvalue = 0, VectorOffset packagesOffset = default(VectorOffset), VectorOffset expirepackageOffset = default(VectorOffset), int piggylevel = 1, VectorOffset piggyrewardOffset = default(VectorOffset), long noadssaleend = 0L, long playerlvpasssaleend = 0L, VectorOffset shopsalepackagetimesOffset = default(VectorOffset), VectorOffset cyclelimitedshopgoodsOffset = default(VectorOffset), VectorOffset endlessofferdataOffset = default(VectorOffset))
		{
			return default(Offset<ShopData>);
		}

		public static void StartShopData(FlatBufferBuilder builder)
		{
		}

		public static void AddFreeitemtimes(FlatBufferBuilder builder, VectorOffset freeitemtimesOffset)
		{
		}

		public static VectorOffset CreateFreeitemtimesVector(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFreeitemtimesVectorBlock(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFreeitemtimesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValueLong>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFreeitemtimesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartFreeitemtimesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPiggyvalue(FlatBufferBuilder builder, int piggyvalue)
		{
		}

		public static void AddPackages(FlatBufferBuilder builder, VectorOffset packagesOffset)
		{
		}

		public static VectorOffset CreatePackagesVector(FlatBufferBuilder builder, Offset<PackageData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePackagesVectorBlock(FlatBufferBuilder builder, Offset<PackageData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePackagesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<PackageData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePackagesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartPackagesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddExpirepackage(FlatBufferBuilder builder, VectorOffset expirepackageOffset)
		{
		}

		public static VectorOffset CreateExpirepackageVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateExpirepackageVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateExpirepackageVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateExpirepackageVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartExpirepackageVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPiggylevel(FlatBufferBuilder builder, int piggylevel)
		{
		}

		public static void AddPiggyreward(FlatBufferBuilder builder, VectorOffset piggyrewardOffset)
		{
		}

		public static VectorOffset CreatePiggyrewardVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePiggyrewardVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePiggyrewardVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePiggyrewardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartPiggyrewardVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddNoadssaleend(FlatBufferBuilder builder, long noadssaleend)
		{
		}

		public static void AddPlayerlvpasssaleend(FlatBufferBuilder builder, long playerlvpasssaleend)
		{
		}

		public static void AddShopsalepackagetimes(FlatBufferBuilder builder, VectorOffset shopsalepackagetimesOffset)
		{
		}

		public static VectorOffset CreateShopsalepackagetimesVector(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateShopsalepackagetimesVectorBlock(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateShopsalepackagetimesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValueLong>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateShopsalepackagetimesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartShopsalepackagetimesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddCyclelimitedshopgoods(FlatBufferBuilder builder, VectorOffset cyclelimitedshopgoodsOffset)
		{
		}

		public static VectorOffset CreateCyclelimitedshopgoodsVector(FlatBufferBuilder builder, Offset<CycleLimitedShopGoods>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCyclelimitedshopgoodsVectorBlock(FlatBufferBuilder builder, Offset<CycleLimitedShopGoods>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCyclelimitedshopgoodsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CycleLimitedShopGoods>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCyclelimitedshopgoodsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCyclelimitedshopgoodsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddEndlessofferdata(FlatBufferBuilder builder, VectorOffset endlessofferdataOffset)
		{
		}

		public static VectorOffset CreateEndlessofferdataVector(FlatBufferBuilder builder, Offset<EndlessOfferData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEndlessofferdataVectorBlock(FlatBufferBuilder builder, Offset<EndlessOfferData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEndlessofferdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<EndlessOfferData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEndlessofferdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartEndlessofferdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<ShopData> EndShopData(FlatBufferBuilder builder)
		{
			return default(Offset<ShopData>);
		}

		public ShopDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(ShopDataT _o)
		{
		}

		public static Offset<ShopData> Pack(FlatBufferBuilder builder, ShopDataT _o)
		{
			return default(Offset<ShopData>);
		}
	}
}
