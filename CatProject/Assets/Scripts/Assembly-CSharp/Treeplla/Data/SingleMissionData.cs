using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SingleMissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Slotidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Missionidx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Currentvalue { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public bool Iscomplete { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Isrewarded { get { int o = __p.__offset(12); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SingleMissionData GetRootAsSingleMissionData(ByteBuffer _bb)
		{
			return GetRootAsSingleMissionData(_bb, new SingleMissionData());
		}

		public static SingleMissionData GetRootAsSingleMissionData(ByteBuffer _bb, SingleMissionData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SingleMissionData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSlotidx(int slotidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, slotidx);
				return true;
			}
			return false;
		}

		public bool MutateMissionidx(int missionidx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, missionidx);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetCurrentvalueBytes()
		{
			return __p.__vector_as_arraysegment(8);
		}

		public byte[] GetCurrentvalueArray()
		{
			return __p.__vector_as_array<byte>(8);
		}

		public bool MutateIscomplete(bool iscomplete)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(iscomplete ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateIsrewarded(bool isrewarded)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isrewarded ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<SingleMissionData> CreateSingleMissionData(FlatBufferBuilder builder, int slotidx = 0, int missionidx = 0, StringOffset currentvalueOffset = default(StringOffset), bool iscomplete = false, bool isrewarded = false)
		{
			builder.StartTable(5);
			AddIsrewarded(builder, isrewarded);
			AddIscomplete(builder, iscomplete);
			AddCurrentvalue(builder, currentvalueOffset);
			AddMissionidx(builder, missionidx);
			AddSlotidx(builder, slotidx);
			return EndSingleMissionData(builder);
		}

		public static void StartSingleMissionData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddSlotidx(FlatBufferBuilder builder, int slotidx)
		{
			builder.AddInt(0, slotidx, 0);
		}

		public static void AddMissionidx(FlatBufferBuilder builder, int missionidx)
		{
			builder.AddInt(1, missionidx, 0);
		}

		public static void AddCurrentvalue(FlatBufferBuilder builder, StringOffset currentvalueOffset)
		{
			builder.AddOffset(2, currentvalueOffset.Value, 0);
		}

		public static void AddIscomplete(FlatBufferBuilder builder, bool iscomplete)
		{
			builder.AddBool(3, iscomplete, false);
		}

		public static void AddIsrewarded(FlatBufferBuilder builder, bool isrewarded)
		{
			builder.AddBool(4, isrewarded, false);
		}

		public static Offset<SingleMissionData> EndSingleMissionData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SingleMissionData>(o);
		}

		public SingleMissionDataT UnPack()
		{
			var _o = new SingleMissionDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SingleMissionDataT _o)
		{
			_o.Slotidx = this.Slotidx;
			_o.Missionidx = this.Missionidx;
			_o.Currentvalue = this.Currentvalue;
			_o.Iscomplete = this.Iscomplete;
			_o.Isrewarded = this.Isrewarded;
		}

		public static Offset<SingleMissionData> Pack(FlatBufferBuilder builder, SingleMissionDataT _o)
		{
			if (_o == null) return default(Offset<SingleMissionData>);
			var _currentvalue = _o.Currentvalue == null ? default(StringOffset) : builder.CreateString(_o.Currentvalue);
			StartSingleMissionData(builder);
			AddSlotidx(builder, _o.Slotidx);
			AddMissionidx(builder, _o.Missionidx);
			AddCurrentvalue(builder, _currentvalue);
			AddIscomplete(builder, _o.Iscomplete);
			AddIsrewarded(builder, _o.Isrewarded);
			return EndSingleMissionData(builder);
		}
	}
}
