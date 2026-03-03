using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BoosterBuffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Boosteridx => 0;

		public int Totalusecount => 0;

		public int BoosterregionbuffdataLength => 0;

		public bool Boosterticketuseactive => false;

		public static void ValidateVersion()
		{
		}

		public static BoosterBuffData GetRootAsBoosterBuffData(ByteBuffer _bb)
		{
			return default(BoosterBuffData);
		}

		public static BoosterBuffData GetRootAsBoosterBuffData(ByteBuffer _bb, BoosterBuffData obj)
		{
			return default(BoosterBuffData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BoosterBuffData __assign(int _i, ByteBuffer _bb)
		{
			return default(BoosterBuffData);
		}

		public bool MutateBoosteridx(int boosteridx)
		{
			return false;
		}

		public bool MutateTotalusecount(int totalusecount)
		{
			return false;
		}

		public BoosterRegionBuffData? Boosterregionbuffdata(int j)
		{
			return null;
		}

		public bool MutateBoosterticketuseactive(bool boosterticketuseactive)
		{
			return false;
		}

		public static Offset<BoosterBuffData> CreateBoosterBuffData(FlatBufferBuilder builder, int boosteridx = 0, int totalusecount = 0, VectorOffset boosterregionbuffdataOffset = default(VectorOffset), bool boosterticketuseactive = true)
		{
			return default(Offset<BoosterBuffData>);
		}

		public static void StartBoosterBuffData(FlatBufferBuilder builder)
		{
		}

		public static void AddBoosteridx(FlatBufferBuilder builder, int boosteridx)
		{
		}

		public static void AddTotalusecount(FlatBufferBuilder builder, int totalusecount)
		{
		}

		public static void AddBoosterregionbuffdata(FlatBufferBuilder builder, VectorOffset boosterregionbuffdataOffset)
		{
		}

		public static VectorOffset CreateBoosterregionbuffdataVector(FlatBufferBuilder builder, Offset<BoosterRegionBuffData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBoosterregionbuffdataVectorBlock(FlatBufferBuilder builder, Offset<BoosterRegionBuffData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBoosterregionbuffdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BoosterRegionBuffData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateBoosterregionbuffdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartBoosterregionbuffdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddBoosterticketuseactive(FlatBufferBuilder builder, bool boosterticketuseactive)
		{
		}

		public static Offset<BoosterBuffData> EndBoosterBuffData(FlatBufferBuilder builder)
		{
			return default(Offset<BoosterBuffData>);
		}

		public BoosterBuffDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BoosterBuffDataT _o)
		{
		}

		public static Offset<BoosterBuffData> Pack(FlatBufferBuilder builder, BoosterBuffDataT _o)
		{
			return default(Offset<BoosterBuffData>);
		}
	}
}
