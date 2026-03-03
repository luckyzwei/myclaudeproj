using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct GemPassData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int NormalLength => 0;

		public int PremiumLength => 0;

		public static void ValidateVersion()
		{
		}

		public static GemPassData GetRootAsGemPassData(ByteBuffer _bb)
		{
			return default(GemPassData);
		}

		public static GemPassData GetRootAsGemPassData(ByteBuffer _bb, GemPassData obj)
		{
			return default(GemPassData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public GemPassData __assign(int _i, ByteBuffer _bb)
		{
			return default(GemPassData);
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

		public static Offset<GemPassData> CreateGemPassData(FlatBufferBuilder builder, VectorOffset normalOffset = default(VectorOffset), VectorOffset premiumOffset = default(VectorOffset))
		{
			return default(Offset<GemPassData>);
		}

		public static void StartGemPassData(FlatBufferBuilder builder)
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

		public static Offset<GemPassData> EndGemPassData(FlatBufferBuilder builder)
		{
			return default(Offset<GemPassData>);
		}

		public GemPassDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(GemPassDataT _o)
		{
		}

		public static Offset<GemPassData> Pack(FlatBufferBuilder builder, GemPassDataT _o)
		{
			return default(Offset<GemPassData>);
		}
	}
}
