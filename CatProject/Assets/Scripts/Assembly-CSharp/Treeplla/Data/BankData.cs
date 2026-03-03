using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BankData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Moneybanklevel => 0;

		public int MoneybanklevelsLength => 0;

		public static void ValidateVersion()
		{
		}

		public static BankData GetRootAsBankData(ByteBuffer _bb)
		{
			return default(BankData);
		}

		public static BankData GetRootAsBankData(ByteBuffer _bb, BankData obj)
		{
			return default(BankData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BankData __assign(int _i, ByteBuffer _bb)
		{
			return default(BankData);
		}

		public bool MutateMoneybanklevel(int moneybanklevel)
		{
			return false;
		}

		public KeyValue? Moneybanklevels(int j)
		{
			return null;
		}

		public static Offset<BankData> CreateBankData(FlatBufferBuilder builder, int moneybanklevel = 0, VectorOffset moneybanklevelsOffset = default(VectorOffset))
		{
			return default(Offset<BankData>);
		}

		public static void StartBankData(FlatBufferBuilder builder)
		{
		}

		public static void AddMoneybanklevel(FlatBufferBuilder builder, int moneybanklevel)
		{
		}

		public static void AddMoneybanklevels(FlatBufferBuilder builder, VectorOffset moneybanklevelsOffset)
		{
		}

		public static VectorOffset CreateMoneybanklevelsVector(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMoneybanklevelsVectorBlock(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMoneybanklevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValue>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMoneybanklevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartMoneybanklevelsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<BankData> EndBankData(FlatBufferBuilder builder)
		{
			return default(Offset<BankData>);
		}

		public BankDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BankDataT _o)
		{
		}

		public static Offset<BankData> Pack(FlatBufferBuilder builder, BankDataT _o)
		{
			return default(Offset<BankData>);
		}
	}
}
