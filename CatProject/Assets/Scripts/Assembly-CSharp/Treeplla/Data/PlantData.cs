using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct PlantData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public float Exp => 0f;

		public int Level => 0;

		public int FullsLength => 0;

		public int Count => 0;

		public long Abilitytime => 0L;

		public bool Isnew => false;

		public static void ValidateVersion()
		{
		}

		public static PlantData GetRootAsPlantData(ByteBuffer _bb)
		{
			return default(PlantData);
		}

		public static PlantData GetRootAsPlantData(ByteBuffer _bb, PlantData obj)
		{
			return default(PlantData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public PlantData __assign(int _i, ByteBuffer _bb)
		{
			return default(PlantData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateExp(float exp)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public KeyValue? Fulls(int j)
		{
			return null;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public bool MutateAbilitytime(long abilitytime)
		{
			return false;
		}

		public bool MutateIsnew(bool isnew)
		{
			return false;
		}

		public static Offset<PlantData> CreatePlantData(FlatBufferBuilder builder, int idx = 0, float exp = 0f, int level = 0, VectorOffset fullsOffset = default(VectorOffset), int count = 0, long abilitytime = 0L, bool isnew = false)
		{
			return default(Offset<PlantData>);
		}

		public static void StartPlantData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddExp(FlatBufferBuilder builder, float exp)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddFulls(FlatBufferBuilder builder, VectorOffset fullsOffset)
		{
		}

		public static VectorOffset CreateFullsVector(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFullsVectorBlock(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFullsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValue>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFullsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartFullsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static void AddAbilitytime(FlatBufferBuilder builder, long abilitytime)
		{
		}

		public static void AddIsnew(FlatBufferBuilder builder, bool isnew)
		{
		}

		public static Offset<PlantData> EndPlantData(FlatBufferBuilder builder)
		{
			return default(Offset<PlantData>);
		}

		public PlantDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(PlantDataT _o)
		{
		}

		public static Offset<PlantData> Pack(FlatBufferBuilder builder, PlantDataT _o)
		{
			return default(Offset<PlantData>);
		}
	}
}
