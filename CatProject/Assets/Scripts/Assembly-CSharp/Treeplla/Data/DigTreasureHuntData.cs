using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct DigTreasureHuntData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Eventidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Stageidx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int GridLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int ProgressrewardclaimedLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Scheduleidx { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static DigTreasureHuntData GetRootAsDigTreasureHuntData(ByteBuffer _bb)
		{
			return GetRootAsDigTreasureHuntData(_bb, new DigTreasureHuntData());
		}

		public static DigTreasureHuntData GetRootAsDigTreasureHuntData(ByteBuffer _bb, DigTreasureHuntData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public DigTreasureHuntData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateEventidx(int eventidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, eventidx);
				return true;
			}
			return false;
		}

		public bool MutateStageidx(int stageidx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, stageidx);
				return true;
			}
			return false;
		}

		public DigTreasureHuntCellData? Grid(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new DigTreasureHuntCellData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool Progressrewardclaimed(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetProgressrewardclaimedBytes()
		{
			return __p.__vector_as_arraysegment(16);
		}

		public bool[] GetProgressrewardclaimedArray()
		{
			return null;
		}

		public bool MutateProgressrewardclaimed(int j, bool progressrewardclaimed)
		{
			return false;
		}

		public bool MutateScheduleidx(int scheduleidx)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, scheduleidx);
				return true;
			}
			return false;
		}

		public static Offset<DigTreasureHuntData> CreateDigTreasureHuntData(FlatBufferBuilder builder, int eventidx = 0, int stageidx = 0, VectorOffset gridOffset = default(VectorOffset), VectorOffset progressrewardclaimedOffset = default(VectorOffset), int scheduleidx = 0)
		{
			builder.StartTable(5);
			AddScheduleidx(builder, scheduleidx);
			AddProgressrewardclaimed(builder, progressrewardclaimedOffset);
			AddGrid(builder, gridOffset);
			AddStageidx(builder, stageidx);
			AddEventidx(builder, eventidx);
			return EndDigTreasureHuntData(builder);
		}

		public static void StartDigTreasureHuntData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		public static void AddEventidx(FlatBufferBuilder builder, int eventidx)
		{
			builder.AddInt(0, eventidx, 0);
		}

		public static void AddStageidx(FlatBufferBuilder builder, int stageidx)
		{
			builder.AddInt(1, stageidx, 0);
		}

		public static void AddGrid(FlatBufferBuilder builder, VectorOffset gridOffset)
		{
			builder.AddOffset(2, gridOffset.Value, 0);
		}

		public static VectorOffset CreateGridVector(FlatBufferBuilder builder, Offset<DigTreasureHuntCellData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateGridVectorBlock(FlatBufferBuilder builder, Offset<DigTreasureHuntCellData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateGridVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<DigTreasureHuntCellData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateGridVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartGridVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddProgressrewardclaimed(FlatBufferBuilder builder, VectorOffset progressrewardclaimedOffset)
		{
			builder.AddOffset(3, progressrewardclaimedOffset.Value, 0);
		}

		public static VectorOffset CreateProgressrewardclaimedVector(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddBool(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateProgressrewardclaimedVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddBool(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateProgressrewardclaimedVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			builder.StartVector(1, data.Count, 1);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddBool(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateProgressrewardclaimedVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartProgressrewardclaimedVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddScheduleidx(FlatBufferBuilder builder, int scheduleidx)
		{
			builder.AddInt(4, scheduleidx, 0);
		}

		public static Offset<DigTreasureHuntData> EndDigTreasureHuntData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<DigTreasureHuntData>(o);
		}

		public DigTreasureHuntDataT UnPack()
		{
			var _o = new DigTreasureHuntDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(DigTreasureHuntDataT _o)
		{
			_o.Eventidx = this.Eventidx;
			_o.Stageidx = this.Stageidx;
			_o.Grid = new List<DigTreasureHuntCellDataT>();
			for (var _j = 0; _j < this.GridLength; ++_j)
				_o.Grid.Add(this.Grid(_j).HasValue ? this.Grid(_j).Value.UnPack() : null);
			_o.Progressrewardclaimed = new List<bool>();
			for (var _j = 0; _j < this.ProgressrewardclaimedLength; ++_j)
				_o.Progressrewardclaimed.Add(this.Progressrewardclaimed(_j));
			_o.Scheduleidx = this.Scheduleidx;
		}

		public static Offset<DigTreasureHuntData> Pack(FlatBufferBuilder builder, DigTreasureHuntDataT _o)
		{
			if (_o == null) return default(Offset<DigTreasureHuntData>);
			var _grid = default(VectorOffset);
			if (_o.Grid != null)
			{
				var __grid = new Offset<DigTreasureHuntCellData>[_o.Grid.Count];
				for (var _j = 0; _j < _o.Grid.Count; ++_j)
					__grid[_j] = DigTreasureHuntCellData.Pack(builder, _o.Grid[_j]);
				_grid = CreateGridVector(builder, __grid);
			}
			var _progressrewardclaimed = default(VectorOffset);
			if (_o.Progressrewardclaimed != null)
			{
				var __progressrewardclaimed = _o.Progressrewardclaimed.ToArray();
				_progressrewardclaimed = CreateProgressrewardclaimedVector(builder, __progressrewardclaimed);
			}
			StartDigTreasureHuntData(builder);
			AddEventidx(builder, _o.Eventidx);
			AddStageidx(builder, _o.Stageidx);
			AddGrid(builder, _grid);
			AddProgressrewardclaimed(builder, _progressrewardclaimed);
			AddScheduleidx(builder, _o.Scheduleidx);
			return EndDigTreasureHuntData(builder);
		}
	}
}
