using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SellerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Itemidx => 0;

		public int Grade => 0;

		public int Offorder => 0;

		public bool Soldout => false;

		public static void ValidateVersion()
		{
		}

		public static SellerData GetRootAsSellerData(ByteBuffer _bb)
		{
			return default(SellerData);
		}

		public static SellerData GetRootAsSellerData(ByteBuffer _bb, SellerData obj)
		{
			return default(SellerData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SellerData __assign(int _i, ByteBuffer _bb)
		{
			return default(SellerData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateItemidx(int itemidx)
		{
			return false;
		}

		public bool MutateGrade(int grade)
		{
			return false;
		}

		public bool MutateOfforder(int offorder)
		{
			return false;
		}

		public bool MutateSoldout(bool soldout)
		{
			return false;
		}

		public static Offset<SellerData> CreateSellerData(FlatBufferBuilder builder, int idx = 0, int itemidx = 0, int grade = 0, int offorder = 0, bool soldout = false)
		{
			return default(Offset<SellerData>);
		}

		public static void StartSellerData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddItemidx(FlatBufferBuilder builder, int itemidx)
		{
		}

		public static void AddGrade(FlatBufferBuilder builder, int grade)
		{
		}

		public static void AddOfforder(FlatBufferBuilder builder, int offorder)
		{
		}

		public static void AddSoldout(FlatBufferBuilder builder, bool soldout)
		{
		}

		public static Offset<SellerData> EndSellerData(FlatBufferBuilder builder)
		{
			return default(Offset<SellerData>);
		}

		public SellerDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SellerDataT _o)
		{
		}

		public static Offset<SellerData> Pack(FlatBufferBuilder builder, SellerDataT _o)
		{
			return default(Offset<SellerData>);
		}
	}
}
