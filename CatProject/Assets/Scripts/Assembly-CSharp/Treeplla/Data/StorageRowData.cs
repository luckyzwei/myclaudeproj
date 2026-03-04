using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct StorageRowData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Row { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int TreedataLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static StorageRowData GetRootAsStorageRowData(ByteBuffer _bb)
		{
			return GetRootAsStorageRowData(_bb, new StorageRowData());
		}

		public static StorageRowData GetRootAsStorageRowData(ByteBuffer _bb, StorageRowData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public StorageRowData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateRow(int row)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, row);
				return true;
			}
			return false;
		}

		public TreeData? Treedata(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? (new TreeData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<StorageRowData> CreateStorageRowData(FlatBufferBuilder builder, int row = 0, VectorOffset treedataOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			AddTreedata(builder, treedataOffset);
			AddRow(builder, row);
			return EndStorageRowData(builder);
		}

		public static void StartStorageRowData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddRow(FlatBufferBuilder builder, int row)
		{
			builder.AddInt(0, row, 0);
		}

		public static void AddTreedata(FlatBufferBuilder builder, VectorOffset treedataOffset)
		{
			builder.AddOffset(1, treedataOffset.Value, 0);
		}

		public static VectorOffset CreateTreedataVector(FlatBufferBuilder builder, Offset<TreeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateTreedataVectorBlock(FlatBufferBuilder builder, Offset<TreeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateTreedataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<TreeData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateTreedataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartTreedataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<StorageRowData> EndStorageRowData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<StorageRowData>(o);
		}

		public StorageRowDataT UnPack()
		{
			var _o = new StorageRowDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(StorageRowDataT _o)
		{
			_o.Row = this.Row;
			_o.Treedata = new List<TreeDataT>();
			for (var _j = 0; _j < this.TreedataLength; ++_j)
				_o.Treedata.Add(this.Treedata(_j).HasValue ? this.Treedata(_j).Value.UnPack() : null);
		}

		public static Offset<StorageRowData> Pack(FlatBufferBuilder builder, StorageRowDataT _o)
		{
			if (_o == null) return default(Offset<StorageRowData>);
			var _treedata = default(VectorOffset);
			if (_o.Treedata != null)
			{
				var __treedata = new Offset<TreeData>[_o.Treedata.Count];
				for (var _j = 0; _j < _o.Treedata.Count; ++_j)
					__treedata[_j] = TreeData.Pack(builder, _o.Treedata[_j]);
				_treedata = CreateTreedataVector(builder, __treedata);
			}
			StartStorageRowData(builder);
			AddRow(builder, _o.Row);
			AddTreedata(builder, _treedata);
			return EndStorageRowData(builder);
		}
	}
}
