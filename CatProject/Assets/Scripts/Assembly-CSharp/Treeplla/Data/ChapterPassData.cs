using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ChapterPassData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int ReceivestageLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int ReceivebonuschapterLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int ReceivestagenormalLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static ChapterPassData GetRootAsChapterPassData(ByteBuffer _bb)
		{
			return GetRootAsChapterPassData(_bb, new ChapterPassData());
		}

		public static ChapterPassData GetRootAsChapterPassData(ByteBuffer _bb, ChapterPassData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public ChapterPassData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public int Receivestage(int j)
		{
			int o = __p.__offset(4);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetReceivestageBytes()
		{
			return __p.__vector_as_arraysegment(10);
		}

		public int[] GetReceivestageArray()
		{
			return null;
		}

		public bool MutateReceivestage(int j, int receivestage)
		{
			return false;
		}

		public int Receivebonuschapter(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetReceivebonuschapterBytes()
		{
			return __p.__vector_as_arraysegment(12);
		}

		public int[] GetReceivebonuschapterArray()
		{
			return null;
		}

		public bool MutateReceivebonuschapter(int j, int receivebonuschapter)
		{
			return false;
		}

		public int Receivestagenormal(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetReceivestagenormalBytes()
		{
			return __p.__vector_as_arraysegment(14);
		}

		public int[] GetReceivestagenormalArray()
		{
			return null;
		}

		public bool MutateReceivestagenormal(int j, int receivestagenormal)
		{
			return false;
		}

		public static Offset<ChapterPassData> CreateChapterPassData(FlatBufferBuilder builder, VectorOffset receivestageOffset = default(VectorOffset), VectorOffset receivebonuschapterOffset = default(VectorOffset), VectorOffset receivestagenormalOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			AddReceivestagenormal(builder, receivestagenormalOffset);
			AddReceivebonuschapter(builder, receivebonuschapterOffset);
			AddReceivestage(builder, receivestageOffset);
			return EndChapterPassData(builder);
		}

		public static void StartChapterPassData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddReceivestage(FlatBufferBuilder builder, VectorOffset receivestageOffset)
		{
			builder.AddOffset(0, receivestageOffset.Value, 0);
		}

		public static VectorOffset CreateReceivestageVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivestageVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivestageVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivestageVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartReceivestageVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddReceivebonuschapter(FlatBufferBuilder builder, VectorOffset receivebonuschapterOffset)
		{
			builder.AddOffset(1, receivebonuschapterOffset.Value, 0);
		}

		public static VectorOffset CreateReceivebonuschapterVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivebonuschapterVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivebonuschapterVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivebonuschapterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartReceivebonuschapterVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddReceivestagenormal(FlatBufferBuilder builder, VectorOffset receivestagenormalOffset)
		{
			builder.AddOffset(2, receivestagenormalOffset.Value, 0);
		}

		public static VectorOffset CreateReceivestagenormalVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivestagenormalVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivestagenormalVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivestagenormalVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartReceivestagenormalVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<ChapterPassData> EndChapterPassData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<ChapterPassData>(o);
		}

		public ChapterPassDataT UnPack()
		{
			var _o = new ChapterPassDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(ChapterPassDataT _o)
		{
			_o.Receivestage = new List<int>();
			for (var _j = 0; _j < this.ReceivestageLength; ++_j)
				_o.Receivestage.Add(this.Receivestage(_j));
			_o.Receivebonuschapter = new List<int>();
			for (var _j = 0; _j < this.ReceivebonuschapterLength; ++_j)
				_o.Receivebonuschapter.Add(this.Receivebonuschapter(_j));
			_o.Receivestagenormal = new List<int>();
			for (var _j = 0; _j < this.ReceivestagenormalLength; ++_j)
				_o.Receivestagenormal.Add(this.Receivestagenormal(_j));
		}

		public static Offset<ChapterPassData> Pack(FlatBufferBuilder builder, ChapterPassDataT _o)
		{
			if (_o == null) return default(Offset<ChapterPassData>);
			var _receivestage = default(VectorOffset);
			if (_o.Receivestage != null)
			{
				var __receivestage = _o.Receivestage.ToArray();
				_receivestage = CreateReceivestageVector(builder, __receivestage);
			}
			var _receivebonuschapter = default(VectorOffset);
			if (_o.Receivebonuschapter != null)
			{
				var __receivebonuschapter = _o.Receivebonuschapter.ToArray();
				_receivebonuschapter = CreateReceivebonuschapterVector(builder, __receivebonuschapter);
			}
			var _receivestagenormal = default(VectorOffset);
			if (_o.Receivestagenormal != null)
			{
				var __receivestagenormal = _o.Receivestagenormal.ToArray();
				_receivestagenormal = CreateReceivestagenormalVector(builder, __receivestagenormal);
			}
			StartChapterPassData(builder);
			AddReceivestage(builder, _receivestage);
			AddReceivebonuschapter(builder, _receivebonuschapter);
			AddReceivestagenormal(builder, _receivestagenormal);
			return EndChapterPassData(builder);
		}
	}
}
