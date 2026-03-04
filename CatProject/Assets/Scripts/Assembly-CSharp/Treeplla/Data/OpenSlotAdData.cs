using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OpenSlotAdData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Reward { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Opentime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int OpentimedictkeyLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int OpentimedictvalueLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static OpenSlotAdData GetRootAsOpenSlotAdData(ByteBuffer _bb)
		{
			return GetRootAsOpenSlotAdData(_bb, new OpenSlotAdData());
		}

		public static OpenSlotAdData GetRootAsOpenSlotAdData(ByteBuffer _bb, OpenSlotAdData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public OpenSlotAdData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateReward(int reward)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, reward);
				return true;
			}
			return false;
		}

		public bool MutateOpentime(long opentime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, opentime);
				return true;
			}
			return false;
		}

		public int Opentimedictkey(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetOpentimedictkeyBytes()
		{
			return __p.__vector_as_arraysegment(12);
		}

		public int[] GetOpentimedictkeyArray()
		{
			return null;
		}

		public bool MutateOpentimedictkey(int j, int opentimedictkey)
		{
			return false;
		}

		public long Opentimedictvalue(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0;
		}

		public ArraySegment<byte>? GetOpentimedictvalueBytes()
		{
			return __p.__vector_as_arraysegment(14);
		}

		public long[] GetOpentimedictvalueArray()
		{
			return null;
		}

		public bool MutateOpentimedictvalue(int j, long opentimedictvalue)
		{
			return false;
		}

		public static Offset<OpenSlotAdData> CreateOpenSlotAdData(FlatBufferBuilder builder, int reward = 0, long opentime = 0L, VectorOffset opentimedictkeyOffset = default(VectorOffset), VectorOffset opentimedictvalueOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			AddOpentimedictvalue(builder, opentimedictvalueOffset);
			AddOpentimedictkey(builder, opentimedictkeyOffset);
			AddOpentime(builder, opentime);
			AddReward(builder, reward);
			return EndOpenSlotAdData(builder);
		}

		public static void StartOpenSlotAdData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddReward(FlatBufferBuilder builder, int reward)
		{
			builder.AddInt(0, reward, 0);
		}

		public static void AddOpentime(FlatBufferBuilder builder, long opentime)
		{
			builder.AddLong(1, opentime, 0);
		}

		public static void AddOpentimedictkey(FlatBufferBuilder builder, VectorOffset opentimedictkeyOffset)
		{
			builder.AddOffset(2, opentimedictkeyOffset.Value, 0);
		}

		public static VectorOffset CreateOpentimedictkeyVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOpentimedictkeyVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateOpentimedictkeyVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateOpentimedictkeyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOpentimedictkeyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOpentimedictvalue(FlatBufferBuilder builder, VectorOffset opentimedictvalueOffset)
		{
			builder.AddOffset(3, opentimedictvalueOffset.Value, 0);
		}

		public static VectorOffset CreateOpentimedictvalueVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOpentimedictvalueVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddLong(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateOpentimedictvalueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddLong(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateOpentimedictvalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOpentimedictvalueVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<OpenSlotAdData> EndOpenSlotAdData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<OpenSlotAdData>(o);
		}

		public OpenSlotAdDataT UnPack()
		{
			var _o = new OpenSlotAdDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(OpenSlotAdDataT _o)
		{
			_o.Reward = this.Reward;
			_o.Opentime = this.Opentime;
			_o.Opentimedictkey = new List<int>();
			for (var _j = 0; _j < this.OpentimedictkeyLength; ++_j)
				_o.Opentimedictkey.Add(this.Opentimedictkey(_j));
			_o.Opentimedictvalue = new List<long>();
			for (var _j = 0; _j < this.OpentimedictvalueLength; ++_j)
				_o.Opentimedictvalue.Add(this.Opentimedictvalue(_j));
		}

		public static Offset<OpenSlotAdData> Pack(FlatBufferBuilder builder, OpenSlotAdDataT _o)
		{
			if (_o == null) return default(Offset<OpenSlotAdData>);
			var _opentimedictkey = default(VectorOffset);
			if (_o.Opentimedictkey != null)
			{
				var __opentimedictkey = _o.Opentimedictkey.ToArray();
				_opentimedictkey = CreateOpentimedictkeyVector(builder, __opentimedictkey);
			}
			var _opentimedictvalue = default(VectorOffset);
			if (_o.Opentimedictvalue != null)
			{
				var __opentimedictvalue = _o.Opentimedictvalue.ToArray();
				_opentimedictvalue = CreateOpentimedictvalueVector(builder, __opentimedictvalue);
			}
			StartOpenSlotAdData(builder);
			AddReward(builder, _o.Reward);
			AddOpentime(builder, _o.Opentime);
			AddOpentimedictkey(builder, _opentimedictkey);
			AddOpentimedictvalue(builder, _opentimedictvalue);
			return EndOpenSlotAdData(builder);
		}
	}
}
