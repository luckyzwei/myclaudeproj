using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalCurrencyData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Currencyidx => 0;

		public string Currencyvalue => null;

		public static void ValidateVersion()
		{
		}

		public static SeasonalCurrencyData GetRootAsSeasonalCurrencyData(ByteBuffer _bb)
		{
			return default(SeasonalCurrencyData);
		}

		public static SeasonalCurrencyData GetRootAsSeasonalCurrencyData(ByteBuffer _bb, SeasonalCurrencyData obj)
		{
			return default(SeasonalCurrencyData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalCurrencyData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalCurrencyData);
		}

		public bool MutateCurrencyidx(int currencyidx)
		{
			return false;
		}

		public ArraySegment<byte>? GetCurrencyvalueBytes()
		{
			return null;
		}

		public byte[] GetCurrencyvalueArray()
		{
			return null;
		}

		public static Offset<SeasonalCurrencyData> CreateSeasonalCurrencyData(FlatBufferBuilder builder, int currencyidx = 0, StringOffset currencyvalueOffset = default(StringOffset))
		{
			return default(Offset<SeasonalCurrencyData>);
		}

		public static void StartSeasonalCurrencyData(FlatBufferBuilder builder)
		{
		}

		public static void AddCurrencyidx(FlatBufferBuilder builder, int currencyidx)
		{
		}

		public static void AddCurrencyvalue(FlatBufferBuilder builder, StringOffset currencyvalueOffset)
		{
		}

		public static Offset<SeasonalCurrencyData> EndSeasonalCurrencyData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalCurrencyData>);
		}

		public SeasonalCurrencyDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalCurrencyDataT _o)
		{
		}

		public static Offset<SeasonalCurrencyData> Pack(FlatBufferBuilder builder, SeasonalCurrencyDataT _o)
		{
			return default(Offset<SeasonalCurrencyData>);
		}
	}
}
