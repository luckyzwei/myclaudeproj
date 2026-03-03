using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RecordValue : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public string Idx => null;

		public long Value => 0L;

		public static void ValidateVersion()
		{
		}

		public static RecordValue GetRootAsRecordValue(ByteBuffer _bb)
		{
			return default(RecordValue);
		}

		public static RecordValue GetRootAsRecordValue(ByteBuffer _bb, RecordValue obj)
		{
			return default(RecordValue);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public RecordValue __assign(int _i, ByteBuffer _bb)
		{
			return default(RecordValue);
		}

		public ArraySegment<byte>? GetIdxBytes()
		{
			return null;
		}

		public byte[] GetIdxArray()
		{
			return null;
		}

		public bool MutateValue(long value)
		{
			return false;
		}

		public static Offset<RecordValue> CreateRecordValue(FlatBufferBuilder builder, StringOffset idxOffset = default(StringOffset), long value = 0L)
		{
			return default(Offset<RecordValue>);
		}

		public static void StartRecordValue(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, StringOffset idxOffset)
		{
		}

		public static void AddValue(FlatBufferBuilder builder, long value)
		{
		}

		public static Offset<RecordValue> EndRecordValue(FlatBufferBuilder builder)
		{
			return default(Offset<RecordValue>);
		}

		public RecordValueT UnPack()
		{
			return null;
		}

		public void UnPackTo(RecordValueT _o)
		{
		}

		public static Offset<RecordValue> Pack(FlatBufferBuilder builder, RecordValueT _o)
		{
			return default(Offset<RecordValue>);
		}
	}
}
