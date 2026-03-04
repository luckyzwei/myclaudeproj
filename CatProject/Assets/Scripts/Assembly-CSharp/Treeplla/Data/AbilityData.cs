using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AbilityData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static AbilityData GetRootAsAbilityData(ByteBuffer _bb)
		{
			return GetRootAsAbilityData(_bb, new AbilityData());
		}

		public static AbilityData GetRootAsAbilityData(ByteBuffer _bb, AbilityData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public AbilityData __assign(int _i, ByteBuffer _bb)
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

		public static Offset<AbilityData> CreateAbilityData(FlatBufferBuilder builder, int index = -1, int level = 0)
		{
			builder.StartTable(2);
			AddLevel(builder, level);
			AddIndex(builder, index);
			return EndAbilityData(builder);
		}

		public static void StartAbilityData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static Offset<AbilityData> EndAbilityData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<AbilityData>(o);
		}

		public AbilityDataT UnPack()
		{
			var _o = new AbilityDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(AbilityDataT _o)
		{
			_o.Index = this.Index;
			_o.Level = this.Level;
		}

		public static Offset<AbilityData> Pack(FlatBufferBuilder builder, AbilityDataT _o)
		{
			if (_o == null) return default(Offset<AbilityData>);
			StartAbilityData(builder);
			AddIndex(builder, _o.Index);
			AddLevel(builder, _o.Level);
			return EndAbilityData(builder);
		}
	}
}
