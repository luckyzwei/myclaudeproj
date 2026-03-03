using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ManagerKeyAddData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public long Factoryresettime => 0L;

		public int Factoryorder => 0;

		public int FactoryrewardsLength => 0;

		public int Usegemcount => 0;

		public int CatstakeyrewardLength => 0;

		public int FactoryrewardcontentsopenLength => 0;

		public int Factoryrewardcontentsopen2Length => 0;

		public static void ValidateVersion()
		{
		}

		public static ManagerKeyAddData GetRootAsManagerKeyAddData(ByteBuffer _bb)
		{
			return default(ManagerKeyAddData);
		}

		public static ManagerKeyAddData GetRootAsManagerKeyAddData(ByteBuffer _bb, ManagerKeyAddData obj)
		{
			return default(ManagerKeyAddData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public ManagerKeyAddData __assign(int _i, ByteBuffer _bb)
		{
			return default(ManagerKeyAddData);
		}

		public bool MutateFactoryresettime(long factoryresettime)
		{
			return false;
		}

		public bool MutateFactoryorder(int factoryorder)
		{
			return false;
		}

		public int Factoryrewards(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetFactoryrewardsBytes()
		{
			return null;
		}

		public int[] GetFactoryrewardsArray()
		{
			return null;
		}

		public bool MutateFactoryrewards(int j, int factoryrewards)
		{
			return false;
		}

		public bool MutateUsegemcount(int usegemcount)
		{
			return false;
		}

		public int Catstakeyreward(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetCatstakeyrewardBytes()
		{
			return null;
		}

		public int[] GetCatstakeyrewardArray()
		{
			return null;
		}

		public bool MutateCatstakeyreward(int j, int catstakeyreward)
		{
			return false;
		}

		public bool Factoryrewardcontentsopen(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetFactoryrewardcontentsopenBytes()
		{
			return null;
		}

		public bool[] GetFactoryrewardcontentsopenArray()
		{
			return null;
		}

		public bool MutateFactoryrewardcontentsopen(int j, bool factoryrewardcontentsopen)
		{
			return false;
		}

		public bool Factoryrewardcontentsopen2(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetFactoryrewardcontentsopen2Bytes()
		{
			return null;
		}

		public bool[] GetFactoryrewardcontentsopen2Array()
		{
			return null;
		}

		public bool MutateFactoryrewardcontentsopen2(int j, bool factoryrewardcontentsopen2)
		{
			return false;
		}

		public static Offset<ManagerKeyAddData> CreateManagerKeyAddData(FlatBufferBuilder builder, long factoryresettime = 0L, int factoryorder = 0, VectorOffset factoryrewardsOffset = default(VectorOffset), int usegemcount = 0, VectorOffset catstakeyrewardOffset = default(VectorOffset), VectorOffset factoryrewardcontentsopenOffset = default(VectorOffset), VectorOffset factoryrewardcontentsopen2Offset = default(VectorOffset))
		{
			return default(Offset<ManagerKeyAddData>);
		}

		public static void StartManagerKeyAddData(FlatBufferBuilder builder)
		{
		}

		public static void AddFactoryresettime(FlatBufferBuilder builder, long factoryresettime)
		{
		}

		public static void AddFactoryorder(FlatBufferBuilder builder, int factoryorder)
		{
		}

		public static void AddFactoryrewards(FlatBufferBuilder builder, VectorOffset factoryrewardsOffset)
		{
		}

		public static VectorOffset CreateFactoryrewardsVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFactoryrewardsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFactoryrewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFactoryrewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartFactoryrewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddUsegemcount(FlatBufferBuilder builder, int usegemcount)
		{
		}

		public static void AddCatstakeyreward(FlatBufferBuilder builder, VectorOffset catstakeyrewardOffset)
		{
		}

		public static VectorOffset CreateCatstakeyrewardVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCatstakeyrewardVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCatstakeyrewardVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCatstakeyrewardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCatstakeyrewardVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddFactoryrewardcontentsopen(FlatBufferBuilder builder, VectorOffset factoryrewardcontentsopenOffset)
		{
		}

		public static VectorOffset CreateFactoryrewardcontentsopenVector(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFactoryrewardcontentsopenVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFactoryrewardcontentsopenVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFactoryrewardcontentsopenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartFactoryrewardcontentsopenVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddFactoryrewardcontentsopen2(FlatBufferBuilder builder, VectorOffset factoryrewardcontentsopen2Offset)
		{
		}

		public static VectorOffset CreateFactoryrewardcontentsopen2Vector(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFactoryrewardcontentsopen2VectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFactoryrewardcontentsopen2VectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateFactoryrewardcontentsopen2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartFactoryrewardcontentsopen2Vector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<ManagerKeyAddData> EndManagerKeyAddData(FlatBufferBuilder builder)
		{
			return default(Offset<ManagerKeyAddData>);
		}

		public ManagerKeyAddDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(ManagerKeyAddDataT _o)
		{
		}

		public static Offset<ManagerKeyAddData> Pack(FlatBufferBuilder builder, ManagerKeyAddDataT _o)
		{
			return default(Offset<ManagerKeyAddData>);
		}
	}
}
