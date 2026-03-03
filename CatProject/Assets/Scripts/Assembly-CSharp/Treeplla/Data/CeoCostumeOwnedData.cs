using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CeoCostumeOwnedData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Defaultcostumeidx => 0;

		public int Equippedcostumeidx => 0;

		public int OwnedcostumeidxlistLength => 0;

		public static void ValidateVersion()
		{
		}

		public static CeoCostumeOwnedData GetRootAsCeoCostumeOwnedData(ByteBuffer _bb)
		{
			return default(CeoCostumeOwnedData);
		}

		public static CeoCostumeOwnedData GetRootAsCeoCostumeOwnedData(ByteBuffer _bb, CeoCostumeOwnedData obj)
		{
			return default(CeoCostumeOwnedData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public CeoCostumeOwnedData __assign(int _i, ByteBuffer _bb)
		{
			return default(CeoCostumeOwnedData);
		}

		public bool MutateDefaultcostumeidx(int defaultcostumeidx)
		{
			return false;
		}

		public bool MutateEquippedcostumeidx(int equippedcostumeidx)
		{
			return false;
		}

		public CeoCostumeData? Ownedcostumeidxlist(int j)
		{
			return null;
		}

		public static Offset<CeoCostumeOwnedData> CreateCeoCostumeOwnedData(FlatBufferBuilder builder, int defaultcostumeidx = 0, int equippedcostumeidx = 0, VectorOffset ownedcostumeidxlistOffset = default(VectorOffset))
		{
			return default(Offset<CeoCostumeOwnedData>);
		}

		public static void StartCeoCostumeOwnedData(FlatBufferBuilder builder)
		{
		}

		public static void AddDefaultcostumeidx(FlatBufferBuilder builder, int defaultcostumeidx)
		{
		}

		public static void AddEquippedcostumeidx(FlatBufferBuilder builder, int equippedcostumeidx)
		{
		}

		public static void AddOwnedcostumeidxlist(FlatBufferBuilder builder, VectorOffset ownedcostumeidxlistOffset)
		{
		}

		public static VectorOffset CreateOwnedcostumeidxlistVector(FlatBufferBuilder builder, Offset<CeoCostumeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOwnedcostumeidxlistVectorBlock(FlatBufferBuilder builder, Offset<CeoCostumeData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOwnedcostumeidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CeoCostumeData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOwnedcostumeidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOwnedcostumeidxlistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<CeoCostumeOwnedData> EndCeoCostumeOwnedData(FlatBufferBuilder builder)
		{
			return default(Offset<CeoCostumeOwnedData>);
		}

		public CeoCostumeOwnedDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(CeoCostumeOwnedDataT _o)
		{
		}

		public static Offset<CeoCostumeOwnedData> Pack(FlatBufferBuilder builder, CeoCostumeOwnedDataT _o)
		{
			return default(Offset<CeoCostumeOwnedData>);
		}
	}
}
