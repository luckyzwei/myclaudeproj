using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FactoryBuilding : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Makeproduct { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Opencompletetime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Batteryuseendtime { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Usebattery { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static FactoryBuilding GetRootAsFactoryBuilding(ByteBuffer _bb)
		{
			return GetRootAsFactoryBuilding(_bb, new FactoryBuilding());
		}

		public static FactoryBuilding GetRootAsFactoryBuilding(ByteBuffer _bb, FactoryBuilding obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public FactoryBuilding __assign(int _i, ByteBuffer _bb)
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

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public bool MutateMakeproduct(int makeproduct)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, makeproduct);
				return true;
			}
			return false;
		}

		public bool MutateOpencompletetime(long opencompletetime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, opencompletetime);
				return true;
			}
			return false;
		}

		public bool MutateBatteryuseendtime(long batteryuseendtime)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, batteryuseendtime);
				return true;
			}
			return false;
		}

		public bool MutateUsebattery(int usebattery)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, usebattery);
				return true;
			}
			return false;
		}

		public static Offset<FactoryBuilding> CreateFactoryBuilding(FlatBufferBuilder builder, int idx = 0, int level = 0, int makeproduct = 0, long opencompletetime = 0L, long batteryuseendtime = 0L, int usebattery = -1)
		{
			builder.StartTable(6);
			AddUsebattery(builder, usebattery);
			AddBatteryuseendtime(builder, batteryuseendtime);
			AddOpencompletetime(builder, opencompletetime);
			AddMakeproduct(builder, makeproduct);
			AddLevel(builder, level);
			AddIdx(builder, idx);
			return EndFactoryBuilding(builder);
		}

		public static void StartFactoryBuilding(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static void AddMakeproduct(FlatBufferBuilder builder, int makeproduct)
		{
			builder.AddInt(2, makeproduct, 0);
		}

		public static void AddOpencompletetime(FlatBufferBuilder builder, long opencompletetime)
		{
			builder.AddLong(3, opencompletetime, 0);
		}

		public static void AddBatteryuseendtime(FlatBufferBuilder builder, long batteryuseendtime)
		{
			builder.AddLong(4, batteryuseendtime, 0);
		}

		public static void AddUsebattery(FlatBufferBuilder builder, int usebattery)
		{
			builder.AddInt(5, usebattery, 0);
		}

		public static Offset<FactoryBuilding> EndFactoryBuilding(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<FactoryBuilding>(o);
		}

		public FactoryBuildingT UnPack()
		{
			var _o = new FactoryBuildingT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(FactoryBuildingT _o)
		{
			_o.Idx = this.Idx;
			_o.Level = this.Level;
			_o.Makeproduct = this.Makeproduct;
			_o.Opencompletetime = this.Opencompletetime;
			_o.Batteryuseendtime = this.Batteryuseendtime;
			_o.Usebattery = this.Usebattery;
		}

		public static Offset<FactoryBuilding> Pack(FlatBufferBuilder builder, FactoryBuildingT _o)
		{
			if (_o == null) return default(Offset<FactoryBuilding>);
			StartFactoryBuilding(builder);
			AddIdx(builder, _o.Idx);
			AddLevel(builder, _o.Level);
			AddMakeproduct(builder, _o.Makeproduct);
			AddOpencompletetime(builder, _o.Opencompletetime);
			AddBatteryuseendtime(builder, _o.Batteryuseendtime);
			AddUsebattery(builder, _o.Usebattery);
			return EndFactoryBuilding(builder);
		}
	}
}
