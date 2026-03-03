using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RegionMissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Claimedmilestionecount => 0;

		public static void ValidateVersion()
		{
		}

		public static RegionMissionData GetRootAsRegionMissionData(ByteBuffer _bb)
		{
			return default(RegionMissionData);
		}

		public static RegionMissionData GetRootAsRegionMissionData(ByteBuffer _bb, RegionMissionData obj)
		{
			return default(RegionMissionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public RegionMissionData __assign(int _i, ByteBuffer _bb)
		{
			return default(RegionMissionData);
		}

		public bool MutateClaimedmilestionecount(int claimedmilestionecount)
		{
			return false;
		}

		public static Offset<RegionMissionData> CreateRegionMissionData(FlatBufferBuilder builder, int claimedmilestionecount = -1)
		{
			return default(Offset<RegionMissionData>);
		}

		public static void StartRegionMissionData(FlatBufferBuilder builder)
		{
		}

		public static void AddClaimedmilestionecount(FlatBufferBuilder builder, int claimedmilestionecount)
		{
		}

		public static Offset<RegionMissionData> EndRegionMissionData(FlatBufferBuilder builder)
		{
			return default(Offset<RegionMissionData>);
		}

		public RegionMissionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(RegionMissionDataT _o)
		{
		}

		public static Offset<RegionMissionData> Pack(FlatBufferBuilder builder, RegionMissionDataT _o)
		{
			return default(Offset<RegionMissionData>);
		}
	}
}
