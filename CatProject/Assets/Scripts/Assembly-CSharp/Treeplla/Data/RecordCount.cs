using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RecordCount : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public string Idx { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public int Count { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static RecordCount GetRootAsRecordCount(ByteBuffer _bb)
		{
			return GetRootAsRecordCount(_bb, new RecordCount());
		}

		public static RecordCount GetRootAsRecordCount(ByteBuffer _bb, RecordCount obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public RecordCount __assign(int _i, ByteBuffer _bb)
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

		public bool MutateCount(int count)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, count);
				return true;
			}
			return false;
		}

		public static Offset<RecordCount> CreateRecordCount(FlatBufferBuilder builder, StringOffset idxOffset = default(StringOffset), int count = 0)
		{
			builder.StartTable(2);
			AddCount(builder, count);
			AddIdx(builder, idxOffset);
			return EndRecordCount(builder);
		}

		public static void StartRecordCount(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddIdx(FlatBufferBuilder builder, StringOffset idxOffset)
		{
			builder.AddOffset(0, idxOffset.Value, 0);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		public static Offset<RecordCount> EndRecordCount(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<RecordCount>(o);
		}

		public RecordCountT UnPack()
		{
			var _o = new RecordCountT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(RecordCountT _o)
		{
			_o.Idx = this.Idx;
			_o.Count = this.Count;
		}

		public static Offset<RecordCount> Pack(FlatBufferBuilder builder, RecordCountT _o)
		{
			if (_o == null) return default(Offset<RecordCount>);
			var _idx = _o.Idx == null ? default(StringOffset) : builder.CreateString(_o.Idx);
			StartRecordCount(builder);
			AddIdx(builder, _idx);
			AddCount(builder, _o.Count);
			return EndRecordCount(builder);
		}
	}
}
