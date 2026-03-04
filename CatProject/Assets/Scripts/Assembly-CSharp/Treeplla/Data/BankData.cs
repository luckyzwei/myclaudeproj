using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BankData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Moneybanklevel { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int MoneybanklevelsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BankData GetRootAsBankData(ByteBuffer _bb)
		{
			return GetRootAsBankData(_bb, new BankData());
		}

		public static BankData GetRootAsBankData(ByteBuffer _bb, BankData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BankData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateMoneybanklevel(int moneybanklevel)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, moneybanklevel);
				return true;
			}
			return false;
		}

		public KeyValue? Moneybanklevels(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? (new KeyValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<BankData> CreateBankData(FlatBufferBuilder builder, int moneybanklevel = 0, VectorOffset moneybanklevelsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			AddMoneybanklevels(builder, moneybanklevelsOffset);
			AddMoneybanklevel(builder, moneybanklevel);
			return EndBankData(builder);
		}

		public static void StartBankData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddMoneybanklevel(FlatBufferBuilder builder, int moneybanklevel)
		{
			builder.AddInt(0, moneybanklevel, 0);
		}

		public static void AddMoneybanklevels(FlatBufferBuilder builder, VectorOffset moneybanklevelsOffset)
		{
			builder.AddOffset(1, moneybanklevelsOffset.Value, 0);
		}

		public static VectorOffset CreateMoneybanklevelsVector(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateMoneybanklevelsVectorBlock(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMoneybanklevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValue>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMoneybanklevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartMoneybanklevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<BankData> EndBankData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BankData>(o);
		}

		public BankDataT UnPack()
		{
			var _o = new BankDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BankDataT _o)
		{
			_o.Moneybanklevel = this.Moneybanklevel;
			_o.Moneybanklevels = new List<KeyValueT>();
			for (var _j = 0; _j < this.MoneybanklevelsLength; ++_j)
				_o.Moneybanklevels.Add(this.Moneybanklevels(_j).HasValue ? this.Moneybanklevels(_j).Value.UnPack() : null);
		}

		public static Offset<BankData> Pack(FlatBufferBuilder builder, BankDataT _o)
		{
			if (_o == null) return default(Offset<BankData>);
			var _moneybanklevels = default(VectorOffset);
			if (_o.Moneybanklevels != null)
			{
				var __moneybanklevels = new Offset<KeyValue>[_o.Moneybanklevels.Count];
				for (var _j = 0; _j < _o.Moneybanklevels.Count; ++_j)
					__moneybanklevels[_j] = KeyValue.Pack(builder, _o.Moneybanklevels[_j]);
				_moneybanklevels = CreateMoneybanklevelsVector(builder, __moneybanklevels);
			}
			StartBankData(builder);
			AddMoneybanklevel(builder, _o.Moneybanklevel);
			AddMoneybanklevels(builder, _moneybanklevels);
			return EndBankData(builder);
		}
	}
}
