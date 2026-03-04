using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AdpassData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Openvalue { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Resettime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int GetrewardsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Adviewcount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static AdpassData GetRootAsAdpassData(ByteBuffer _bb)
		{
			return GetRootAsAdpassData(_bb, new AdpassData());
		}

		public static AdpassData GetRootAsAdpassData(ByteBuffer _bb, AdpassData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public AdpassData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateOpenvalue(int openvalue)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, openvalue);
				return true;
			}
			return false;
		}

		public bool MutateResettime(long resettime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, resettime);
				return true;
			}
			return false;
		}

		public int Getrewards(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetGetrewardsBytes()
		{
			return __p.__vector_as_arraysegment(12);
		}

		public int[] GetGetrewardsArray()
		{
			return null;
		}

		public bool MutateGetrewards(int j, int getrewards)
		{
			return false;
		}

		public bool MutateAdviewcount(int adviewcount)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, adviewcount);
				return true;
			}
			return false;
		}

		public static Offset<AdpassData> CreateAdpassData(FlatBufferBuilder builder, int openvalue = -1, long resettime = 0L, VectorOffset getrewardsOffset = default(VectorOffset), int adviewcount = 0)
		{
			builder.StartTable(4);
			AddAdviewcount(builder, adviewcount);
			AddGetrewards(builder, getrewardsOffset);
			AddResettime(builder, resettime);
			AddOpenvalue(builder, openvalue);
			return EndAdpassData(builder);
		}

		public static void StartAdpassData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddOpenvalue(FlatBufferBuilder builder, int openvalue)
		{
			builder.AddInt(0, openvalue, 0);
		}

		public static void AddResettime(FlatBufferBuilder builder, long resettime)
		{
			builder.AddLong(1, resettime, 0);
		}

		public static void AddGetrewards(FlatBufferBuilder builder, VectorOffset getrewardsOffset)
		{
			builder.AddOffset(2, getrewardsOffset.Value, 0);
		}

		public static VectorOffset CreateGetrewardsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartGetrewardsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddAdviewcount(FlatBufferBuilder builder, int adviewcount)
		{
			builder.AddInt(3, adviewcount, 0);
		}

		public static Offset<AdpassData> EndAdpassData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<AdpassData>(o);
		}

		public AdpassDataT UnPack()
		{
			var _o = new AdpassDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(AdpassDataT _o)
		{
			_o.Openvalue = this.Openvalue;
			_o.Resettime = this.Resettime;
			_o.Getrewards = new List<int>();
			for (var _j = 0; _j < this.GetrewardsLength; ++_j)
				_o.Getrewards.Add(this.Getrewards(_j));
			_o.Adviewcount = this.Adviewcount;
		}

		public static Offset<AdpassData> Pack(FlatBufferBuilder builder, AdpassDataT _o)
		{
			if (_o == null) return default(Offset<AdpassData>);
			var _getrewards = default(VectorOffset);
			if (_o.Getrewards != null)
			{
				var __getrewards = _o.Getrewards.ToArray();
				_getrewards = CreateGetrewardsVector(builder, __getrewards);
			}
			StartAdpassData(builder);
			AddOpenvalue(builder, _o.Openvalue);
			AddResettime(builder, _o.Resettime);
			AddGetrewards(builder, _getrewards);
			AddAdviewcount(builder, _o.Adviewcount);
			return EndAdpassData(builder);
		}
	}
}
