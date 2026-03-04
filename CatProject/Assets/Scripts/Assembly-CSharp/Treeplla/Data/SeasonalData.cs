using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Activeseasonidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int SeasonalstagedataLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int PlayedseasoninfoidxlistLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int SeasonalshopdataLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalData GetRootAsSeasonalData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalData(_bb, new SeasonalData());
		}

		public static SeasonalData GetRootAsSeasonalData(ByteBuffer _bb, SeasonalData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateActiveseasonidx(int activeseasonidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, activeseasonidx);
				return true;
			}
			return false;
		}

		public SeasonalStageData? Seasonalstagedata(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? (new SeasonalStageData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public int Playedseasoninfoidxlist(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetPlayedseasoninfoidxlistBytes()
		{
			return __p.__vector_as_arraysegment(14);
		}

		public int[] GetPlayedseasoninfoidxlistArray()
		{
			return null;
		}

		public bool MutatePlayedseasoninfoidxlist(int j, int playedseasoninfoidxlist)
		{
			return false;
		}

		public SeasonalShopData? Seasonalshopdata(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? (new SeasonalShopData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<SeasonalData> CreateSeasonalData(FlatBufferBuilder builder, int activeseasonidx = 0, VectorOffset seasonalstagedataOffset = default(VectorOffset), VectorOffset playedseasoninfoidxlistOffset = default(VectorOffset), VectorOffset seasonalshopdataOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			AddSeasonalshopdata(builder, seasonalshopdataOffset);
			AddPlayedseasoninfoidxlist(builder, playedseasoninfoidxlistOffset);
			AddSeasonalstagedata(builder, seasonalstagedataOffset);
			AddActiveseasonidx(builder, activeseasonidx);
			return EndSeasonalData(builder);
		}

		public static void StartSeasonalData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		public static void AddActiveseasonidx(FlatBufferBuilder builder, int activeseasonidx)
		{
			builder.AddInt(0, activeseasonidx, 0);
		}

		public static void AddSeasonalstagedata(FlatBufferBuilder builder, VectorOffset seasonalstagedataOffset)
		{
			builder.AddOffset(1, seasonalstagedataOffset.Value, 0);
		}

		public static VectorOffset CreateSeasonalstagedataVector(FlatBufferBuilder builder, Offset<SeasonalStageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateSeasonalstagedataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalStageData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSeasonalstagedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalStageData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSeasonalstagedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartSeasonalstagedataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddPlayedseasoninfoidxlist(FlatBufferBuilder builder, VectorOffset playedseasoninfoidxlistOffset)
		{
			builder.AddOffset(2, playedseasoninfoidxlistOffset.Value, 0);
		}

		public static VectorOffset CreatePlayedseasoninfoidxlistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreatePlayedseasoninfoidxlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePlayedseasoninfoidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePlayedseasoninfoidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartPlayedseasoninfoidxlistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddSeasonalshopdata(FlatBufferBuilder builder, VectorOffset seasonalshopdataOffset)
		{
			builder.AddOffset(3, seasonalshopdataOffset.Value, 0);
		}

		public static VectorOffset CreateSeasonalshopdataVector(FlatBufferBuilder builder, Offset<SeasonalShopData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateSeasonalshopdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalShopData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSeasonalshopdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalShopData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSeasonalshopdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartSeasonalshopdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<SeasonalData> EndSeasonalData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalData>(o);
		}

		public SeasonalDataT UnPack()
		{
			var _o = new SeasonalDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalDataT _o)
		{
			_o.Activeseasonidx = this.Activeseasonidx;
			_o.Seasonalstagedata = new List<SeasonalStageDataT>();
			for (var _j = 0; _j < this.SeasonalstagedataLength; ++_j)
				_o.Seasonalstagedata.Add(this.Seasonalstagedata(_j).HasValue ? this.Seasonalstagedata(_j).Value.UnPack() : null);
			_o.Playedseasoninfoidxlist = new List<int>();
			for (var _j = 0; _j < this.PlayedseasoninfoidxlistLength; ++_j)
				_o.Playedseasoninfoidxlist.Add(this.Playedseasoninfoidxlist(_j));
			_o.Seasonalshopdata = new List<SeasonalShopDataT>();
			for (var _j = 0; _j < this.SeasonalshopdataLength; ++_j)
				_o.Seasonalshopdata.Add(this.Seasonalshopdata(_j).HasValue ? this.Seasonalshopdata(_j).Value.UnPack() : null);
		}

		public static Offset<SeasonalData> Pack(FlatBufferBuilder builder, SeasonalDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalData>);
			var _seasonalstagedata = default(VectorOffset);
			if (_o.Seasonalstagedata != null)
			{
				var __seasonalstagedata = new Offset<SeasonalStageData>[_o.Seasonalstagedata.Count];
				for (var _j = 0; _j < _o.Seasonalstagedata.Count; ++_j)
					__seasonalstagedata[_j] = SeasonalStageData.Pack(builder, _o.Seasonalstagedata[_j]);
				_seasonalstagedata = CreateSeasonalstagedataVector(builder, __seasonalstagedata);
			}
			var _playedseasoninfoidxlist = default(VectorOffset);
			if (_o.Playedseasoninfoidxlist != null)
			{
				var __playedseasoninfoidxlist = _o.Playedseasoninfoidxlist.ToArray();
				_playedseasoninfoidxlist = CreatePlayedseasoninfoidxlistVector(builder, __playedseasoninfoidxlist);
			}
			var _seasonalshopdata = default(VectorOffset);
			if (_o.Seasonalshopdata != null)
			{
				var __seasonalshopdata = new Offset<SeasonalShopData>[_o.Seasonalshopdata.Count];
				for (var _j = 0; _j < _o.Seasonalshopdata.Count; ++_j)
					__seasonalshopdata[_j] = SeasonalShopData.Pack(builder, _o.Seasonalshopdata[_j]);
				_seasonalshopdata = CreateSeasonalshopdataVector(builder, __seasonalshopdata);
			}
			StartSeasonalData(builder);
			AddActiveseasonidx(builder, _o.Activeseasonidx);
			AddSeasonalstagedata(builder, _seasonalstagedata);
			AddPlayedseasoninfoidxlist(builder, _playedseasoninfoidxlist);
			AddSeasonalshopdata(builder, _seasonalshopdata);
			return EndSeasonalData(builder);
		}
	}
}
