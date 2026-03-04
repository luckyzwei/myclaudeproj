using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EventStaffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Endtime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public bool Maxrapid { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static EventStaffData GetRootAsEventStaffData(ByteBuffer _bb)
		{
			return GetRootAsEventStaffData(_bb, new EventStaffData());
		}

		public static EventStaffData GetRootAsEventStaffData(ByteBuffer _bb, EventStaffData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public EventStaffData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateEndtime(long endtime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, endtime);
				return true;
			}
			return false;
		}

		public bool MutateMaxrapid(bool maxrapid)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(maxrapid ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<EventStaffData> CreateEventStaffData(FlatBufferBuilder builder, int idx = 0, long endtime = 0L, bool maxrapid = false)
		{
			builder.StartTable(3);
			AddMaxrapid(builder, maxrapid);
			AddEndtime(builder, endtime);
			AddIdx(builder, idx);
			return EndEventStaffData(builder);
		}

		public static void StartEventStaffData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
			builder.AddLong(1, endtime, 0);
		}

		public static void AddMaxrapid(FlatBufferBuilder builder, bool maxrapid)
		{
			builder.AddBool(2, maxrapid, false);
		}

		public static Offset<EventStaffData> EndEventStaffData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<EventStaffData>(o);
		}

		public EventStaffDataT UnPack()
		{
			var _o = new EventStaffDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(EventStaffDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Endtime = this.Endtime;
			_o.Maxrapid = this.Maxrapid;
		}

		public static Offset<EventStaffData> Pack(FlatBufferBuilder builder, EventStaffDataT _o)
		{
			if (_o == null) return default(Offset<EventStaffData>);
			StartEventStaffData(builder);
			AddIdx(builder, _o.Idx);
			AddEndtime(builder, _o.Endtime);
			AddMaxrapid(builder, _o.Maxrapid);
			return EndEventStaffData(builder);
		}
	}
}
