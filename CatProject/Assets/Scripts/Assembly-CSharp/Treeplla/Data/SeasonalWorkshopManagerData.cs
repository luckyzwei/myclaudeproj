using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalWorkshopManagerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Manageridx => 0;

		public int Level => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalWorkshopManagerData GetRootAsSeasonalWorkshopManagerData(ByteBuffer _bb)
		{
			return default(SeasonalWorkshopManagerData);
		}

		public static SeasonalWorkshopManagerData GetRootAsSeasonalWorkshopManagerData(ByteBuffer _bb, SeasonalWorkshopManagerData obj)
		{
			return default(SeasonalWorkshopManagerData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalWorkshopManagerData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalWorkshopManagerData);
		}

		public bool MutateManageridx(int manageridx)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public static Offset<SeasonalWorkshopManagerData> CreateSeasonalWorkshopManagerData(FlatBufferBuilder builder, int manageridx = 0, int level = 0)
		{
			return default(Offset<SeasonalWorkshopManagerData>);
		}

		public static void StartSeasonalWorkshopManagerData(FlatBufferBuilder builder)
		{
		}

		public static void AddManageridx(FlatBufferBuilder builder, int manageridx)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static Offset<SeasonalWorkshopManagerData> EndSeasonalWorkshopManagerData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalWorkshopManagerData>);
		}

		public SeasonalWorkshopManagerDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalWorkshopManagerDataT _o)
		{
		}

		public static Offset<SeasonalWorkshopManagerData> Pack(FlatBufferBuilder builder, SeasonalWorkshopManagerDataT _o)
		{
			return default(Offset<SeasonalWorkshopManagerData>);
		}
	}
}
