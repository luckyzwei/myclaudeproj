using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SpecialDayData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Specialdayidx => 0;

		public int SpecialdaydecoLength => 0;

		public bool Firstguideview => false;

		public int Specialdayyear => 0;

		public static void ValidateVersion()
		{
		}

		public static SpecialDayData GetRootAsSpecialDayData(ByteBuffer _bb)
		{
			return default(SpecialDayData);
		}

		public static SpecialDayData GetRootAsSpecialDayData(ByteBuffer _bb, SpecialDayData obj)
		{
			return default(SpecialDayData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SpecialDayData __assign(int _i, ByteBuffer _bb)
		{
			return default(SpecialDayData);
		}

		public bool MutateSpecialdayidx(int specialdayidx)
		{
			return false;
		}

		public ItemData? Specialdaydeco(int j)
		{
			return null;
		}

		public bool MutateFirstguideview(bool firstguideview)
		{
			return false;
		}

		public bool MutateSpecialdayyear(int specialdayyear)
		{
			return false;
		}

		public static Offset<SpecialDayData> CreateSpecialDayData(FlatBufferBuilder builder, int specialdayidx = 0, VectorOffset specialdaydecoOffset = default(VectorOffset), bool firstguideview = false, int specialdayyear = 0)
		{
			return default(Offset<SpecialDayData>);
		}

		public static void StartSpecialDayData(FlatBufferBuilder builder)
		{
		}

		public static void AddSpecialdayidx(FlatBufferBuilder builder, int specialdayidx)
		{
		}

		public static void AddSpecialdaydeco(FlatBufferBuilder builder, VectorOffset specialdaydecoOffset)
		{
		}

		public static VectorOffset CreateSpecialdaydecoVector(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSpecialdaydecoVectorBlock(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSpecialdaydecoVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ItemData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateSpecialdaydecoVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartSpecialdaydecoVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddFirstguideview(FlatBufferBuilder builder, bool firstguideview)
		{
		}

		public static void AddSpecialdayyear(FlatBufferBuilder builder, int specialdayyear)
		{
		}

		public static Offset<SpecialDayData> EndSpecialDayData(FlatBufferBuilder builder)
		{
			return default(Offset<SpecialDayData>);
		}

		public SpecialDayDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SpecialDayDataT _o)
		{
		}

		public static Offset<SpecialDayData> Pack(FlatBufferBuilder builder, SpecialDayDataT _o)
		{
			return default(Offset<SpecialDayData>);
		}
	}
}
