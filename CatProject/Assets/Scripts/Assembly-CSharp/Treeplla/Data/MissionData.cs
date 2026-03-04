using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Slot { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Order { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Value { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static MissionData GetRootAsMissionData(ByteBuffer _bb)
		{
			return GetRootAsMissionData(_bb, new MissionData());
		}

		public static MissionData GetRootAsMissionData(ByteBuffer _bb, MissionData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public MissionData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSlot(int slot)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, slot);
				return true;
			}
			return false;
		}

		public bool MutateOrder(int order)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, order);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetValueBytes()
		{
			return __p.__vector_as_arraysegment(8);
		}

		public byte[] GetValueArray()
		{
			return __p.__vector_as_array<byte>(8);
		}

		public static Offset<MissionData> CreateMissionData(FlatBufferBuilder builder, int slot = 0, int order = 0, StringOffset valueOffset = default(StringOffset))
		{
			builder.StartTable(3);
			AddValue(builder, valueOffset);
			AddOrder(builder, order);
			AddSlot(builder, slot);
			return EndMissionData(builder);
		}

		public static void StartMissionData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddSlot(FlatBufferBuilder builder, int slot)
		{
			builder.AddInt(0, slot, 0);
		}

		public static void AddOrder(FlatBufferBuilder builder, int order)
		{
			builder.AddInt(1, order, 0);
		}

		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(2, valueOffset.Value, 0);
		}

		public static Offset<MissionData> EndMissionData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<MissionData>(o);
		}

		public MissionDataT UnPack()
		{
			var _o = new MissionDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(MissionDataT _o)
		{
			_o.Slot = this.Slot;
			_o.Order = this.Order;
			_o.Value = this.Value;
		}

		public static Offset<MissionData> Pack(FlatBufferBuilder builder, MissionDataT _o)
		{
			if (_o == null) return default(Offset<MissionData>);
			var _value = _o.Value == null ? default(StringOffset) : builder.CreateString(_o.Value);
			StartMissionData(builder);
			AddSlot(builder, _o.Slot);
			AddOrder(builder, _o.Order);
			AddValue(builder, _value);
			return EndMissionData(builder);
		}
	}
}
