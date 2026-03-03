using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct PackageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public long Endtime => 0L;

		public int Buycount => 0;

		public static void ValidateVersion()
		{
		}

		public static PackageData GetRootAsPackageData(ByteBuffer _bb)
		{
			return default(PackageData);
		}

		public static PackageData GetRootAsPackageData(ByteBuffer _bb, PackageData obj)
		{
			return default(PackageData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public PackageData __assign(int _i, ByteBuffer _bb)
		{
			return default(PackageData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateEndtime(long endtime)
		{
			return false;
		}

		public bool MutateBuycount(int buycount)
		{
			return false;
		}

		public static Offset<PackageData> CreatePackageData(FlatBufferBuilder builder, int idx = 0, long endtime = 0L, int buycount = 0)
		{
			return default(Offset<PackageData>);
		}

		public static void StartPackageData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
		}

		public static void AddBuycount(FlatBufferBuilder builder, int buycount)
		{
		}

		public static Offset<PackageData> EndPackageData(FlatBufferBuilder builder)
		{
			return default(Offset<PackageData>);
		}

		public PackageDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(PackageDataT _o)
		{
		}

		public static Offset<PackageData> Pack(FlatBufferBuilder builder, PackageDataT _o)
		{
			return default(Offset<PackageData>);
		}
	}
}
