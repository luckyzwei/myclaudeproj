using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AttendanceEventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Eventidx => 0;

		public int Eventtype => 0;

		public int AttendancedataLength => 0;

		public long Lastshowntime => 0L;

		public static void ValidateVersion()
		{
		}

		public static AttendanceEventData GetRootAsAttendanceEventData(ByteBuffer _bb)
		{
			return default(AttendanceEventData);
		}

		public static AttendanceEventData GetRootAsAttendanceEventData(ByteBuffer _bb, AttendanceEventData obj)
		{
			return default(AttendanceEventData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AttendanceEventData __assign(int _i, ByteBuffer _bb)
		{
			return default(AttendanceEventData);
		}

		public bool MutateEventidx(int eventidx)
		{
			return false;
		}

		public bool MutateEventtype(int eventtype)
		{
			return false;
		}

		public AttendanceData? Attendancedata(int j)
		{
			return null;
		}

		public bool MutateLastshowntime(long lastshowntime)
		{
			return false;
		}

		public static Offset<AttendanceEventData> CreateAttendanceEventData(FlatBufferBuilder builder, int eventidx = 0, int eventtype = 0, VectorOffset attendancedataOffset = default(VectorOffset), long lastshowntime = 0L)
		{
			return default(Offset<AttendanceEventData>);
		}

		public static void StartAttendanceEventData(FlatBufferBuilder builder)
		{
		}

		public static void AddEventidx(FlatBufferBuilder builder, int eventidx)
		{
		}

		public static void AddEventtype(FlatBufferBuilder builder, int eventtype)
		{
		}

		public static void AddAttendancedata(FlatBufferBuilder builder, VectorOffset attendancedataOffset)
		{
		}

		public static VectorOffset CreateAttendancedataVector(FlatBufferBuilder builder, Offset<AttendanceData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAttendancedataVectorBlock(FlatBufferBuilder builder, Offset<AttendanceData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAttendancedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<AttendanceData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAttendancedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartAttendancedataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddLastshowntime(FlatBufferBuilder builder, long lastshowntime)
		{
		}

		public static Offset<AttendanceEventData> EndAttendanceEventData(FlatBufferBuilder builder)
		{
			return default(Offset<AttendanceEventData>);
		}

		public AttendanceEventDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(AttendanceEventDataT _o)
		{
		}

		public static Offset<AttendanceEventData> Pack(FlatBufferBuilder builder, AttendanceEventDataT _o)
		{
			return default(Offset<AttendanceEventData>);
		}
	}
}
