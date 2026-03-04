using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct PassReceiveData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int NormalLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int PremiumLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static PassReceiveData GetRootAsPassReceiveData(ByteBuffer _bb)
		{
			return GetRootAsPassReceiveData(_bb, new PassReceiveData());
		}

		public static PassReceiveData GetRootAsPassReceiveData(ByteBuffer _bb, PassReceiveData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public PassReceiveData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public int Normal(int j)
		{
			int o = __p.__offset(4);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetNormalBytes()
		{
			return __p.__vector_as_arraysegment(8);
		}

		public int[] GetNormalArray()
		{
			return null;
		}

		public bool MutateNormal(int j, int normal)
		{
			return false;
		}

		public int Premium(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetPremiumBytes()
		{
			return __p.__vector_as_arraysegment(10);
		}

		public int[] GetPremiumArray()
		{
			return null;
		}

		public bool MutatePremium(int j, int premium)
		{
			return false;
		}

		public static Offset<PassReceiveData> CreatePassReceiveData(FlatBufferBuilder builder, VectorOffset normalOffset = default(VectorOffset), VectorOffset premiumOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			AddPremium(builder, premiumOffset);
			AddNormal(builder, normalOffset);
			return EndPassReceiveData(builder);
		}

		public static void StartPassReceiveData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddNormal(FlatBufferBuilder builder, VectorOffset normalOffset)
		{
			builder.AddOffset(0, normalOffset.Value, 0);
		}

		public static VectorOffset CreateNormalVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateNormalVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateNormalVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateNormalVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartNormalVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddPremium(FlatBufferBuilder builder, VectorOffset premiumOffset)
		{
			builder.AddOffset(1, premiumOffset.Value, 0);
		}

		public static VectorOffset CreatePremiumVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreatePremiumVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePremiumVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePremiumVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartPremiumVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<PassReceiveData> EndPassReceiveData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<PassReceiveData>(o);
		}

		public PassReceiveDataT UnPack()
		{
			var _o = new PassReceiveDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(PassReceiveDataT _o)
		{
			_o.Normal = new List<int>();
			for (var _j = 0; _j < this.NormalLength; ++_j)
				_o.Normal.Add(this.Normal(_j));
			_o.Premium = new List<int>();
			for (var _j = 0; _j < this.PremiumLength; ++_j)
				_o.Premium.Add(this.Premium(_j));
		}

		public static Offset<PassReceiveData> Pack(FlatBufferBuilder builder, PassReceiveDataT _o)
		{
			if (_o == null) return default(Offset<PassReceiveData>);
			var _normal = default(VectorOffset);
			if (_o.Normal != null)
			{
				var __normal = _o.Normal.ToArray();
				_normal = CreateNormalVector(builder, __normal);
			}
			var _premium = default(VectorOffset);
			if (_o.Premium != null)
			{
				var __premium = _o.Premium.ToArray();
				_premium = CreatePremiumVector(builder, __premium);
			}
			StartPassReceiveData(builder);
			AddNormal(builder, _normal);
			AddPremium(builder, _premium);
			return EndPassReceiveData(builder);
		}
	}
}
