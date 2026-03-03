using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ItemData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Count => 0;

		public static void ValidateVersion()
		{
		}

		public static ItemData GetRootAsItemData(ByteBuffer _bb)
		{
			return default(ItemData);
		}

		public static ItemData GetRootAsItemData(ByteBuffer _bb, ItemData obj)
		{
			return default(ItemData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public ItemData __assign(int _i, ByteBuffer _bb)
		{
			return default(ItemData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public static Offset<ItemData> CreateItemData(FlatBufferBuilder builder, int idx = 0, int count = 0)
		{
			return default(Offset<ItemData>);
		}

		public static void StartItemData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static Offset<ItemData> EndItemData(FlatBufferBuilder builder)
		{
			return default(Offset<ItemData>);
		}

		public ItemDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(ItemDataT _o)
		{
		}

		public static Offset<ItemData> Pack(FlatBufferBuilder builder, ItemDataT _o)
		{
			return default(Offset<ItemData>);
		}
	}
}
