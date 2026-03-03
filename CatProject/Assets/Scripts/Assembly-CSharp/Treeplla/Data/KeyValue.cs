using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct KeyValue : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public float Value => 0f;

		public static void ValidateVersion()
		{
		}

		public static KeyValue GetRootAsKeyValue(ByteBuffer _bb)
		{
			return default(KeyValue);
		}

		public static KeyValue GetRootAsKeyValue(ByteBuffer _bb, KeyValue obj)
		{
			return default(KeyValue);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public KeyValue __assign(int _i, ByteBuffer _bb)
		{
			return default(KeyValue);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateValue(float value)
		{
			return false;
		}

		public static Offset<KeyValue> CreateKeyValue(FlatBufferBuilder builder, int idx = 0, float value = 0f)
		{
			return default(Offset<KeyValue>);
		}

		public static void StartKeyValue(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddValue(FlatBufferBuilder builder, float value)
		{
		}

		public static Offset<KeyValue> EndKeyValue(FlatBufferBuilder builder)
		{
			return default(Offset<KeyValue>);
		}

		public KeyValueT UnPack()
		{
			return null;
		}

		public void UnPackTo(KeyValueT _o)
		{
		}

		public static Offset<KeyValue> Pack(FlatBufferBuilder builder, KeyValueT _o)
		{
			return default(Offset<KeyValue>);
		}
	}
}
