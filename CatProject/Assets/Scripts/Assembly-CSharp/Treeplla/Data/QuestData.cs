using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct QuestData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Order { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Value { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public bool Recevied { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static QuestData GetRootAsQuestData(ByteBuffer _bb)
		{
			return GetRootAsQuestData(_bb, new QuestData());
		}

		public static QuestData GetRootAsQuestData(ByteBuffer _bb, QuestData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public QuestData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateOrder(int order)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, order);
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

		public bool MutateRecevied(bool recevied)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(recevied ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<QuestData> CreateQuestData(FlatBufferBuilder builder, int order = 0, StringOffset valueOffset = default(StringOffset), bool recevied = false)
		{
			builder.StartTable(3);
			AddRecevied(builder, recevied);
			AddValue(builder, valueOffset);
			AddOrder(builder, order);
			return EndQuestData(builder);
		}

		public static void StartQuestData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddOrder(FlatBufferBuilder builder, int order)
		{
			builder.AddInt(0, order, 0);
		}

		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(1, valueOffset.Value, 0);
		}

		public static void AddRecevied(FlatBufferBuilder builder, bool recevied)
		{
			builder.AddBool(2, recevied, false);
		}

		public static Offset<QuestData> EndQuestData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<QuestData>(o);
		}

		public QuestDataT UnPack()
		{
			var _o = new QuestDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(QuestDataT _o)
		{
			_o.Order = this.Order;
			_o.Value = this.Value;
			_o.Recevied = this.Recevied;
		}

		public static Offset<QuestData> Pack(FlatBufferBuilder builder, QuestDataT _o)
		{
			if (_o == null) return default(Offset<QuestData>);
			var _value = _o.Value == null ? default(StringOffset) : builder.CreateString(_o.Value);
			StartQuestData(builder);
			AddOrder(builder, _o.Order);
			AddValue(builder, _value);
			AddRecevied(builder, _o.Recevied);
			return EndQuestData(builder);
		}
	}
}
