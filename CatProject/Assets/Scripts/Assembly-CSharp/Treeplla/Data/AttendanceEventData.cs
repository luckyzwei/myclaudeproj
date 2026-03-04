using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AttendanceEventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Eventidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Eventtype { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int AttendancedataLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Lastshowntime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static AttendanceEventData GetRootAsAttendanceEventData(ByteBuffer _bb)
		{
			return GetRootAsAttendanceEventData(_bb, new AttendanceEventData());
		}

		public static AttendanceEventData GetRootAsAttendanceEventData(ByteBuffer _bb, AttendanceEventData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public AttendanceEventData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateEventidx(int eventidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, eventidx);
				return true;
			}
			return false;
		}

		public bool MutateEventtype(int eventtype)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, eventtype);
				return true;
			}
			return false;
		}

		public AttendanceData? Attendancedata(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new AttendanceData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateLastshowntime(long lastshowntime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastshowntime);
				return true;
			}
			return false;
		}

		public static Offset<AttendanceEventData> CreateAttendanceEventData(FlatBufferBuilder builder, int eventidx = 0, int eventtype = 0, VectorOffset attendancedataOffset = default(VectorOffset), long lastshowntime = 0L)
		{
			builder.StartTable(4);
			AddLastshowntime(builder, lastshowntime);
			AddAttendancedata(builder, attendancedataOffset);
			AddEventtype(builder, eventtype);
			AddEventidx(builder, eventidx);
			return EndAttendanceEventData(builder);
		}

		public static void StartAttendanceEventData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddEventidx(FlatBufferBuilder builder, int eventidx)
		{
			builder.AddInt(0, eventidx, 0);
		}

		public static void AddEventtype(FlatBufferBuilder builder, int eventtype)
		{
			builder.AddInt(1, eventtype, 0);
		}

		public static void AddAttendancedata(FlatBufferBuilder builder, VectorOffset attendancedataOffset)
		{
			builder.AddOffset(2, attendancedataOffset.Value, 0);
		}

		public static VectorOffset CreateAttendancedataVector(FlatBufferBuilder builder, Offset<AttendanceData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateAttendancedataVectorBlock(FlatBufferBuilder builder, Offset<AttendanceData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAttendancedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<AttendanceData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateAttendancedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartAttendancedataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddLastshowntime(FlatBufferBuilder builder, long lastshowntime)
		{
			builder.AddLong(3, lastshowntime, 0);
		}

		public static Offset<AttendanceEventData> EndAttendanceEventData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<AttendanceEventData>(o);
		}

		public AttendanceEventDataT UnPack()
		{
			var _o = new AttendanceEventDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(AttendanceEventDataT _o)
		{
			_o.Eventidx = this.Eventidx;
			_o.Eventtype = this.Eventtype;
			_o.Attendancedata = new List<AttendanceDataT>();
			for (var _j = 0; _j < this.AttendancedataLength; ++_j)
				_o.Attendancedata.Add(this.Attendancedata(_j).HasValue ? this.Attendancedata(_j).Value.UnPack() : null);
			_o.Lastshowntime = this.Lastshowntime;
		}

		public static Offset<AttendanceEventData> Pack(FlatBufferBuilder builder, AttendanceEventDataT _o)
		{
			if (_o == null) return default(Offset<AttendanceEventData>);
			var _attendancedata = default(VectorOffset);
			if (_o.Attendancedata != null)
			{
				var __attendancedata = new Offset<AttendanceData>[_o.Attendancedata.Count];
				for (var _j = 0; _j < _o.Attendancedata.Count; ++_j)
					__attendancedata[_j] = AttendanceData.Pack(builder, _o.Attendancedata[_j]);
				_attendancedata = CreateAttendancedataVector(builder, __attendancedata);
			}
			StartAttendanceEventData(builder);
			AddEventidx(builder, _o.Eventidx);
			AddEventtype(builder, _o.Eventtype);
			AddAttendancedata(builder, _attendancedata);
			AddLastshowntime(builder, _o.Lastshowntime);
			return EndAttendanceEventData(builder);
		}
	}
}
