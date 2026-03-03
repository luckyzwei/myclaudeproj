using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalBuildingWorkerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Facilityidx => 0;

		public int Hiredcount => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalBuildingWorkerData GetRootAsSeasonalBuildingWorkerData(ByteBuffer _bb)
		{
			return default(SeasonalBuildingWorkerData);
		}

		public static SeasonalBuildingWorkerData GetRootAsSeasonalBuildingWorkerData(ByteBuffer _bb, SeasonalBuildingWorkerData obj)
		{
			return default(SeasonalBuildingWorkerData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalBuildingWorkerData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalBuildingWorkerData);
		}

		public bool MutateFacilityidx(int facilityidx)
		{
			return false;
		}

		public bool MutateHiredcount(int hiredcount)
		{
			return false;
		}

		public static Offset<SeasonalBuildingWorkerData> CreateSeasonalBuildingWorkerData(FlatBufferBuilder builder, int facilityidx = 0, int hiredcount = 0)
		{
			return default(Offset<SeasonalBuildingWorkerData>);
		}

		public static void StartSeasonalBuildingWorkerData(FlatBufferBuilder builder)
		{
		}

		public static void AddFacilityidx(FlatBufferBuilder builder, int facilityidx)
		{
		}

		public static void AddHiredcount(FlatBufferBuilder builder, int hiredcount)
		{
		}

		public static Offset<SeasonalBuildingWorkerData> EndSeasonalBuildingWorkerData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalBuildingWorkerData>);
		}

		public SeasonalBuildingWorkerDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalBuildingWorkerDataT _o)
		{
		}

		public static Offset<SeasonalBuildingWorkerData> Pack(FlatBufferBuilder builder, SeasonalBuildingWorkerDataT _o)
		{
			return default(Offset<SeasonalBuildingWorkerData>);
		}
	}
}
