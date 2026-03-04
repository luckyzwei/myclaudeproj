using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct StorageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int RowdataLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static StorageData GetRootAsStorageData(ByteBuffer _bb)
		{
			return GetRootAsStorageData(_bb, new StorageData());
		}

		public static StorageData GetRootAsStorageData(ByteBuffer _bb, StorageData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public StorageData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIndex(int index)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, index);
				return true;
			}
			return false;
		}

		public StorageRowData? Rowdata(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? (new StorageRowData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<StorageData> CreateStorageData(FlatBufferBuilder builder, int index = 0, VectorOffset rowdataOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			AddRowdata(builder, rowdataOffset);
			AddIndex(builder, index);
			return EndStorageData(builder);
		}

		public static void StartStorageData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		public static void AddRowdata(FlatBufferBuilder builder, VectorOffset rowdataOffset)
		{
			builder.AddOffset(1, rowdataOffset.Value, 0);
		}

		public static VectorOffset CreateRowdataVector(FlatBufferBuilder builder, Offset<StorageRowData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateRowdataVectorBlock(FlatBufferBuilder builder, Offset<StorageRowData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateRowdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<StorageRowData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateRowdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartRowdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<StorageData> EndStorageData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<StorageData>(o);
		}

		public StorageDataT UnPack()
		{
			var _o = new StorageDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(StorageDataT _o)
		{
			_o.Index = this.Index;
			_o.Rowdata = new List<StorageRowDataT>();
			for (var _j = 0; _j < this.RowdataLength; ++_j)
				_o.Rowdata.Add(this.Rowdata(_j).HasValue ? this.Rowdata(_j).Value.UnPack() : null);
		}

		public static Offset<StorageData> Pack(FlatBufferBuilder builder, StorageDataT _o)
		{
			if (_o == null) return default(Offset<StorageData>);
			var _rowdata = default(VectorOffset);
			if (_o.Rowdata != null)
			{
				var __rowdata = new Offset<StorageRowData>[_o.Rowdata.Count];
				for (var _j = 0; _j < _o.Rowdata.Count; ++_j)
					__rowdata[_j] = StorageRowData.Pack(builder, _o.Rowdata[_j]);
				_rowdata = CreateRowdataVector(builder, __rowdata);
			}
			StartStorageData(builder);
			AddIndex(builder, _o.Index);
			AddRowdata(builder, _rowdata);
			return EndStorageData(builder);
		}
	}
}
