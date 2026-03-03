using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RecordCount : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public string Idx => null;

		public int Count => 0;

		public static void ValidateVersion()
		{
		}

		public static RecordCount GetRootAsRecordCount(ByteBuffer _bb)
		{
			return default(RecordCount);
		}

		public static RecordCount GetRootAsRecordCount(ByteBuffer _bb, RecordCount obj)
		{
			return default(RecordCount);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public RecordCount __assign(int _i, ByteBuffer _bb)
		{
			return default(RecordCount);
		}

		public ArraySegment<byte>? GetIdxBytes()
		{
			return null;
		}

		public byte[] GetIdxArray()
		{
			return null;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public static Offset<RecordCount> CreateRecordCount(FlatBufferBuilder builder, StringOffset idxOffset = default(StringOffset), int count = 0)
		{
			return default(Offset<RecordCount>);
		}

		public static void StartRecordCount(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, StringOffset idxOffset)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static Offset<RecordCount> EndRecordCount(FlatBufferBuilder builder)
		{
			return default(Offset<RecordCount>);
		}

		public RecordCountT UnPack()
		{
			return null;
		}

		public void UnPackTo(RecordCountT _o)
		{
		}

		public static Offset<RecordCount> Pack(FlatBufferBuilder builder, RecordCountT _o)
		{
			return default(Offset<RecordCount>);
		}
	}
}
