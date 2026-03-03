using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EventStaffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public long Endtime => 0L;

		public bool Maxrapid => false;

		public static void ValidateVersion()
		{
		}

		public static EventStaffData GetRootAsEventStaffData(ByteBuffer _bb)
		{
			return default(EventStaffData);
		}

		public static EventStaffData GetRootAsEventStaffData(ByteBuffer _bb, EventStaffData obj)
		{
			return default(EventStaffData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public EventStaffData __assign(int _i, ByteBuffer _bb)
		{
			return default(EventStaffData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateEndtime(long endtime)
		{
			return false;
		}

		public bool MutateMaxrapid(bool maxrapid)
		{
			return false;
		}

		public static Offset<EventStaffData> CreateEventStaffData(FlatBufferBuilder builder, int idx = 0, long endtime = 0L, bool maxrapid = false)
		{
			return default(Offset<EventStaffData>);
		}

		public static void StartEventStaffData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
		}

		public static void AddMaxrapid(FlatBufferBuilder builder, bool maxrapid)
		{
		}

		public static Offset<EventStaffData> EndEventStaffData(FlatBufferBuilder builder)
		{
			return default(Offset<EventStaffData>);
		}

		public EventStaffDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(EventStaffDataT _o)
		{
		}

		public static Offset<EventStaffData> Pack(FlatBufferBuilder builder, EventStaffDataT _o)
		{
			return default(Offset<EventStaffData>);
		}
	}
}
