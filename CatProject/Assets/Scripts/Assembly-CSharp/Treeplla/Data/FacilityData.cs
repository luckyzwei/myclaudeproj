using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FacilityData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Index => 0;

		public int Level => 0;

		public int Speedlevel => 0;

		public static void ValidateVersion()
		{
		}

		public static FacilityData GetRootAsFacilityData(ByteBuffer _bb)
		{
			return default(FacilityData);
		}

		public static FacilityData GetRootAsFacilityData(ByteBuffer _bb, FacilityData obj)
		{
			return default(FacilityData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public FacilityData __assign(int _i, ByteBuffer _bb)
		{
			return default(FacilityData);
		}

		public bool MutateIndex(int index)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateSpeedlevel(int speedlevel)
		{
			return false;
		}

		public static Offset<FacilityData> CreateFacilityData(FlatBufferBuilder builder, int index = 0, int level = 0, int speedlevel = 0)
		{
			return default(Offset<FacilityData>);
		}

		public static void StartFacilityData(FlatBufferBuilder builder)
		{
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddSpeedlevel(FlatBufferBuilder builder, int speedlevel)
		{
		}

		public static Offset<FacilityData> EndFacilityData(FlatBufferBuilder builder)
		{
			return default(Offset<FacilityData>);
		}

		public FacilityDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(FacilityDataT _o)
		{
		}

		public static Offset<FacilityData> Pack(FlatBufferBuilder builder, FacilityDataT _o)
		{
			return default(Offset<FacilityData>);
		}
	}
}
