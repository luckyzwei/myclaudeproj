using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalWorkerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Workeridx => 0;

		public int Assignedbuildingidx => 0;

		public int Assignedbuildingtransformidx => 0;

		public int Mood => 0;

		public long Lastuserestauranttime => 0L;

		public static void ValidateVersion()
		{
		}

		public static SeasonalWorkerData GetRootAsSeasonalWorkerData(ByteBuffer _bb)
		{
			return default(SeasonalWorkerData);
		}

		public static SeasonalWorkerData GetRootAsSeasonalWorkerData(ByteBuffer _bb, SeasonalWorkerData obj)
		{
			return default(SeasonalWorkerData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalWorkerData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalWorkerData);
		}

		public bool MutateWorkeridx(int workeridx)
		{
			return false;
		}

		public bool MutateAssignedbuildingidx(int assignedbuildingidx)
		{
			return false;
		}

		public bool MutateAssignedbuildingtransformidx(int assignedbuildingtransformidx)
		{
			return false;
		}

		public bool MutateMood(int mood)
		{
			return false;
		}

		public bool MutateLastuserestauranttime(long lastuserestauranttime)
		{
			return false;
		}

		public static Offset<SeasonalWorkerData> CreateSeasonalWorkerData(FlatBufferBuilder builder, int workeridx = 0, int assignedbuildingidx = 0, int assignedbuildingtransformidx = 0, int mood = 0, long lastuserestauranttime = 0L)
		{
			return default(Offset<SeasonalWorkerData>);
		}

		public static void StartSeasonalWorkerData(FlatBufferBuilder builder)
		{
		}

		public static void AddWorkeridx(FlatBufferBuilder builder, int workeridx)
		{
		}

		public static void AddAssignedbuildingidx(FlatBufferBuilder builder, int assignedbuildingidx)
		{
		}

		public static void AddAssignedbuildingtransformidx(FlatBufferBuilder builder, int assignedbuildingtransformidx)
		{
		}

		public static void AddMood(FlatBufferBuilder builder, int mood)
		{
		}

		public static void AddLastuserestauranttime(FlatBufferBuilder builder, long lastuserestauranttime)
		{
		}

		public static Offset<SeasonalWorkerData> EndSeasonalWorkerData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalWorkerData>);
		}

		public SeasonalWorkerDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalWorkerDataT _o)
		{
		}

		public static Offset<SeasonalWorkerData> Pack(FlatBufferBuilder builder, SeasonalWorkerDataT _o)
		{
			return default(Offset<SeasonalWorkerData>);
		}
	}
}
