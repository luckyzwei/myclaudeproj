using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AdpassData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Openvalue => 0;

		public long Resettime => 0L;

		public int GetrewardsLength => 0;

		public int Adviewcount => 0;

		public static void ValidateVersion()
		{
		}

		public static AdpassData GetRootAsAdpassData(ByteBuffer _bb)
		{
			return default(AdpassData);
		}

		public static AdpassData GetRootAsAdpassData(ByteBuffer _bb, AdpassData obj)
		{
			return default(AdpassData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AdpassData __assign(int _i, ByteBuffer _bb)
		{
			return default(AdpassData);
		}

		public bool MutateOpenvalue(int openvalue)
		{
			return false;
		}

		public bool MutateResettime(long resettime)
		{
			return false;
		}

		public int Getrewards(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetGetrewardsBytes()
		{
			return null;
		}

		public int[] GetGetrewardsArray()
		{
			return null;
		}

		public bool MutateGetrewards(int j, int getrewards)
		{
			return false;
		}

		public bool MutateAdviewcount(int adviewcount)
		{
			return false;
		}

		public static Offset<AdpassData> CreateAdpassData(FlatBufferBuilder builder, int openvalue = -1, long resettime = 0L, VectorOffset getrewardsOffset = default(VectorOffset), int adviewcount = 0)
		{
			return default(Offset<AdpassData>);
		}

		public static void StartAdpassData(FlatBufferBuilder builder)
		{
		}

		public static void AddOpenvalue(FlatBufferBuilder builder, int openvalue)
		{
		}

		public static void AddResettime(FlatBufferBuilder builder, long resettime)
		{
		}

		public static void AddGetrewards(FlatBufferBuilder builder, VectorOffset getrewardsOffset)
		{
		}

		public static VectorOffset CreateGetrewardsVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartGetrewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddAdviewcount(FlatBufferBuilder builder, int adviewcount)
		{
		}

		public static Offset<AdpassData> EndAdpassData(FlatBufferBuilder builder)
		{
			return default(Offset<AdpassData>);
		}

		public AdpassDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(AdpassDataT _o)
		{
		}

		public static Offset<AdpassData> Pack(FlatBufferBuilder builder, AdpassDataT _o)
		{
			return default(Offset<AdpassData>);
		}
	}
}
