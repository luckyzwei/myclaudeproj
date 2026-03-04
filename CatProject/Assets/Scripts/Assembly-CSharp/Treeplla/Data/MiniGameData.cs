using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MiniGameData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int DigtreasurehuntdataLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int ShopdataLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Lastplayscheduleidx { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Shownopenpopup { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static MiniGameData GetRootAsMiniGameData(ByteBuffer _bb)
		{
			return GetRootAsMiniGameData(_bb, new MiniGameData());
		}

		public static MiniGameData GetRootAsMiniGameData(ByteBuffer _bb, MiniGameData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public MiniGameData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public DigTreasureHuntData? Digtreasurehuntdata(int j)
		{
			int o = __p.__offset(4);
			return o != 0 ? (new DigTreasureHuntData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public MiniGameShopData? Shopdata(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? (new MiniGameShopData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateLastplayscheduleidx(int lastplayscheduleidx)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, lastplayscheduleidx);
				return true;
			}
			return false;
		}

		public bool MutateShownopenpopup(bool shownopenpopup)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(shownopenpopup ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<MiniGameData> CreateMiniGameData(FlatBufferBuilder builder, VectorOffset digtreasurehuntdataOffset = default(VectorOffset), VectorOffset shopdataOffset = default(VectorOffset), int lastplayscheduleidx = 0, bool shownopenpopup = false)
		{
			builder.StartTable(4);
			AddShownopenpopup(builder, shownopenpopup);
			AddLastplayscheduleidx(builder, lastplayscheduleidx);
			AddShopdata(builder, shopdataOffset);
			AddDigtreasurehuntdata(builder, digtreasurehuntdataOffset);
			return EndMiniGameData(builder);
		}

		public static void StartMiniGameData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddDigtreasurehuntdata(FlatBufferBuilder builder, VectorOffset digtreasurehuntdataOffset)
		{
			builder.AddOffset(0, digtreasurehuntdataOffset.Value, 0);
		}

		public static VectorOffset CreateDigtreasurehuntdataVector(FlatBufferBuilder builder, Offset<DigTreasureHuntData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateDigtreasurehuntdataVectorBlock(FlatBufferBuilder builder, Offset<DigTreasureHuntData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateDigtreasurehuntdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<DigTreasureHuntData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateDigtreasurehuntdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartDigtreasurehuntdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddShopdata(FlatBufferBuilder builder, VectorOffset shopdataOffset)
		{
			builder.AddOffset(1, shopdataOffset.Value, 0);
		}

		public static VectorOffset CreateShopdataVector(FlatBufferBuilder builder, Offset<MiniGameShopData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateShopdataVectorBlock(FlatBufferBuilder builder, Offset<MiniGameShopData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateShopdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<MiniGameShopData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateShopdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartShopdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddLastplayscheduleidx(FlatBufferBuilder builder, int lastplayscheduleidx)
		{
			builder.AddInt(2, lastplayscheduleidx, 0);
		}

		public static void AddShownopenpopup(FlatBufferBuilder builder, bool shownopenpopup)
		{
			builder.AddBool(3, shownopenpopup, false);
		}

		public static Offset<MiniGameData> EndMiniGameData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<MiniGameData>(o);
		}

		public MiniGameDataT UnPack()
		{
			var _o = new MiniGameDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(MiniGameDataT _o)
		{
			_o.Digtreasurehuntdata = new List<DigTreasureHuntDataT>();
			for (var _j = 0; _j < this.DigtreasurehuntdataLength; ++_j)
				_o.Digtreasurehuntdata.Add(this.Digtreasurehuntdata(_j).HasValue ? this.Digtreasurehuntdata(_j).Value.UnPack() : null);
			_o.Shopdata = new List<MiniGameShopDataT>();
			for (var _j = 0; _j < this.ShopdataLength; ++_j)
				_o.Shopdata.Add(this.Shopdata(_j).HasValue ? this.Shopdata(_j).Value.UnPack() : null);
			_o.Lastplayscheduleidx = this.Lastplayscheduleidx;
			_o.Shownopenpopup = this.Shownopenpopup;
		}

		public static Offset<MiniGameData> Pack(FlatBufferBuilder builder, MiniGameDataT _o)
		{
			if (_o == null) return default(Offset<MiniGameData>);
			var _digtreasurehuntdata = default(VectorOffset);
			if (_o.Digtreasurehuntdata != null)
			{
				var __digtreasurehuntdata = new Offset<DigTreasureHuntData>[_o.Digtreasurehuntdata.Count];
				for (var _j = 0; _j < _o.Digtreasurehuntdata.Count; ++_j)
					__digtreasurehuntdata[_j] = DigTreasureHuntData.Pack(builder, _o.Digtreasurehuntdata[_j]);
				_digtreasurehuntdata = CreateDigtreasurehuntdataVector(builder, __digtreasurehuntdata);
			}
			var _shopdata = default(VectorOffset);
			if (_o.Shopdata != null)
			{
				var __shopdata = new Offset<MiniGameShopData>[_o.Shopdata.Count];
				for (var _j = 0; _j < _o.Shopdata.Count; ++_j)
					__shopdata[_j] = MiniGameShopData.Pack(builder, _o.Shopdata[_j]);
				_shopdata = CreateShopdataVector(builder, __shopdata);
			}
			StartMiniGameData(builder);
			AddDigtreasurehuntdata(builder, _digtreasurehuntdata);
			AddShopdata(builder, _shopdata);
			AddLastplayscheduleidx(builder, _o.Lastplayscheduleidx);
			AddShownopenpopup(builder, _o.Shownopenpopup);
			return EndMiniGameData(builder);
		}
	}
}
