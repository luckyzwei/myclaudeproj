using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct PassReceiveData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int NormalLength => 0;

		public int PremiumLength => 0;

		public static void ValidateVersion()
		{
		}

		public static PassReceiveData GetRootAsPassReceiveData(ByteBuffer _bb)
		{
			return default(PassReceiveData);
		}

		public static PassReceiveData GetRootAsPassReceiveData(ByteBuffer _bb, PassReceiveData obj)
		{
			return default(PassReceiveData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public PassReceiveData __assign(int _i, ByteBuffer _bb)
		{
			return default(PassReceiveData);
		}

		public int Normal(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetNormalBytes()
		{
			return null;
		}

		public int[] GetNormalArray()
		{
			return null;
		}

		public bool MutateNormal(int j, int normal)
		{
			return false;
		}

		public int Premium(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetPremiumBytes()
		{
			return null;
		}

		public int[] GetPremiumArray()
		{
			return null;
		}

		public bool MutatePremium(int j, int premium)
		{
			return false;
		}

		public static Offset<PassReceiveData> CreatePassReceiveData(FlatBufferBuilder builder, VectorOffset normalOffset = default(VectorOffset), VectorOffset premiumOffset = default(VectorOffset))
		{
			return default(Offset<PassReceiveData>);
		}

		public static void StartPassReceiveData(FlatBufferBuilder builder)
		{
		}

		public static void AddNormal(FlatBufferBuilder builder, VectorOffset normalOffset)
		{
		}

		public static VectorOffset CreateNormalVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateNormalVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateNormalVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateNormalVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartNormalVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPremium(FlatBufferBuilder builder, VectorOffset premiumOffset)
		{
		}

		public static VectorOffset CreatePremiumVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePremiumVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePremiumVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePremiumVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartPremiumVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<PassReceiveData> EndPassReceiveData(FlatBufferBuilder builder)
		{
			return default(Offset<PassReceiveData>);
		}

		public PassReceiveDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(PassReceiveDataT _o)
		{
		}

		public static Offset<PassReceiveData> Pack(FlatBufferBuilder builder, PassReceiveDataT _o)
		{
			return default(Offset<PassReceiveData>);
		}
	}
}
