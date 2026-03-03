using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct KeyValueLong : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Key => 0;

		public long Value => 0L;

		public static void ValidateVersion()
		{
		}

		public static KeyValueLong GetRootAsKeyValueLong(ByteBuffer _bb)
		{
			return default(KeyValueLong);
		}

		public static KeyValueLong GetRootAsKeyValueLong(ByteBuffer _bb, KeyValueLong obj)
		{
			return default(KeyValueLong);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public KeyValueLong __assign(int _i, ByteBuffer _bb)
		{
			return default(KeyValueLong);
		}

		public bool MutateKey(int key)
		{
			return false;
		}

		public bool MutateValue(long value)
		{
			return false;
		}

		public static Offset<KeyValueLong> CreateKeyValueLong(FlatBufferBuilder builder, int key = 0, long value = 0L)
		{
			return default(Offset<KeyValueLong>);
		}

		public static void StartKeyValueLong(FlatBufferBuilder builder)
		{
		}

		public static void AddKey(FlatBufferBuilder builder, int key)
		{
		}

		public static void AddValue(FlatBufferBuilder builder, long value)
		{
		}

		public static Offset<KeyValueLong> EndKeyValueLong(FlatBufferBuilder builder)
		{
			return default(Offset<KeyValueLong>);
		}

		public KeyValueLongT UnPack()
		{
			return null;
		}

		public void UnPackTo(KeyValueLongT _o)
		{
		}

		public static Offset<KeyValueLong> Pack(FlatBufferBuilder builder, KeyValueLongT _o)
		{
			return default(Offset<KeyValueLong>);
		}
	}
}
