using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BizAcquisitionTeamData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int TeamceoidxlistLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BizAcquisitionTeamData GetRootAsBizAcquisitionTeamData(ByteBuffer _bb)
		{
			return GetRootAsBizAcquisitionTeamData(_bb, new BizAcquisitionTeamData());
		}

		public static BizAcquisitionTeamData GetRootAsBizAcquisitionTeamData(ByteBuffer _bb, BizAcquisitionTeamData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BizAcquisitionTeamData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public int Teamceoidxlist(int j)
		{
			int o = __p.__offset(4);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetTeamceoidxlistBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public int[] GetTeamceoidxlistArray()
		{
			return null;
		}

		public bool MutateTeamceoidxlist(int j, int teamceoidxlist)
		{
			return false;
		}

		public static Offset<BizAcquisitionTeamData> CreateBizAcquisitionTeamData(FlatBufferBuilder builder, VectorOffset teamceoidxlistOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			AddTeamceoidxlist(builder, teamceoidxlistOffset);
			return EndBizAcquisitionTeamData(builder);
		}

		public static void StartBizAcquisitionTeamData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddTeamceoidxlist(FlatBufferBuilder builder, VectorOffset teamceoidxlistOffset)
		{
			builder.AddOffset(0, teamceoidxlistOffset.Value, 0);
		}

		public static VectorOffset CreateTeamceoidxlistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateTeamceoidxlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateTeamceoidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateTeamceoidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartTeamceoidxlistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<BizAcquisitionTeamData> EndBizAcquisitionTeamData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BizAcquisitionTeamData>(o);
		}

		public BizAcquisitionTeamDataT UnPack()
		{
			var _o = new BizAcquisitionTeamDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BizAcquisitionTeamDataT _o)
		{
			_o.Teamceoidxlist = new List<int>();
			for (var _j = 0; _j < this.TeamceoidxlistLength; ++_j)
				_o.Teamceoidxlist.Add(this.Teamceoidxlist(_j));
		}

		public static Offset<BizAcquisitionTeamData> Pack(FlatBufferBuilder builder, BizAcquisitionTeamDataT _o)
		{
			if (_o == null) return default(Offset<BizAcquisitionTeamData>);
			var _teamceoidxlist = default(VectorOffset);
			if (_o.Teamceoidxlist != null)
			{
				var __teamceoidxlist = _o.Teamceoidxlist.ToArray();
				_teamceoidxlist = CreateTeamceoidxlistVector(builder, __teamceoidxlist);
			}
			StartBizAcquisitionTeamData(builder);
			AddTeamceoidxlist(builder, _teamceoidxlist);
			return EndBizAcquisitionTeamData(builder);
		}
	}
}
