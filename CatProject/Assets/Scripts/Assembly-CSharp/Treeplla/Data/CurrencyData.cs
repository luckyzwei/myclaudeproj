using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CurrencyData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Currencyid => 0;

		public string Value => null;

		public static void ValidateVersion()
		{
		}

		public static CurrencyData GetRootAsCurrencyData(ByteBuffer _bb)
		{
			return default(CurrencyData);
		}

		public static CurrencyData GetRootAsCurrencyData(ByteBuffer _bb, CurrencyData obj)
		{
			return default(CurrencyData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public CurrencyData __assign(int _i, ByteBuffer _bb)
		{
			return default(CurrencyData);
		}

		public bool MutateCurrencyid(int currencyid)
		{
			return false;
		}

		public ArraySegment<byte>? GetValueBytes()
		{
			return null;
		}

		public byte[] GetValueArray()
		{
			return null;
		}

		public static Offset<CurrencyData> CreateCurrencyData(FlatBufferBuilder builder, int currencyid = 0, StringOffset valueOffset = default(StringOffset))
		{
			return default(Offset<CurrencyData>);
		}

		public static void StartCurrencyData(FlatBufferBuilder builder)
		{
		}

		public static void AddCurrencyid(FlatBufferBuilder builder, int currencyid)
		{
		}

		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
		}

		public static Offset<CurrencyData> EndCurrencyData(FlatBufferBuilder builder)
		{
			return default(Offset<CurrencyData>);
		}

		public CurrencyDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(CurrencyDataT _o)
		{
		}

		public static Offset<CurrencyData> Pack(FlatBufferBuilder builder, CurrencyDataT _o)
		{
			return default(Offset<CurrencyData>);
		}
	}
}
