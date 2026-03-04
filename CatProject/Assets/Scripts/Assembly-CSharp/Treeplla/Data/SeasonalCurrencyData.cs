using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalCurrencyData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Currencyidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Currencyvalue { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalCurrencyData GetRootAsSeasonalCurrencyData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalCurrencyData(_bb, new SeasonalCurrencyData());
		}

		public static SeasonalCurrencyData GetRootAsSeasonalCurrencyData(ByteBuffer _bb, SeasonalCurrencyData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalCurrencyData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateCurrencyidx(int currencyidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, currencyidx);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetCurrencyvalueBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public byte[] GetCurrencyvalueArray()
		{
			return __p.__vector_as_array<byte>(6);
		}

		public static Offset<SeasonalCurrencyData> CreateSeasonalCurrencyData(FlatBufferBuilder builder, int currencyidx = 0, StringOffset currencyvalueOffset = default(StringOffset))
		{
			builder.StartTable(2);
			AddCurrencyvalue(builder, currencyvalueOffset);
			AddCurrencyidx(builder, currencyidx);
			return EndSeasonalCurrencyData(builder);
		}

		public static void StartSeasonalCurrencyData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddCurrencyidx(FlatBufferBuilder builder, int currencyidx)
		{
			builder.AddInt(0, currencyidx, 0);
		}

		public static void AddCurrencyvalue(FlatBufferBuilder builder, StringOffset currencyvalueOffset)
		{
			builder.AddOffset(1, currencyvalueOffset.Value, 0);
		}

		public static Offset<SeasonalCurrencyData> EndSeasonalCurrencyData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalCurrencyData>(o);
		}

		public SeasonalCurrencyDataT UnPack()
		{
			var _o = new SeasonalCurrencyDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalCurrencyDataT _o)
		{
			_o.Currencyidx = this.Currencyidx;
			_o.Currencyvalue = this.Currencyvalue;
		}

		public static Offset<SeasonalCurrencyData> Pack(FlatBufferBuilder builder, SeasonalCurrencyDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalCurrencyData>);
			var _currencyvalue = _o.Currencyvalue == null ? default(StringOffset) : builder.CreateString(_o.Currencyvalue);
			StartSeasonalCurrencyData(builder);
			AddCurrencyidx(builder, _o.Currencyidx);
			AddCurrencyvalue(builder, _currencyvalue);
			return EndSeasonalCurrencyData(builder);
		}
	}
}
