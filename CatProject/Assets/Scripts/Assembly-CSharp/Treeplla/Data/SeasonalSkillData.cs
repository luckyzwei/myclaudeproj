using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalSkillData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Abilitytype { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Orderindex { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalSkillData GetRootAsSeasonalSkillData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalSkillData(_bb, new SeasonalSkillData());
		}

		public static SeasonalSkillData GetRootAsSeasonalSkillData(ByteBuffer _bb, SeasonalSkillData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalSkillData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateAbilitytype(int abilitytype)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, abilitytype);
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

		public bool MutateOrderindex(int orderindex)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, orderindex);
				return true;
			}
			return false;
		}

		public static Offset<SeasonalSkillData> CreateSeasonalSkillData(FlatBufferBuilder builder, int abilitytype = 0, int level = 0, int orderindex = 0)
		{
			builder.StartTable(3);
			AddOrderindex(builder, orderindex);
			AddLevel(builder, level);
			AddAbilitytype(builder, abilitytype);
			return EndSeasonalSkillData(builder);
		}

		public static void StartSeasonalSkillData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddAbilitytype(FlatBufferBuilder builder, int abilitytype)
		{
			builder.AddInt(0, abilitytype, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static void AddOrderindex(FlatBufferBuilder builder, int orderindex)
		{
			builder.AddInt(2, orderindex, 0);
		}

		public static Offset<SeasonalSkillData> EndSeasonalSkillData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalSkillData>(o);
		}

		public SeasonalSkillDataT UnPack()
		{
			var _o = new SeasonalSkillDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalSkillDataT _o)
		{
			_o.Abilitytype = this.Abilitytype;
			_o.Level = this.Level;
			_o.Orderindex = this.Orderindex;
		}

		public static Offset<SeasonalSkillData> Pack(FlatBufferBuilder builder, SeasonalSkillDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalSkillData>);
			StartSeasonalSkillData(builder);
			AddAbilitytype(builder, _o.Abilitytype);
			AddLevel(builder, _o.Level);
			AddOrderindex(builder, _o.Orderindex);
			return EndSeasonalSkillData(builder);
		}
	}
}
