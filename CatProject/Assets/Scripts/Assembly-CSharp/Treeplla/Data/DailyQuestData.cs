using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct DailyQuestData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Daypoint => 0;

		public int Weekpoint => 0;

		public long Dayresettime => 0L;

		public long Weekresettime => 0L;

		public int CompletequestLength => 0;

		public int GetrewardsLength => 0;

		public int GetweekrewardsLength => 0;

		public int GetweekreplacesLength => 0;

		public int QuestsLength => 0;

		public static void ValidateVersion()
		{
		}

		public static DailyQuestData GetRootAsDailyQuestData(ByteBuffer _bb)
		{
			return default(DailyQuestData);
		}

		public static DailyQuestData GetRootAsDailyQuestData(ByteBuffer _bb, DailyQuestData obj)
		{
			return default(DailyQuestData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public DailyQuestData __assign(int _i, ByteBuffer _bb)
		{
			return default(DailyQuestData);
		}

		public bool MutateDaypoint(int daypoint)
		{
			return false;
		}

		public bool MutateWeekpoint(int weekpoint)
		{
			return false;
		}

		public bool MutateDayresettime(long dayresettime)
		{
			return false;
		}

		public bool MutateWeekresettime(long weekresettime)
		{
			return false;
		}

		public int Completequest(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetCompletequestBytes()
		{
			return null;
		}

		public int[] GetCompletequestArray()
		{
			return null;
		}

		public bool MutateCompletequest(int j, int completequest)
		{
			return false;
		}

		public int Getrewards(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetGetrewardsBytes()
		{
			return null;
		}

		public int[] GetGetrewardsArray()
		{
			return null;
		}

		public bool MutateGetrewards(int j, int getrewards)
		{
			return false;
		}

		public int Getweekrewards(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetGetweekrewardsBytes()
		{
			return null;
		}

		public int[] GetGetweekrewardsArray()
		{
			return null;
		}

		public bool MutateGetweekrewards(int j, int getweekrewards)
		{
			return false;
		}

		public int Getweekreplaces(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetGetweekreplacesBytes()
		{
			return null;
		}

		public int[] GetGetweekreplacesArray()
		{
			return null;
		}

		public bool MutateGetweekreplaces(int j, int getweekreplaces)
		{
			return false;
		}

		public KeyValueLong? Quests(int j)
		{
			return null;
		}

		public static Offset<DailyQuestData> CreateDailyQuestData(FlatBufferBuilder builder, int daypoint = 0, int weekpoint = 0, long dayresettime = 0L, long weekresettime = 0L, VectorOffset completequestOffset = default(VectorOffset), VectorOffset getrewardsOffset = default(VectorOffset), VectorOffset getweekrewardsOffset = default(VectorOffset), VectorOffset getweekreplacesOffset = default(VectorOffset), VectorOffset questsOffset = default(VectorOffset))
		{
			return default(Offset<DailyQuestData>);
		}

		public static void StartDailyQuestData(FlatBufferBuilder builder)
		{
		}

		public static void AddDaypoint(FlatBufferBuilder builder, int daypoint)
		{
		}

		public static void AddWeekpoint(FlatBufferBuilder builder, int weekpoint)
		{
		}

		public static void AddDayresettime(FlatBufferBuilder builder, long dayresettime)
		{
		}

		public static void AddWeekresettime(FlatBufferBuilder builder, long weekresettime)
		{
		}

		public static void AddCompletequest(FlatBufferBuilder builder, VectorOffset completequestOffset)
		{
		}

		public static VectorOffset CreateCompletequestVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompletequestVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompletequestVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompletequestVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCompletequestVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddGetrewards(FlatBufferBuilder builder, VectorOffset getrewardsOffset)
		{
		}

		public static VectorOffset CreateGetrewardsVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartGetrewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddGetweekrewards(FlatBufferBuilder builder, VectorOffset getweekrewardsOffset)
		{
		}

		public static VectorOffset CreateGetweekrewardsVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetweekrewardsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetweekrewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetweekrewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartGetweekrewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddGetweekreplaces(FlatBufferBuilder builder, VectorOffset getweekreplacesOffset)
		{
		}

		public static VectorOffset CreateGetweekreplacesVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetweekreplacesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetweekreplacesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateGetweekreplacesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartGetweekreplacesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddQuests(FlatBufferBuilder builder, VectorOffset questsOffset)
		{
		}

		public static VectorOffset CreateQuestsVector(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValueLong>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartQuestsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<DailyQuestData> EndDailyQuestData(FlatBufferBuilder builder)
		{
			return default(Offset<DailyQuestData>);
		}

		public DailyQuestDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(DailyQuestDataT _o)
		{
		}

		public static Offset<DailyQuestData> Pack(FlatBufferBuilder builder, DailyQuestDataT _o)
		{
			return default(Offset<DailyQuestData>);
		}
	}
}
