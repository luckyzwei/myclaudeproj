using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalShopData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Seasoninfoidx => 0;

		public bool Statueactive => false;

		public long Statuebuytime => 0L;

		public int Statueslotcount => 0;

		public int Piggyvalue => 0;

		public int PackagesLength => 0;

		public int ExpirepackageLength => 0;

		public bool Buildingslotactive => false;

		public int ViewpackageLength => 0;

		public bool Premiumpassactive => false;

		public static void ValidateVersion()
		{
		}

		public static SeasonalShopData GetRootAsSeasonalShopData(ByteBuffer _bb)
		{
			return default(SeasonalShopData);
		}

		public static SeasonalShopData GetRootAsSeasonalShopData(ByteBuffer _bb, SeasonalShopData obj)
		{
			return default(SeasonalShopData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalShopData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalShopData);
		}

		public bool MutateSeasoninfoidx(int seasoninfoidx)
		{
			return false;
		}

		public bool MutateStatueactive(bool statueactive)
		{
			return false;
		}

		public bool MutateStatuebuytime(long statuebuytime)
		{
			return false;
		}

		public bool MutateStatueslotcount(int statueslotcount)
		{
			return false;
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

		public bool MutateBuildingslotactive(bool buildingslotactive)
		{
			return false;
		}

		public int Viewpackage(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetViewpackageBytes()
		{
			return null;
		}

		public int[] GetViewpackageArray()
		{
			return null;
		}

		public bool MutateViewpackage(int j, int viewpackage)
		{
			return false;
		}

		public bool MutatePremiumpassactive(bool premiumpassactive)
		{
			return false;
		}

		public static Offset<SeasonalShopData> CreateSeasonalShopData(FlatBufferBuilder builder, int seasoninfoidx = 0, bool statueactive = false, long statuebuytime = 0L, int statueslotcount = 0, int piggyvalue = 0, VectorOffset packagesOffset = default(VectorOffset), VectorOffset expirepackageOffset = default(VectorOffset), bool buildingslotactive = false, VectorOffset viewpackageOffset = default(VectorOffset), bool premiumpassactive = false)
		{
			return default(Offset<SeasonalShopData>);
		}

		public static void StartSeasonalShopData(FlatBufferBuilder builder)
		{
		}

		public static void AddSeasoninfoidx(FlatBufferBuilder builder, int seasoninfoidx)
		{
		}

		public static void AddStatueactive(FlatBufferBuilder builder, bool statueactive)
		{
		}

		public static void AddStatuebuytime(FlatBufferBuilder builder, long statuebuytime)
		{
		}

		public static void AddStatueslotcount(FlatBufferBuilder builder, int statueslotcount)
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

		public static void AddBuildingslotactive(FlatBufferBuilder builder, bool buildingslotactive)
		{
		}

		public static void AddViewpackage(FlatBufferBuilder builder, VectorOffset viewpackageOffset)
		{
		}

		public static VectorOffset CreateViewpackageVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateViewpackageVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateViewpackageVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateViewpackageVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartViewpackageVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPremiumpassactive(FlatBufferBuilder builder, bool premiumpassactive)
		{
		}

		public static Offset<SeasonalShopData> EndSeasonalShopData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalShopData>);
		}

		public SeasonalShopDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalShopDataT _o)
		{
		}

		public static Offset<SeasonalShopData> Pack(FlatBufferBuilder builder, SeasonalShopDataT _o)
		{
			return default(Offset<SeasonalShopData>);
		}
	}
}
