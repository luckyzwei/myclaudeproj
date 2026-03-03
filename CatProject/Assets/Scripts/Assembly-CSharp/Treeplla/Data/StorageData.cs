using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct StorageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Index => 0;

		public int RowdataLength => 0;

		public static void ValidateVersion()
		{
		}

		public static StorageData GetRootAsStorageData(ByteBuffer _bb)
		{
			return default(StorageData);
		}

		public static StorageData GetRootAsStorageData(ByteBuffer _bb, StorageData obj)
		{
			return default(StorageData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public StorageData __assign(int _i, ByteBuffer _bb)
		{
			return default(StorageData);
		}

		public bool MutateIndex(int index)
		{
			return false;
		}

		public StorageRowData? Rowdata(int j)
		{
			return null;
		}

		public static Offset<StorageData> CreateStorageData(FlatBufferBuilder builder, int index = 0, VectorOffset rowdataOffset = default(VectorOffset))
		{
			return default(Offset<StorageData>);
		}

		public static void StartStorageData(FlatBufferBuilder builder)
		{
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
		}

		public static void AddRowdata(FlatBufferBuilder builder, VectorOffset rowdataOffset)
		{
		}

		public static VectorOffset CreateRowdataVector(FlatBufferBuilder builder, Offset<StorageRowData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRowdataVectorBlock(FlatBufferBuilder builder, Offset<StorageRowData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRowdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<StorageRowData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateRowdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartRowdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<StorageData> EndStorageData(FlatBufferBuilder builder)
		{
			return default(Offset<StorageData>);
		}

		public StorageDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(StorageDataT _o)
		{
		}

		public static Offset<StorageData> Pack(FlatBufferBuilder builder, StorageDataT _o)
		{
			return default(Offset<StorageData>);
		}
	}
}
