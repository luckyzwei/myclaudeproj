using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ChapterPassData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int ReceivestageLength => 0;

		public int ReceivebonuschapterLength => 0;

		public int ReceivestagenormalLength => 0;

		public static void ValidateVersion()
		{
		}

		public static ChapterPassData GetRootAsChapterPassData(ByteBuffer _bb)
		{
			return default(ChapterPassData);
		}

		public static ChapterPassData GetRootAsChapterPassData(ByteBuffer _bb, ChapterPassData obj)
		{
			return default(ChapterPassData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public ChapterPassData __assign(int _i, ByteBuffer _bb)
		{
			return default(ChapterPassData);
		}

		public int Receivestage(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetReceivestageBytes()
		{
			return null;
		}

		public int[] GetReceivestageArray()
		{
			return null;
		}

		public bool MutateReceivestage(int j, int receivestage)
		{
			return false;
		}

		public int Receivebonuschapter(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetReceivebonuschapterBytes()
		{
			return null;
		}

		public int[] GetReceivebonuschapterArray()
		{
			return null;
		}

		public bool MutateReceivebonuschapter(int j, int receivebonuschapter)
		{
			return false;
		}

		public int Receivestagenormal(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetReceivestagenormalBytes()
		{
			return null;
		}

		public int[] GetReceivestagenormalArray()
		{
			return null;
		}

		public bool MutateReceivestagenormal(int j, int receivestagenormal)
		{
			return false;
		}

		public static Offset<ChapterPassData> CreateChapterPassData(FlatBufferBuilder builder, VectorOffset receivestageOffset = default(VectorOffset), VectorOffset receivebonuschapterOffset = default(VectorOffset), VectorOffset receivestagenormalOffset = default(VectorOffset))
		{
			return default(Offset<ChapterPassData>);
		}

		public static void StartChapterPassData(FlatBufferBuilder builder)
		{
		}

		public static void AddReceivestage(FlatBufferBuilder builder, VectorOffset receivestageOffset)
		{
		}

		public static VectorOffset CreateReceivestageVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivestageVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivestageVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivestageVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartReceivestageVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddReceivebonuschapter(FlatBufferBuilder builder, VectorOffset receivebonuschapterOffset)
		{
		}

		public static VectorOffset CreateReceivebonuschapterVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivebonuschapterVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivebonuschapterVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivebonuschapterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartReceivebonuschapterVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddReceivestagenormal(FlatBufferBuilder builder, VectorOffset receivestagenormalOffset)
		{
		}

		public static VectorOffset CreateReceivestagenormalVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivestagenormalVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivestagenormalVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivestagenormalVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartReceivestagenormalVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<ChapterPassData> EndChapterPassData(FlatBufferBuilder builder)
		{
			return default(Offset<ChapterPassData>);
		}

		public ChapterPassDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(ChapterPassDataT _o)
		{
		}

		public static Offset<ChapterPassData> Pack(FlatBufferBuilder builder, ChapterPassDataT _o)
		{
			return default(Offset<ChapterPassData>);
		}
	}
}
