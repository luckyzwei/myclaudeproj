using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SegmentData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Type => 0;

		public string Id => null;

		public static void ValidateVersion()
		{
		}

		public static SegmentData GetRootAsSegmentData(ByteBuffer _bb)
		{
			return default(SegmentData);
		}

		public static SegmentData GetRootAsSegmentData(ByteBuffer _bb, SegmentData obj)
		{
			return default(SegmentData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SegmentData __assign(int _i, ByteBuffer _bb)
		{
			return default(SegmentData);
		}

		public bool MutateType(int type)
		{
			return false;
		}

		public ArraySegment<byte>? GetIdBytes()
		{
			return null;
		}

		public byte[] GetIdArray()
		{
			return null;
		}

		public static Offset<SegmentData> CreateSegmentData(FlatBufferBuilder builder, int type = -1, StringOffset idOffset = default(StringOffset))
		{
			return default(Offset<SegmentData>);
		}

		public static void StartSegmentData(FlatBufferBuilder builder)
		{
		}

		public static void AddType(FlatBufferBuilder builder, int type)
		{
		}

		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
		}

		public static Offset<SegmentData> EndSegmentData(FlatBufferBuilder builder)
		{
			return default(Offset<SegmentData>);
		}

		public SegmentDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SegmentDataT _o)
		{
		}

		public static Offset<SegmentData> Pack(FlatBufferBuilder builder, SegmentDataT _o)
		{
			return default(Offset<SegmentData>);
		}
	}
}
