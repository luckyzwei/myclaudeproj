using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AttendanceData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Eventtype { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Dayindx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Isattended { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static AttendanceData GetRootAsAttendanceData(ByteBuffer _bb)
		{
			return GetRootAsAttendanceData(_bb, new AttendanceData());
		}

		public static AttendanceData GetRootAsAttendanceData(ByteBuffer _bb, AttendanceData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public AttendanceData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateEventtype(int eventtype)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, eventtype);
				return true;
			}
			return false;
		}

		public bool MutateDayindx(int dayindx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, dayindx);
				return true;
			}
			return false;
		}

		public bool MutateIsattended(bool isattended)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isattended ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<AttendanceData> CreateAttendanceData(FlatBufferBuilder builder, int eventtype = 0, int dayindx = 0, bool isattended = false)
		{
			builder.StartTable(3);
			AddIsattended(builder, isattended);
			AddDayindx(builder, dayindx);
			AddEventtype(builder, eventtype);
			return EndAttendanceData(builder);
		}

		public static void StartAttendanceData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddEventtype(FlatBufferBuilder builder, int eventtype)
		{
			builder.AddInt(0, eventtype, 0);
		}

		public static void AddDayindx(FlatBufferBuilder builder, int dayindx)
		{
			builder.AddInt(1, dayindx, 0);
		}

		public static void AddIsattended(FlatBufferBuilder builder, bool isattended)
		{
			builder.AddBool(2, isattended, false);
		}

		public static Offset<AttendanceData> EndAttendanceData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<AttendanceData>(o);
		}

		public AttendanceDataT UnPack()
		{
			var _o = new AttendanceDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(AttendanceDataT _o)
		{
			_o.Eventtype = this.Eventtype;
			_o.Dayindx = this.Dayindx;
			_o.Isattended = this.Isattended;
		}

		public static Offset<AttendanceData> Pack(FlatBufferBuilder builder, AttendanceDataT _o)
		{
			if (_o == null) return default(Offset<AttendanceData>);
			StartAttendanceData(builder);
			AddEventtype(builder, _o.Eventtype);
			AddDayindx(builder, _o.Dayindx);
			AddIsattended(builder, _o.Isattended);
			return EndAttendanceData(builder);
		}
	}
}
