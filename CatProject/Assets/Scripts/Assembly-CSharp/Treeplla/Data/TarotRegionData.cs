using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct TarotRegionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Tarotstarttype { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Tarotresettime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int TarotcardlistLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int TarotcardgetlistLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static TarotRegionData GetRootAsTarotRegionData(ByteBuffer _bb)
		{
			return GetRootAsTarotRegionData(_bb, new TarotRegionData());
		}

		public static TarotRegionData GetRootAsTarotRegionData(ByteBuffer _bb, TarotRegionData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public TarotRegionData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateTarotstarttype(int tarotstarttype)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, tarotstarttype);
				return true;
			}
			return false;
		}

		public bool MutateTarotresettime(long tarotresettime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, tarotresettime);
				return true;
			}
			return false;
		}

		public int Tarotcardlist(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetTarotcardlistBytes()
		{
			return __p.__vector_as_arraysegment(12);
		}

		public int[] GetTarotcardlistArray()
		{
			return null;
		}

		public bool MutateTarotcardlist(int j, int tarotcardlist)
		{
			return false;
		}

		public int Tarotcardgetlist(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetTarotcardgetlistBytes()
		{
			return __p.__vector_as_arraysegment(14);
		}

		public int[] GetTarotcardgetlistArray()
		{
			return null;
		}

		public bool MutateTarotcardgetlist(int j, int tarotcardgetlist)
		{
			return false;
		}

		public static Offset<TarotRegionData> CreateTarotRegionData(FlatBufferBuilder builder, int tarotstarttype = 0, long tarotresettime = 0L, VectorOffset tarotcardlistOffset = default(VectorOffset), VectorOffset tarotcardgetlistOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			AddTarotcardgetlist(builder, tarotcardgetlistOffset);
			AddTarotcardlist(builder, tarotcardlistOffset);
			AddTarotresettime(builder, tarotresettime);
			AddTarotstarttype(builder, tarotstarttype);
			return EndTarotRegionData(builder);
		}

		public static void StartTarotRegionData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddTarotstarttype(FlatBufferBuilder builder, int tarotstarttype)
		{
			builder.AddInt(0, tarotstarttype, 0);
		}

		public static void AddTarotresettime(FlatBufferBuilder builder, long tarotresettime)
		{
			builder.AddLong(1, tarotresettime, 0);
		}

		public static void AddTarotcardlist(FlatBufferBuilder builder, VectorOffset tarotcardlistOffset)
		{
			builder.AddOffset(2, tarotcardlistOffset.Value, 0);
		}

		public static VectorOffset CreateTarotcardlistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotcardlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotcardlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotcardlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartTarotcardlistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddTarotcardgetlist(FlatBufferBuilder builder, VectorOffset tarotcardgetlistOffset)
		{
			builder.AddOffset(3, tarotcardgetlistOffset.Value, 0);
		}

		public static VectorOffset CreateTarotcardgetlistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotcardgetlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotcardgetlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotcardgetlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartTarotcardgetlistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<TarotRegionData> EndTarotRegionData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<TarotRegionData>(o);
		}

		public TarotRegionDataT UnPack()
		{
			var _o = new TarotRegionDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(TarotRegionDataT _o)
		{
			_o.Tarotstarttype = this.Tarotstarttype;
			_o.Tarotresettime = this.Tarotresettime;
			_o.Tarotcardlist = new List<int>();
			for (var _j = 0; _j < this.TarotcardlistLength; ++_j)
				_o.Tarotcardlist.Add(this.Tarotcardlist(_j));
			_o.Tarotcardgetlist = new List<int>();
			for (var _j = 0; _j < this.TarotcardgetlistLength; ++_j)
				_o.Tarotcardgetlist.Add(this.Tarotcardgetlist(_j));
		}

		public static Offset<TarotRegionData> Pack(FlatBufferBuilder builder, TarotRegionDataT _o)
		{
			if (_o == null) return default(Offset<TarotRegionData>);
			var _tarotcardlist = default(VectorOffset);
			if (_o.Tarotcardlist != null)
			{
				var __tarotcardlist = _o.Tarotcardlist.ToArray();
				_tarotcardlist = CreateTarotcardlistVector(builder, __tarotcardlist);
			}
			var _tarotcardgetlist = default(VectorOffset);
			if (_o.Tarotcardgetlist != null)
			{
				var __tarotcardgetlist = _o.Tarotcardgetlist.ToArray();
				_tarotcardgetlist = CreateTarotcardgetlistVector(builder, __tarotcardgetlist);
			}
			StartTarotRegionData(builder);
			AddTarotstarttype(builder, _o.Tarotstarttype);
			AddTarotresettime(builder, _o.Tarotresettime);
			AddTarotcardlist(builder, _tarotcardlist);
			AddTarotcardgetlist(builder, _tarotcardgetlist);
			return EndTarotRegionData(builder);
		}
	}
}
