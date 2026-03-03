using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalBuildingFacilityData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Facilityidx => 0;

		public int Level => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalBuildingFacilityData GetRootAsSeasonalBuildingFacilityData(ByteBuffer _bb)
		{
			return default(SeasonalBuildingFacilityData);
		}

		public static SeasonalBuildingFacilityData GetRootAsSeasonalBuildingFacilityData(ByteBuffer _bb, SeasonalBuildingFacilityData obj)
		{
			return default(SeasonalBuildingFacilityData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalBuildingFacilityData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalBuildingFacilityData);
		}

		public bool MutateFacilityidx(int facilityidx)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public static Offset<SeasonalBuildingFacilityData> CreateSeasonalBuildingFacilityData(FlatBufferBuilder builder, int facilityidx = 0, int level = 0)
		{
			return default(Offset<SeasonalBuildingFacilityData>);
		}

		public static void StartSeasonalBuildingFacilityData(FlatBufferBuilder builder)
		{
		}

		public static void AddFacilityidx(FlatBufferBuilder builder, int facilityidx)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static Offset<SeasonalBuildingFacilityData> EndSeasonalBuildingFacilityData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalBuildingFacilityData>);
		}

		public SeasonalBuildingFacilityDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalBuildingFacilityDataT _o)
		{
		}

		public static Offset<SeasonalBuildingFacilityData> Pack(FlatBufferBuilder builder, SeasonalBuildingFacilityDataT _o)
		{
			return default(Offset<SeasonalBuildingFacilityData>);
		}
	}
}
