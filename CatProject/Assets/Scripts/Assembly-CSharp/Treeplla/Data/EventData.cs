using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public static void ValidateVersion()
		{
		}

		public static EventData GetRootAsEventData(ByteBuffer _bb)
		{
			return default(EventData);
		}

		public static EventData GetRootAsEventData(ByteBuffer _bb, EventData obj)
		{
			return default(EventData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public EventData __assign(int _i, ByteBuffer _bb)
		{
			return default(EventData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public static Offset<EventData> CreateEventData(FlatBufferBuilder builder, int idx = 0)
		{
			return default(Offset<EventData>);
		}

		public static void StartEventData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static Offset<EventData> EndEventData(FlatBufferBuilder builder)
		{
			return default(Offset<EventData>);
		}

		public EventDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(EventDataT _o)
		{
		}

		public static Offset<EventData> Pack(FlatBufferBuilder builder, EventDataT _o)
		{
			return default(Offset<EventData>);
		}
	}
}
