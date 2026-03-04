using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RichAchieve : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int MissionreceivedidxsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int AchievereceivedidxsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Isguideshow { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Ispageinfoshow { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static RichAchieve GetRootAsRichAchieve(ByteBuffer _bb)
		{
			return GetRootAsRichAchieve(_bb, new RichAchieve());
		}

		public static RichAchieve GetRootAsRichAchieve(ByteBuffer _bb, RichAchieve obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public RichAchieve __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public int Missionreceivedidxs(int j)
		{
			int o = __p.__offset(4);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetMissionreceivedidxsBytes()
		{
			return __p.__vector_as_arraysegment(12);
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
			int o = __p.__offset(6);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetAchievereceivedidxsBytes()
		{
			return __p.__vector_as_arraysegment(14);
		}

		public int[] GetAchievereceivedidxsArray()
		{
			return null;
		}

		public bool MutateAchievereceivedidxs(int j, int achievereceivedidxs)
		{
			return false;
		}

		public bool MutateIsguideshow(bool isguideshow)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isguideshow ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateIspageinfoshow(bool ispageinfoshow)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(ispageinfoshow ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<RichAchieve> CreateRichAchieve(FlatBufferBuilder builder, VectorOffset missionreceivedidxsOffset = default(VectorOffset), VectorOffset achievereceivedidxsOffset = default(VectorOffset), bool isguideshow = false, bool ispageinfoshow = false)
		{
			builder.StartTable(4);
			AddIspageinfoshow(builder, ispageinfoshow);
			AddIsguideshow(builder, isguideshow);
			AddAchievereceivedidxs(builder, achievereceivedidxsOffset);
			AddMissionreceivedidxs(builder, missionreceivedidxsOffset);
			return EndRichAchieve(builder);
		}

		public static void StartRichAchieve(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddMissionreceivedidxs(FlatBufferBuilder builder, VectorOffset missionreceivedidxsOffset)
		{
			builder.AddOffset(0, missionreceivedidxsOffset.Value, 0);
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
			builder.AddOffset(1, achievereceivedidxsOffset.Value, 0);
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

		public static void AddIsguideshow(FlatBufferBuilder builder, bool isguideshow)
		{
			builder.AddBool(2, isguideshow, false);
		}

		public static void AddIspageinfoshow(FlatBufferBuilder builder, bool ispageinfoshow)
		{
			builder.AddBool(3, ispageinfoshow, false);
		}

		public static Offset<RichAchieve> EndRichAchieve(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<RichAchieve>(o);
		}

		public RichAchieveT UnPack()
		{
			var _o = new RichAchieveT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(RichAchieveT _o)
		{
			_o.Missionreceivedidxs = new List<int>();
			for (var _j = 0; _j < this.MissionreceivedidxsLength; ++_j)
				_o.Missionreceivedidxs.Add(this.Missionreceivedidxs(_j));
			_o.Achievereceivedidxs = new List<int>();
			for (var _j = 0; _j < this.AchievereceivedidxsLength; ++_j)
				_o.Achievereceivedidxs.Add(this.Achievereceivedidxs(_j));
			_o.Isguideshow = this.Isguideshow;
			_o.Ispageinfoshow = this.Ispageinfoshow;
		}

		public static Offset<RichAchieve> Pack(FlatBufferBuilder builder, RichAchieveT _o)
		{
			if (_o == null) return default(Offset<RichAchieve>);
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
			StartRichAchieve(builder);
			AddMissionreceivedidxs(builder, _missionreceivedidxs);
			AddAchievereceivedidxs(builder, _achievereceivedidxs);
			AddIsguideshow(builder, _o.Isguideshow);
			AddIspageinfoshow(builder, _o.Ispageinfoshow);
			return EndRichAchieve(builder);
		}
	}
}
