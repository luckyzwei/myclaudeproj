using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct UniqueCustomerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int CustomerLength => 0;

		public int Reddot => 0;

		public static void ValidateVersion()
		{
		}

		public static UniqueCustomerData GetRootAsUniqueCustomerData(ByteBuffer _bb)
		{
			return default(UniqueCustomerData);
		}

		public static UniqueCustomerData GetRootAsUniqueCustomerData(ByteBuffer _bb, UniqueCustomerData obj)
		{
			return default(UniqueCustomerData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public UniqueCustomerData __assign(int _i, ByteBuffer _bb)
		{
			return default(UniqueCustomerData);
		}

		public bool Customer(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetCustomerBytes()
		{
			return null;
		}

		public bool[] GetCustomerArray()
		{
			return null;
		}

		public bool MutateCustomer(int j, bool customer)
		{
			return false;
		}

		public bool MutateReddot(int reddot)
		{
			return false;
		}

		public static Offset<UniqueCustomerData> CreateUniqueCustomerData(FlatBufferBuilder builder, VectorOffset customerOffset = default(VectorOffset), int reddot = 0)
		{
			return default(Offset<UniqueCustomerData>);
		}

		public static void StartUniqueCustomerData(FlatBufferBuilder builder)
		{
		}

		public static void AddCustomer(FlatBufferBuilder builder, VectorOffset customerOffset)
		{
		}

		public static VectorOffset CreateCustomerVector(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCustomerVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCustomerVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCustomerVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCustomerVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddReddot(FlatBufferBuilder builder, int reddot)
		{
		}

		public static Offset<UniqueCustomerData> EndUniqueCustomerData(FlatBufferBuilder builder)
		{
			return default(Offset<UniqueCustomerData>);
		}

		public UniqueCustomerDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(UniqueCustomerDataT _o)
		{
		}

		public static Offset<UniqueCustomerData> Pack(FlatBufferBuilder builder, UniqueCustomerDataT _o)
		{
			return default(Offset<UniqueCustomerData>);
		}
	}
}
