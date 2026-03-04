using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CurrencyData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Currencyid { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Value { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static CurrencyData GetRootAsCurrencyData(ByteBuffer _bb)
		{
			return GetRootAsCurrencyData(_bb, new CurrencyData());
		}

		public static CurrencyData GetRootAsCurrencyData(ByteBuffer _bb, CurrencyData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public CurrencyData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateCurrencyid(int currencyid)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, currencyid);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetValueBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public byte[] GetValueArray()
		{
			return __p.__vector_as_array<byte>(6);
		}

		public static Offset<CurrencyData> CreateCurrencyData(FlatBufferBuilder builder, int currencyid = 0, StringOffset valueOffset = default(StringOffset))
		{
			builder.StartTable(2);
			AddValue(builder, valueOffset);
			AddCurrencyid(builder, currencyid);
			return EndCurrencyData(builder);
		}

		public static void StartCurrencyData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddCurrencyid(FlatBufferBuilder builder, int currencyid)
		{
			builder.AddInt(0, currencyid, 0);
		}

		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		public static Offset<CurrencyData> EndCurrencyData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<CurrencyData>(o);
		}

		public CurrencyDataT UnPack()
		{
			var _o = new CurrencyDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(CurrencyDataT _o)
		{
			_o.Currencyid = this.Currencyid;
			_o.Value = this.Value;
		}

		public static Offset<CurrencyData> Pack(FlatBufferBuilder builder, CurrencyDataT _o)
		{
			if (_o == null) return default(Offset<CurrencyData>);
			var _value = _o.Value == null ? default(StringOffset) : builder.CreateString(_o.Value);
			StartCurrencyData(builder);
			AddCurrencyid(builder, _o.Currencyid);
			AddValue(builder, _value);
			return EndCurrencyData(builder);
		}
	}
}
