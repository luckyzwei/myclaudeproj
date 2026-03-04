using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static EventData GetRootAsEventData(ByteBuffer _bb)
		{
			return GetRootAsEventData(_bb, new EventData());
		}

		public static EventData GetRootAsEventData(ByteBuffer _bb, EventData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public EventData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIdx(int idx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, idx);
				return true;
			}
			return false;
		}

		public static Offset<EventData> CreateEventData(FlatBufferBuilder builder, int idx = 0)
		{
			builder.StartTable(1);
			AddIdx(builder, idx);
			return EndEventData(builder);
		}

		public static void StartEventData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static Offset<EventData> EndEventData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<EventData>(o);
		}

		public EventDataT UnPack()
		{
			var _o = new EventDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(EventDataT _o)
		{
			_o.Idx = this.Idx;
		}

		public static Offset<EventData> Pack(FlatBufferBuilder builder, EventDataT _o)
		{
			if (_o == null) return default(Offset<EventData>);
			StartEventData(builder);
			AddIdx(builder, _o.Idx);
			return EndEventData(builder);
		}
	}
}
