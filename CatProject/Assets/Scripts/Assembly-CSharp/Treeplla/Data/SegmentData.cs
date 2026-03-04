using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SegmentData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Type { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Id { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SegmentData GetRootAsSegmentData(ByteBuffer _bb)
		{
			return GetRootAsSegmentData(_bb, new SegmentData());
		}

		public static SegmentData GetRootAsSegmentData(ByteBuffer _bb, SegmentData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SegmentData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateType(int type)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, type);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetIdBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public byte[] GetIdArray()
		{
			return __p.__vector_as_array<byte>(6);
		}

		public static Offset<SegmentData> CreateSegmentData(FlatBufferBuilder builder, int type = -1, StringOffset idOffset = default(StringOffset))
		{
			builder.StartTable(2);
			AddId(builder, idOffset);
			AddType(builder, type);
			return EndSegmentData(builder);
		}

		public static void StartSegmentData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddType(FlatBufferBuilder builder, int type)
		{
			builder.AddInt(0, type, 0);
		}

		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(1, idOffset.Value, 0);
		}

		public static Offset<SegmentData> EndSegmentData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SegmentData>(o);
		}

		public SegmentDataT UnPack()
		{
			var _o = new SegmentDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SegmentDataT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		public static Offset<SegmentData> Pack(FlatBufferBuilder builder, SegmentDataT _o)
		{
			if (_o == null) return default(Offset<SegmentData>);
			var _id = _o.Id == null ? default(StringOffset) : builder.CreateString(_o.Id);
			StartSegmentData(builder);
			AddType(builder, _o.Type);
			AddId(builder, _id);
			return EndSegmentData(builder);
		}
	}
}
