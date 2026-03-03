using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SpecialPackageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public bool Expire => false;

		public int ParamLength => 0;

		public bool Purchase => false;

		public long Limitttime => 0L;

		public int PackageofferdataLength => 0;

		public static void ValidateVersion()
		{
		}

		public static SpecialPackageData GetRootAsSpecialPackageData(ByteBuffer _bb)
		{
			return default(SpecialPackageData);
		}

		public static SpecialPackageData GetRootAsSpecialPackageData(ByteBuffer _bb, SpecialPackageData obj)
		{
			return default(SpecialPackageData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SpecialPackageData __assign(int _i, ByteBuffer _bb)
		{
			return default(SpecialPackageData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateExpire(bool expire)
		{
			return false;
		}

		public int Param(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetParamBytes()
		{
			return null;
		}

		public int[] GetParamArray()
		{
			return null;
		}

		public bool MutateParam(int j, int param)
		{
			return false;
		}

		public bool MutatePurchase(bool purchase)
		{
			return false;
		}

		public bool MutateLimitttime(long limitttime)
		{
			return false;
		}

		public PackageOfferData? Packageofferdata(int j)
		{
			return null;
		}

		public static Offset<SpecialPackageData> CreateSpecialPackageData(FlatBufferBuilder builder, int idx = 0, bool expire = false, VectorOffset paramOffset = default(VectorOffset), bool purchase = false, long limitttime = 0L, VectorOffset packageofferdataOffset = default(VectorOffset))
		{
			return default(Offset<SpecialPackageData>);
		}

		public static void StartSpecialPackageData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddExpire(FlatBufferBuilder builder, bool expire)
		{
		}

		public static void AddParam(FlatBufferBuilder builder, VectorOffset paramOffset)
		{
		}

		public static VectorOffset CreateParamVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateParamVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateParamVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateParamVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartParamVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPurchase(FlatBufferBuilder builder, bool purchase)
		{
		}

		public static void AddLimitttime(FlatBufferBuilder builder, long limitttime)
		{
		}

		public static void AddPackageofferdata(FlatBufferBuilder builder, VectorOffset packageofferdataOffset)
		{
		}

		public static VectorOffset CreatePackageofferdataVector(FlatBufferBuilder builder, Offset<PackageOfferData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePackageofferdataVectorBlock(FlatBufferBuilder builder, Offset<PackageOfferData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePackageofferdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<PackageOfferData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePackageofferdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartPackageofferdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<SpecialPackageData> EndSpecialPackageData(FlatBufferBuilder builder)
		{
			return default(Offset<SpecialPackageData>);
		}

		public SpecialPackageDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SpecialPackageDataT _o)
		{
		}

		public static Offset<SpecialPackageData> Pack(FlatBufferBuilder builder, SpecialPackageDataT _o)
		{
			return default(Offset<SpecialPackageData>);
		}
	}
}
