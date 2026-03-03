using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct StorageRowData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Row => 0;

		public int TreedataLength => 0;

		public static void ValidateVersion()
		{
		}

		public static StorageRowData GetRootAsStorageRowData(ByteBuffer _bb)
		{
			return default(StorageRowData);
		}

		public static StorageRowData GetRootAsStorageRowData(ByteBuffer _bb, StorageRowData obj)
		{
			return default(StorageRowData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public StorageRowData __assign(int _i, ByteBuffer _bb)
		{
			return default(StorageRowData);
		}

		public bool MutateRow(int row)
		{
			return false;
		}

		public TreeData? Treedata(int j)
		{
			return null;
		}

		public static Offset<StorageRowData> CreateStorageRowData(FlatBufferBuilder builder, int row = 0, VectorOffset treedataOffset = default(VectorOffset))
		{
			return default(Offset<StorageRowData>);
		}

		public static void StartStorageRowData(FlatBufferBuilder builder)
		{
		}

		public static void AddRow(FlatBufferBuilder builder, int row)
		{
		}

		public static void AddTreedata(FlatBufferBuilder builder, VectorOffset treedataOffset)
		{
		}

		public static VectorOffset CreateTreedataVector(FlatBufferBuilder builder, Offset<TreeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTreedataVectorBlock(FlatBufferBuilder builder, Offset<TreeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTreedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<TreeData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTreedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartTreedataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<StorageRowData> EndStorageRowData(FlatBufferBuilder builder)
		{
			return default(Offset<StorageRowData>);
		}

		public StorageRowDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(StorageRowDataT _o)
		{
		}

		public static Offset<StorageRowData> Pack(FlatBufferBuilder builder, StorageRowDataT _o)
		{
			return default(Offset<StorageRowData>);
		}
	}
}
