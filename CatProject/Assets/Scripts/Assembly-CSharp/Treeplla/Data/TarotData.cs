using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct TarotData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Tarotbasicticket { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Tarotspecialticket { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int TarotrewardlistLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int TarotregiondataLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public long Lastfreerefreshtime { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static TarotData GetRootAsTarotData(ByteBuffer _bb)
		{
			return GetRootAsTarotData(_bb, new TarotData());
		}

		public static TarotData GetRootAsTarotData(ByteBuffer _bb, TarotData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public TarotData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateTarotbasicticket(int tarotbasicticket)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, tarotbasicticket);
				return true;
			}
			return false;
		}

		public bool MutateTarotspecialticket(int tarotspecialticket)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, tarotspecialticket);
				return true;
			}
			return false;
		}

		public int Tarotrewardlist(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetTarotrewardlistBytes()
		{
			return __p.__vector_as_arraysegment(14);
		}

		public int[] GetTarotrewardlistArray()
		{
			return null;
		}

		public bool MutateTarotrewardlist(int j, int tarotrewardlist)
		{
			return false;
		}

		public TarotRegionData? Tarotregiondata(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? (new TarotRegionData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateLastfreerefreshtime(long lastfreerefreshtime)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastfreerefreshtime);
				return true;
			}
			return false;
		}

		public static Offset<TarotData> CreateTarotData(FlatBufferBuilder builder, int tarotbasicticket = 0, int tarotspecialticket = 0, VectorOffset tarotrewardlistOffset = default(VectorOffset), VectorOffset tarotregiondataOffset = default(VectorOffset), long lastfreerefreshtime = 0L)
		{
			builder.StartTable(5);
			AddLastfreerefreshtime(builder, lastfreerefreshtime);
			AddTarotregiondata(builder, tarotregiondataOffset);
			AddTarotrewardlist(builder, tarotrewardlistOffset);
			AddTarotspecialticket(builder, tarotspecialticket);
			AddTarotbasicticket(builder, tarotbasicticket);
			return EndTarotData(builder);
		}

		public static void StartTarotData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		public static void AddTarotbasicticket(FlatBufferBuilder builder, int tarotbasicticket)
		{
			builder.AddInt(0, tarotbasicticket, 0);
		}

		public static void AddTarotspecialticket(FlatBufferBuilder builder, int tarotspecialticket)
		{
			builder.AddInt(1, tarotspecialticket, 0);
		}

		public static void AddTarotrewardlist(FlatBufferBuilder builder, VectorOffset tarotrewardlistOffset)
		{
			builder.AddOffset(2, tarotrewardlistOffset.Value, 0);
		}

		public static VectorOffset CreateTarotrewardlistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotrewardlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotrewardlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotrewardlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartTarotrewardlistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddTarotregiondata(FlatBufferBuilder builder, VectorOffset tarotregiondataOffset)
		{
			builder.AddOffset(3, tarotregiondataOffset.Value, 0);
		}

		public static VectorOffset CreateTarotregiondataVector(FlatBufferBuilder builder, Offset<TarotRegionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotregiondataVectorBlock(FlatBufferBuilder builder, Offset<TarotRegionData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotregiondataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<TarotRegionData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateTarotregiondataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartTarotregiondataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddLastfreerefreshtime(FlatBufferBuilder builder, long lastfreerefreshtime)
		{
			builder.AddLong(4, lastfreerefreshtime, 0);
		}

		public static Offset<TarotData> EndTarotData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<TarotData>(o);
		}

		public TarotDataT UnPack()
		{
			var _o = new TarotDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(TarotDataT _o)
		{
			_o.Tarotbasicticket = this.Tarotbasicticket;
			_o.Tarotspecialticket = this.Tarotspecialticket;
			_o.Tarotrewardlist = new List<int>();
			for (var _j = 0; _j < this.TarotrewardlistLength; ++_j)
				_o.Tarotrewardlist.Add(this.Tarotrewardlist(_j));
			_o.Tarotregiondata = new List<TarotRegionDataT>();
			for (var _j = 0; _j < this.TarotregiondataLength; ++_j)
				_o.Tarotregiondata.Add(this.Tarotregiondata(_j).HasValue ? this.Tarotregiondata(_j).Value.UnPack() : null);
			_o.Lastfreerefreshtime = this.Lastfreerefreshtime;
		}

		public static Offset<TarotData> Pack(FlatBufferBuilder builder, TarotDataT _o)
		{
			if (_o == null) return default(Offset<TarotData>);
			var _tarotrewardlist = default(VectorOffset);
			if (_o.Tarotrewardlist != null)
			{
				var __tarotrewardlist = _o.Tarotrewardlist.ToArray();
				_tarotrewardlist = CreateTarotrewardlistVector(builder, __tarotrewardlist);
			}
			var _tarotregiondata = default(VectorOffset);
			if (_o.Tarotregiondata != null)
			{
				var __tarotregiondata = new Offset<TarotRegionData>[_o.Tarotregiondata.Count];
				for (var _j = 0; _j < _o.Tarotregiondata.Count; ++_j)
					__tarotregiondata[_j] = TarotRegionData.Pack(builder, _o.Tarotregiondata[_j]);
				_tarotregiondata = CreateTarotregiondataVector(builder, __tarotregiondata);
			}
			StartTarotData(builder);
			AddTarotbasicticket(builder, _o.Tarotbasicticket);
			AddTarotspecialticket(builder, _o.Tarotspecialticket);
			AddTarotrewardlist(builder, _tarotrewardlist);
			AddTarotregiondata(builder, _tarotregiondata);
			AddLastfreerefreshtime(builder, _o.Lastfreerefreshtime);
			return EndTarotData(builder);
		}
	}
}
