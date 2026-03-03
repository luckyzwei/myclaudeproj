using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct PackageOfferData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Offertype => 0;

		public long Offertime => 0L;

		public static void ValidateVersion()
		{
		}

		public static PackageOfferData GetRootAsPackageOfferData(ByteBuffer _bb)
		{
			return default(PackageOfferData);
		}

		public static PackageOfferData GetRootAsPackageOfferData(ByteBuffer _bb, PackageOfferData obj)
		{
			return default(PackageOfferData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public PackageOfferData __assign(int _i, ByteBuffer _bb)
		{
			return default(PackageOfferData);
		}

		public bool MutateOffertype(int offertype)
		{
			return false;
		}

		public bool MutateOffertime(long offertime)
		{
			return false;
		}

		public static Offset<PackageOfferData> CreatePackageOfferData(FlatBufferBuilder builder, int offertype = 0, long offertime = 0L)
		{
			return default(Offset<PackageOfferData>);
		}

		public static void StartPackageOfferData(FlatBufferBuilder builder)
		{
		}

		public static void AddOffertype(FlatBufferBuilder builder, int offertype)
		{
		}

		public static void AddOffertime(FlatBufferBuilder builder, long offertime)
		{
		}

		public static Offset<PackageOfferData> EndPackageOfferData(FlatBufferBuilder builder)
		{
			return default(Offset<PackageOfferData>);
		}

		public PackageOfferDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(PackageOfferDataT _o)
		{
		}

		public static Offset<PackageOfferData> Pack(FlatBufferBuilder builder, PackageOfferDataT _o)
		{
			return default(Offset<PackageOfferData>);
		}
	}
}
