using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FactoryItem : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Count => 0;

		public static void ValidateVersion()
		{
		}

		public static FactoryItem GetRootAsFactoryItem(ByteBuffer _bb)
		{
			return default(FactoryItem);
		}

		public static FactoryItem GetRootAsFactoryItem(ByteBuffer _bb, FactoryItem obj)
		{
			return default(FactoryItem);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public FactoryItem __assign(int _i, ByteBuffer _bb)
		{
			return default(FactoryItem);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public static Offset<FactoryItem> CreateFactoryItem(FlatBufferBuilder builder, int idx = 0, int count = 0)
		{
			return default(Offset<FactoryItem>);
		}

		public static void StartFactoryItem(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static Offset<FactoryItem> EndFactoryItem(FlatBufferBuilder builder)
		{
			return default(Offset<FactoryItem>);
		}

		public FactoryItemT UnPack()
		{
			return null;
		}

		public void UnPackTo(FactoryItemT _o)
		{
		}

		public static Offset<FactoryItem> Pack(FlatBufferBuilder builder, FactoryItemT _o)
		{
			return default(Offset<FactoryItem>);
		}
	}
}
