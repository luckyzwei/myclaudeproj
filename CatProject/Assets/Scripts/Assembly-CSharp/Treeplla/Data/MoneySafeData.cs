using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MoneySafeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Count => 0;

		public string Money => null;

		public static void ValidateVersion()
		{
		}

		public static MoneySafeData GetRootAsMoneySafeData(ByteBuffer _bb)
		{
			return default(MoneySafeData);
		}

		public static MoneySafeData GetRootAsMoneySafeData(ByteBuffer _bb, MoneySafeData obj)
		{
			return default(MoneySafeData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public MoneySafeData __assign(int _i, ByteBuffer _bb)
		{
			return default(MoneySafeData);
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public ArraySegment<byte>? GetMoneyBytes()
		{
			return null;
		}

		public byte[] GetMoneyArray()
		{
			return null;
		}

		public static Offset<MoneySafeData> CreateMoneySafeData(FlatBufferBuilder builder, int count = 0, StringOffset moneyOffset = default(StringOffset))
		{
			return default(Offset<MoneySafeData>);
		}

		public static void StartMoneySafeData(FlatBufferBuilder builder)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static void AddMoney(FlatBufferBuilder builder, StringOffset moneyOffset)
		{
		}

		public static Offset<MoneySafeData> EndMoneySafeData(FlatBufferBuilder builder)
		{
			return default(Offset<MoneySafeData>);
		}

		public MoneySafeDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(MoneySafeDataT _o)
		{
		}

		public static Offset<MoneySafeData> Pack(FlatBufferBuilder builder, MoneySafeDataT _o)
		{
			return default(Offset<MoneySafeData>);
		}
	}
}
