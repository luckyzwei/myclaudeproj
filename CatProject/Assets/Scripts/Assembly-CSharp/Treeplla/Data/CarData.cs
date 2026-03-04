using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CarData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Parkingidx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Parkingzone { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static CarData GetRootAsCarData(ByteBuffer _bb)
		{
			return GetRootAsCarData(_bb, new CarData());
		}

		public static CarData GetRootAsCarData(ByteBuffer _bb, CarData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public CarData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateParkingidx(int parkingidx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, parkingidx);
				return true;
			}
			return false;
		}

		public bool MutateParkingzone(int parkingzone)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, parkingzone);
				return true;
			}
			return false;
		}

		public static Offset<CarData> CreateCarData(FlatBufferBuilder builder, int idx = 0, int parkingidx = 0, int parkingzone = -1)
		{
			builder.StartTable(3);
			AddParkingzone(builder, parkingzone);
			AddParkingidx(builder, parkingidx);
			AddIdx(builder, idx);
			return EndCarData(builder);
		}

		public static void StartCarData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddParkingidx(FlatBufferBuilder builder, int parkingidx)
		{
			builder.AddInt(1, parkingidx, 0);
		}

		public static void AddParkingzone(FlatBufferBuilder builder, int parkingzone)
		{
			builder.AddInt(2, parkingzone, 0);
		}

		public static Offset<CarData> EndCarData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<CarData>(o);
		}

		public CarDataT UnPack()
		{
			var _o = new CarDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(CarDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Parkingidx = this.Parkingidx;
			_o.Parkingzone = this.Parkingzone;
		}

		public static Offset<CarData> Pack(FlatBufferBuilder builder, CarDataT _o)
		{
			if (_o == null) return default(Offset<CarData>);
			StartCarData(builder);
			AddIdx(builder, _o.Idx);
			AddParkingidx(builder, _o.Parkingidx);
			AddParkingzone(builder, _o.Parkingzone);
			return EndCarData(builder);
		}
	}
}
