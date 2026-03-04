using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EmployeeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Seat { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Idx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Viewidx { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static EmployeeData GetRootAsEmployeeData(ByteBuffer _bb)
		{
			return GetRootAsEmployeeData(_bb, new EmployeeData());
		}

		public static EmployeeData GetRootAsEmployeeData(ByteBuffer _bb, EmployeeData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public EmployeeData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSeat(int seat)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, seat);
				return true;
			}
			return false;
		}

		public bool MutateIdx(int idx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, idx);
				return true;
			}
			return false;
		}

		public bool MutateViewidx(int viewidx)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, viewidx);
				return true;
			}
			return false;
		}

		public static Offset<EmployeeData> CreateEmployeeData(FlatBufferBuilder builder, int seat = 0, int idx = 0, int viewidx = 0)
		{
			builder.StartTable(3);
			AddViewidx(builder, viewidx);
			AddIdx(builder, idx);
			AddSeat(builder, seat);
			return EndEmployeeData(builder);
		}

		public static void StartEmployeeData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddSeat(FlatBufferBuilder builder, int seat)
		{
			builder.AddInt(0, seat, 0);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(1, idx, 0);
		}

		public static void AddViewidx(FlatBufferBuilder builder, int viewidx)
		{
			builder.AddInt(2, viewidx, 0);
		}

		public static Offset<EmployeeData> EndEmployeeData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<EmployeeData>(o);
		}

		public EmployeeDataT UnPack()
		{
			var _o = new EmployeeDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(EmployeeDataT _o)
		{
			_o.Seat = this.Seat;
			_o.Idx = this.Idx;
			_o.Viewidx = this.Viewidx;
		}

		public static Offset<EmployeeData> Pack(FlatBufferBuilder builder, EmployeeDataT _o)
		{
			if (_o == null) return default(Offset<EmployeeData>);
			StartEmployeeData(builder);
			AddSeat(builder, _o.Seat);
			AddIdx(builder, _o.Idx);
			AddViewidx(builder, _o.Viewidx);
			return EndEmployeeData(builder);
		}
	}
}
