using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct UnitData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Count { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static UnitData GetRootAsUnitData(ByteBuffer _bb)
		{
			return GetRootAsUnitData(_bb, new UnitData());
		}

		public static UnitData GetRootAsUnitData(ByteBuffer _bb, UnitData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public UnitData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
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

		public static Offset<UnitData> CreateUnitData(FlatBufferBuilder builder, int level = 0, int count = 0)
		{
			builder.StartTable(2);
			AddCount(builder, count);
			AddLevel(builder, level);
			return EndUnitData(builder);
		}

		public static void StartUnitData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(0, level, 0);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(1, count, 0);
		}

		public static Offset<UnitData> EndUnitData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<UnitData>(o);
		}

		public UnitDataT UnPack()
		{
			var _o = new UnitDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(UnitDataT _o)
		{
			_o.Level = this.Level;
			_o.Count = this.Count;
		}

		public static Offset<UnitData> Pack(FlatBufferBuilder builder, UnitDataT _o)
		{
			if (_o == null) return default(Offset<UnitData>);
			StartUnitData(builder);
			AddLevel(builder, _o.Level);
			AddCount(builder, _o.Count);
			return EndUnitData(builder);
		}
	}
}
