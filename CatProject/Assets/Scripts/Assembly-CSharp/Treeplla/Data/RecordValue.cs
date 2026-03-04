using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RecordValue : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public string Idx { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public long Value { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static RecordValue GetRootAsRecordValue(ByteBuffer _bb)
		{
			return GetRootAsRecordValue(_bb, new RecordValue());
		}

		public static RecordValue GetRootAsRecordValue(ByteBuffer _bb, RecordValue obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public RecordValue __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public ArraySegment<byte>? GetIdxBytes()
		{
			return __p.__vector_as_arraysegment(4);
		}

		public byte[] GetIdxArray()
		{
			return __p.__vector_as_array<byte>(4);
		}

		public bool MutateValue(long value)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, value);
				return true;
			}
			return false;
		}

		public static Offset<RecordValue> CreateRecordValue(FlatBufferBuilder builder, StringOffset idxOffset = default(StringOffset), long value = 0L)
		{
			builder.StartTable(2);
			AddValue(builder, value);
			AddIdx(builder, idxOffset);
			return EndRecordValue(builder);
		}

		public static void StartRecordValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddIdx(FlatBufferBuilder builder, StringOffset idxOffset)
		{
			builder.AddOffset(0, idxOffset.Value, 0);
		}

		public static void AddValue(FlatBufferBuilder builder, long value)
		{
			builder.AddLong(1, value, 0);
		}

		public static Offset<RecordValue> EndRecordValue(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<RecordValue>(o);
		}

		public RecordValueT UnPack()
		{
			var _o = new RecordValueT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(RecordValueT _o)
		{
			_o.Idx = this.Idx;
			_o.Value = this.Value;
		}

		public static Offset<RecordValue> Pack(FlatBufferBuilder builder, RecordValueT _o)
		{
			if (_o == null) return default(Offset<RecordValue>);
			var _idx = _o.Idx == null ? default(StringOffset) : builder.CreateString(_o.Idx);
			StartRecordValue(builder);
			AddIdx(builder, _idx);
			AddValue(builder, _o.Value);
			return EndRecordValue(builder);
		}
	}
}
