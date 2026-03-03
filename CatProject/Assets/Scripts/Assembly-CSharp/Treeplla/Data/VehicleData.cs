using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct VehicleData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Index => 0;

		public int Level => 0;

		public int RowdataLength => 0;

		public static void ValidateVersion()
		{
		}

		public static VehicleData GetRootAsVehicleData(ByteBuffer _bb)
		{
			return default(VehicleData);
		}

		public static VehicleData GetRootAsVehicleData(ByteBuffer _bb, VehicleData obj)
		{
			return default(VehicleData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public VehicleData __assign(int _i, ByteBuffer _bb)
		{
			return default(VehicleData);
		}

		public bool MutateIndex(int index)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public StorageRowData? Rowdata(int j)
		{
			return null;
		}

		public static Offset<VehicleData> CreateVehicleData(FlatBufferBuilder builder, int index = 0, int level = 0, VectorOffset rowdataOffset = default(VectorOffset))
		{
			return default(Offset<VehicleData>);
		}

		public static void StartVehicleData(FlatBufferBuilder builder)
		{
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
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

		public static Offset<VehicleData> EndVehicleData(FlatBufferBuilder builder)
		{
			return default(Offset<VehicleData>);
		}

		public VehicleDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(VehicleDataT _o)
		{
		}

		public static Offset<VehicleData> Pack(FlatBufferBuilder builder, VehicleDataT _o)
		{
			return default(Offset<VehicleData>);
		}
	}
}
