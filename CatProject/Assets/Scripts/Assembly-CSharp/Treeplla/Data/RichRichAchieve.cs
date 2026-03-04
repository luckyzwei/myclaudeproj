using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RichRichAchieve : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Achievecount { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int MissionreceivedidxsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int AchievereceivedidxsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static RichRichAchieve GetRootAsRichRichAchieve(ByteBuffer _bb)
		{
			return GetRootAsRichRichAchieve(_bb, new RichRichAchieve());
		}

		public static RichRichAchieve GetRootAsRichRichAchieve(ByteBuffer _bb, RichRichAchieve obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public RichRichAchieve __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateAchievecount(int achievecount)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, achievecount);
				return true;
			}
			return false;
		}

		public int Missionreceivedidxs(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetMissionreceivedidxsBytes()
		{
			return __p.__vector_as_arraysegment(10);
		}

		public int[] GetMissionreceivedidxsArray()
		{
			return null;
		}

		public bool MutateMissionreceivedidxs(int j, int missionreceivedidxs)
		{
			return false;
		}

		public int Achievereceivedidxs(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetAchievereceivedidxsBytes()
		{
			return __p.__vector_as_arraysegment(12);
		}

		public int[] GetAchievereceivedidxsArray()
		{
			return null;
		}

		public bool MutateAchievereceivedidxs(int j, int achievereceivedidxs)
		{
			return false;
		}

		public static Offset<RichRichAchieve> CreateRichRichAchieve(FlatBufferBuilder builder, int achievecount = 0, VectorOffset missionreceivedidxsOffset = default(VectorOffset), VectorOffset achievereceivedidxsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			AddAchievereceivedidxs(builder, achievereceivedidxsOffset);
			AddMissionreceivedidxs(builder, missionreceivedidxsOffset);
			AddAchievecount(builder, achievecount);
			return EndRichRichAchieve(builder);
		}

		public static void StartRichRichAchieve(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddAchievecount(FlatBufferBuilder builder, int achievecount)
		{
			builder.AddInt(0, achievecount, 0);
		}

		public static void AddMissionreceivedidxs(FlatBufferBuilder builder, VectorOffset missionreceivedidxsOffset)
		{
			builder.AddOffset(1, missionreceivedidxsOffset.Value, 0);
		}

		public static VectorOffset CreateMissionreceivedidxsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionreceivedidxsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionreceivedidxsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionreceivedidxsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartMissionreceivedidxsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddAchievereceivedidxs(FlatBufferBuilder builder, VectorOffset achievereceivedidxsOffset)
		{
			builder.AddOffset(2, achievereceivedidxsOffset.Value, 0);
		}

		public static VectorOffset CreateAchievereceivedidxsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateAchievereceivedidxsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateAchievereceivedidxsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateAchievereceivedidxsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartAchievereceivedidxsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<RichRichAchieve> EndRichRichAchieve(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<RichRichAchieve>(o);
		}

		public RichRichAchieveT UnPack()
		{
			var _o = new RichRichAchieveT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(RichRichAchieveT _o)
		{
			_o.Achievecount = this.Achievecount;
			_o.Missionreceivedidxs = new List<int>();
			for (var _j = 0; _j < this.MissionreceivedidxsLength; ++_j)
				_o.Missionreceivedidxs.Add(this.Missionreceivedidxs(_j));
			_o.Achievereceivedidxs = new List<int>();
			for (var _j = 0; _j < this.AchievereceivedidxsLength; ++_j)
				_o.Achievereceivedidxs.Add(this.Achievereceivedidxs(_j));
		}

		public static Offset<RichRichAchieve> Pack(FlatBufferBuilder builder, RichRichAchieveT _o)
		{
			if (_o == null) return default(Offset<RichRichAchieve>);
			var _missionreceivedidxs = default(VectorOffset);
			if (_o.Missionreceivedidxs != null)
			{
				var __missionreceivedidxs = _o.Missionreceivedidxs.ToArray();
				_missionreceivedidxs = CreateMissionreceivedidxsVector(builder, __missionreceivedidxs);
			}
			var _achievereceivedidxs = default(VectorOffset);
			if (_o.Achievereceivedidxs != null)
			{
				var __achievereceivedidxs = _o.Achievereceivedidxs.ToArray();
				_achievereceivedidxs = CreateAchievereceivedidxsVector(builder, __achievereceivedidxs);
			}
			StartRichRichAchieve(builder);
			AddAchievecount(builder, _o.Achievecount);
			AddMissionreceivedidxs(builder, _missionreceivedidxs);
			AddAchievereceivedidxs(builder, _achievereceivedidxs);
			return EndRichRichAchieve(builder);
		}
	}
}
