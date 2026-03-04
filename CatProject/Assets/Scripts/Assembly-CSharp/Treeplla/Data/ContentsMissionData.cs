using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ContentsMissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Contentstype { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Missionsettime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int MissionsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Isrefreshed { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Missiongroupidx { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static ContentsMissionData GetRootAsContentsMissionData(ByteBuffer _bb)
		{
			return GetRootAsContentsMissionData(_bb, new ContentsMissionData());
		}

		public static ContentsMissionData GetRootAsContentsMissionData(ByteBuffer _bb, ContentsMissionData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public ContentsMissionData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateContentstype(int contentstype)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, contentstype);
				return true;
			}
			return false;
		}

		public bool MutateMissionsettime(long missionsettime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, missionsettime);
				return true;
			}
			return false;
		}

		public SingleMissionData? Missions(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new SingleMissionData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateIsrefreshed(bool isrefreshed)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isrefreshed ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateMissiongroupidx(int missiongroupidx)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, missiongroupidx);
				return true;
			}
			return false;
		}

		public static Offset<ContentsMissionData> CreateContentsMissionData(FlatBufferBuilder builder, int contentstype = 0, long missionsettime = 0L, VectorOffset missionsOffset = default(VectorOffset), bool isrefreshed = false, int missiongroupidx = 0)
		{
			builder.StartTable(5);
			AddMissiongroupidx(builder, missiongroupidx);
			AddIsrefreshed(builder, isrefreshed);
			AddMissions(builder, missionsOffset);
			AddMissionsettime(builder, missionsettime);
			AddContentstype(builder, contentstype);
			return EndContentsMissionData(builder);
		}

		public static void StartContentsMissionData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddContentstype(FlatBufferBuilder builder, int contentstype)
		{
			builder.AddInt(0, contentstype, 0);
		}

		public static void AddMissionsettime(FlatBufferBuilder builder, long missionsettime)
		{
			builder.AddLong(1, missionsettime, 0);
		}

		public static void AddMissions(FlatBufferBuilder builder, VectorOffset missionsOffset)
		{
			builder.AddOffset(2, missionsOffset.Value, 0);
		}

		public static VectorOffset CreateMissionsVector(FlatBufferBuilder builder, Offset<SingleMissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, Offset<SingleMissionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SingleMissionData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartMissionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddIsrefreshed(FlatBufferBuilder builder, bool isrefreshed)
		{
			builder.AddBool(3, isrefreshed, false);
		}

		public static void AddMissiongroupidx(FlatBufferBuilder builder, int missiongroupidx)
		{
			builder.AddInt(4, missiongroupidx, 0);
		}

		public static Offset<ContentsMissionData> EndContentsMissionData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<ContentsMissionData>(o);
		}

		public ContentsMissionDataT UnPack()
		{
			var _o = new ContentsMissionDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(ContentsMissionDataT _o)
		{
			_o.Contentstype = this.Contentstype;
			_o.Missionsettime = this.Missionsettime;
			_o.Missions = new List<SingleMissionDataT>();
			for (var _j = 0; _j < this.MissionsLength; ++_j)
				_o.Missions.Add(this.Missions(_j).HasValue ? this.Missions(_j).Value.UnPack() : null);
			_o.Isrefreshed = this.Isrefreshed;
			_o.Missiongroupidx = this.Missiongroupidx;
		}

		public static Offset<ContentsMissionData> Pack(FlatBufferBuilder builder, ContentsMissionDataT _o)
		{
			if (_o == null) return default(Offset<ContentsMissionData>);
			var _missions = default(VectorOffset);
			if (_o.Missions != null)
			{
				var __missions = new Offset<SingleMissionData>[_o.Missions.Count];
				for (var _j = 0; _j < _o.Missions.Count; ++_j)
					__missions[_j] = SingleMissionData.Pack(builder, _o.Missions[_j]);
				_missions = CreateMissionsVector(builder, __missions);
			}
			StartContentsMissionData(builder);
			AddContentstype(builder, _o.Contentstype);
			AddMissionsettime(builder, _o.Missionsettime);
			AddMissions(builder, _missions);
			AddIsrefreshed(builder, _o.Isrefreshed);
			AddMissiongroupidx(builder, _o.Missiongroupidx);
			return EndContentsMissionData(builder);
		}
	}
}
