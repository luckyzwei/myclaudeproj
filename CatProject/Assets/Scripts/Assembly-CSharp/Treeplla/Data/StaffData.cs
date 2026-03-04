using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct StaffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Type { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Count { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public float Speed { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0f; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static StaffData GetRootAsStaffData(ByteBuffer _bb)
		{
			return GetRootAsStaffData(_bb, new StaffData());
		}

		public static StaffData GetRootAsStaffData(ByteBuffer _bb, StaffData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public StaffData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateSpeed(float speed)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutFloat(o + __p.bb_pos, speed);
				return true;
			}
			return false;
		}

		public static Offset<StaffData> CreateStaffData(FlatBufferBuilder builder, int type = 0, int count = 0, float speed = 1f)
		{
			builder.StartTable(3);
			AddSpeed(builder, speed);
			AddCount(builder, count);
			AddType(builder, type);
			return EndStaffData(builder);
		}

		public static void StartStaffData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddType(FlatBufferBuilder builder, int type)
		{
			builder.AddInt(0, type, 0);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
			builder.AddFloat(2, speed, 0f);
		}

		public static Offset<StaffData> EndStaffData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<StaffData>(o);
		}

		public StaffDataT UnPack()
		{
			var _o = new StaffDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(StaffDataT _o)
		{
			_o.Type = this.Type;
			_o.Count = this.Count;
			_o.Speed = this.Speed;
		}

		public static Offset<StaffData> Pack(FlatBufferBuilder builder, StaffDataT _o)
		{
			if (_o == null) return default(Offset<StaffData>);
			StartStaffData(builder);
			AddType(builder, _o.Type);
			AddCount(builder, _o.Count);
			AddSpeed(builder, _o.Speed);
			return EndStaffData(builder);
		}
	}
}
