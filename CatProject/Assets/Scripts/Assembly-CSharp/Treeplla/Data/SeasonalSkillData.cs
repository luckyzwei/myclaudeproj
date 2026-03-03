using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalSkillData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Abilitytype => 0;

		public int Level => 0;

		public int Orderindex => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalSkillData GetRootAsSeasonalSkillData(ByteBuffer _bb)
		{
			return default(SeasonalSkillData);
		}

		public static SeasonalSkillData GetRootAsSeasonalSkillData(ByteBuffer _bb, SeasonalSkillData obj)
		{
			return default(SeasonalSkillData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalSkillData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalSkillData);
		}

		public bool MutateAbilitytype(int abilitytype)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateOrderindex(int orderindex)
		{
			return false;
		}

		public static Offset<SeasonalSkillData> CreateSeasonalSkillData(FlatBufferBuilder builder, int abilitytype = 0, int level = 0, int orderindex = 0)
		{
			return default(Offset<SeasonalSkillData>);
		}

		public static void StartSeasonalSkillData(FlatBufferBuilder builder)
		{
		}

		public static void AddAbilitytype(FlatBufferBuilder builder, int abilitytype)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddOrderindex(FlatBufferBuilder builder, int orderindex)
		{
		}

		public static Offset<SeasonalSkillData> EndSeasonalSkillData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalSkillData>);
		}

		public SeasonalSkillDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalSkillDataT _o)
		{
		}

		public static Offset<SeasonalSkillData> Pack(FlatBufferBuilder builder, SeasonalSkillDataT _o)
		{
			return default(Offset<SeasonalSkillData>);
		}
	}
}
