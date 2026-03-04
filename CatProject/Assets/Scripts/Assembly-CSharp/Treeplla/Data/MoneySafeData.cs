using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MoneySafeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Count { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Money { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static MoneySafeData GetRootAsMoneySafeData(ByteBuffer _bb)
		{
			return GetRootAsMoneySafeData(_bb, new MoneySafeData());
		}

		public static MoneySafeData GetRootAsMoneySafeData(ByteBuffer _bb, MoneySafeData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public MoneySafeData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateCount(int count)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, count);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetMoneyBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public byte[] GetMoneyArray()
		{
			return __p.__vector_as_array<byte>(6);
		}

		public static Offset<MoneySafeData> CreateMoneySafeData(FlatBufferBuilder builder, int count = 0, StringOffset moneyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			AddMoney(builder, moneyOffset);
			AddCount(builder, count);
			return EndMoneySafeData(builder);
		}

		public static void StartMoneySafeData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(0, count, 0);
		}

		public static void AddMoney(FlatBufferBuilder builder, StringOffset moneyOffset)
		{
			builder.AddOffset(1, moneyOffset.Value, 0);
		}

		public static Offset<MoneySafeData> EndMoneySafeData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<MoneySafeData>(o);
		}

		public MoneySafeDataT UnPack()
		{
			var _o = new MoneySafeDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(MoneySafeDataT _o)
		{
			_o.Count = this.Count;
			_o.Money = this.Money;
		}

		public static Offset<MoneySafeData> Pack(FlatBufferBuilder builder, MoneySafeDataT _o)
		{
			if (_o == null) return default(Offset<MoneySafeData>);
			var _money = _o.Money == null ? default(StringOffset) : builder.CreateString(_o.Money);
			StartMoneySafeData(builder);
			AddCount(builder, _o.Count);
			AddMoney(builder, _money);
			return EndMoneySafeData(builder);
		}
	}
}
