using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SlotData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Openslot { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public float Cooltime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0f; } }

		public int Buffvalue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SlotData GetRootAsSlotData(ByteBuffer _bb)
		{
			return GetRootAsSlotData(_bb, new SlotData());
		}

		public static SlotData GetRootAsSlotData(ByteBuffer _bb, SlotData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SlotData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIndex(int index)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, index);
				return true;
			}
			return false;
		}

		public bool MutateOpenslot(int openslot)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, openslot);
				return true;
			}
			return false;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public bool MutateCooltime(float cooltime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutFloat(o + __p.bb_pos, cooltime);
				return true;
			}
			return false;
		}

		public bool MutateBuffvalue(int buffvalue)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, buffvalue);
				return true;
			}
			return false;
		}

		public static Offset<SlotData> CreateSlotData(FlatBufferBuilder builder, int index = -1, int openslot = 0, int level = 1, float cooltime = 0f, int buffvalue = 1)
		{
			builder.StartTable(5);
			AddBuffvalue(builder, buffvalue);
			AddCooltime(builder, cooltime);
			AddLevel(builder, level);
			AddOpenslot(builder, openslot);
			AddIndex(builder, index);
			return EndSlotData(builder);
		}

		public static void StartSlotData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		public static void AddOpenslot(FlatBufferBuilder builder, int openslot)
		{
			builder.AddInt(1, openslot, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(2, level, 0);
		}

		public static void AddCooltime(FlatBufferBuilder builder, float cooltime)
		{
			builder.AddFloat(3, cooltime, 0f);
		}

		public static void AddBuffvalue(FlatBufferBuilder builder, int buffvalue)
		{
			builder.AddInt(4, buffvalue, 0);
		}

		public static Offset<SlotData> EndSlotData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SlotData>(o);
		}

		public SlotDataT UnPack()
		{
			var _o = new SlotDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SlotDataT _o)
		{
			_o.Index = this.Index;
			_o.Openslot = this.Openslot;
			_o.Level = this.Level;
			_o.Cooltime = this.Cooltime;
			_o.Buffvalue = this.Buffvalue;
		}

		public static Offset<SlotData> Pack(FlatBufferBuilder builder, SlotDataT _o)
		{
			if (_o == null) return default(Offset<SlotData>);
			StartSlotData(builder);
			AddIndex(builder, _o.Index);
			AddOpenslot(builder, _o.Openslot);
			AddLevel(builder, _o.Level);
			AddCooltime(builder, _o.Cooltime);
			AddBuffvalue(builder, _o.Buffvalue);
			return EndSlotData(builder);
		}
	}
}
