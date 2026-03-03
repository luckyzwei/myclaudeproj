using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OfficeItemData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Type => 0;

		public int Level => 0;

		public static void ValidateVersion()
		{
		}

		public static OfficeItemData GetRootAsOfficeItemData(ByteBuffer _bb)
		{
			return default(OfficeItemData);
		}

		public static OfficeItemData GetRootAsOfficeItemData(ByteBuffer _bb, OfficeItemData obj)
		{
			return default(OfficeItemData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public OfficeItemData __assign(int _i, ByteBuffer _bb)
		{
			return default(OfficeItemData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateType(int type)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public static Offset<OfficeItemData> CreateOfficeItemData(FlatBufferBuilder builder, int idx = 0, int type = 0, int level = 0)
		{
			return default(Offset<OfficeItemData>);
		}

		public static void StartOfficeItemData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddType(FlatBufferBuilder builder, int type)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static Offset<OfficeItemData> EndOfficeItemData(FlatBufferBuilder builder)
		{
			return default(Offset<OfficeItemData>);
		}

		public OfficeItemDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(OfficeItemDataT _o)
		{
		}

		public static Offset<OfficeItemData> Pack(FlatBufferBuilder builder, OfficeItemDataT _o)
		{
			return default(Offset<OfficeItemData>);
		}
	}
}
