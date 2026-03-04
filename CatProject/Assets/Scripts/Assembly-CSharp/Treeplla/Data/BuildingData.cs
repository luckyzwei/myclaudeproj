using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BuildingData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Lv { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Value { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public int Time { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BuildingData GetRootAsBuildingData(ByteBuffer _bb)
		{
			return GetRootAsBuildingData(_bb, new BuildingData());
		}

		public static BuildingData GetRootAsBuildingData(ByteBuffer _bb, BuildingData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BuildingData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIdx(int idx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, idx);
				return true;
			}
			return false;
		}

		public bool MutateLv(int lv)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, lv);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetValueBytes()
		{
			return __p.__vector_as_arraysegment(8);
		}

		public byte[] GetValueArray()
		{
			return __p.__vector_as_array<byte>(8);
		}

		public bool MutateTime(int time)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, time);
				return true;
			}
			return false;
		}

		public static Offset<BuildingData> CreateBuildingData(FlatBufferBuilder builder, int idx = 0, int lv = 0, StringOffset valueOffset = default(StringOffset), int time = 0)
		{
			builder.StartTable(4);
			AddTime(builder, time);
			AddValue(builder, valueOffset);
			AddLv(builder, lv);
			AddIdx(builder, idx);
			return EndBuildingData(builder);
		}

		public static void StartBuildingData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddLv(FlatBufferBuilder builder, int lv)
		{
			builder.AddInt(1, lv, 0);
		}

		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(2, valueOffset.Value, 0);
		}

		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(3, time, 0);
		}

		public static Offset<BuildingData> EndBuildingData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BuildingData>(o);
		}

		public BuildingDataT UnPack()
		{
			var _o = new BuildingDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BuildingDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Lv = this.Lv;
			_o.Value = this.Value;
			_o.Time = this.Time;
		}

		public static Offset<BuildingData> Pack(FlatBufferBuilder builder, BuildingDataT _o)
		{
			if (_o == null) return default(Offset<BuildingData>);
			var _value = _o.Value == null ? default(StringOffset) : builder.CreateString(_o.Value);
			StartBuildingData(builder);
			AddIdx(builder, _o.Idx);
			AddLv(builder, _o.Lv);
			AddValue(builder, _value);
			AddTime(builder, _o.Time);
			return EndBuildingData(builder);
		}
	}
}
