using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct UniqueCustomerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int CustomerLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Reddot { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static UniqueCustomerData GetRootAsUniqueCustomerData(ByteBuffer _bb)
		{
			return GetRootAsUniqueCustomerData(_bb, new UniqueCustomerData());
		}

		public static UniqueCustomerData GetRootAsUniqueCustomerData(ByteBuffer _bb, UniqueCustomerData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public UniqueCustomerData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool Customer(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetCustomerBytes()
		{
			return __p.__vector_as_arraysegment(8);
		}

		public bool[] GetCustomerArray()
		{
			return null;
		}

		public bool MutateCustomer(int j, bool customer)
		{
			return false;
		}

		public bool MutateReddot(int reddot)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, reddot);
				return true;
			}
			return false;
		}

		public static Offset<UniqueCustomerData> CreateUniqueCustomerData(FlatBufferBuilder builder, VectorOffset customerOffset = default(VectorOffset), int reddot = 0)
		{
			builder.StartTable(2);
			AddReddot(builder, reddot);
			AddCustomer(builder, customerOffset);
			return EndUniqueCustomerData(builder);
		}

		public static void StartUniqueCustomerData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddCustomer(FlatBufferBuilder builder, VectorOffset customerOffset)
		{
			builder.AddOffset(0, customerOffset.Value, 0);
		}

		public static VectorOffset CreateCustomerVector(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddBool(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCustomerVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddBool(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCustomerVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			builder.StartVector(1, data.Count, 1);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddBool(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCustomerVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCustomerVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddReddot(FlatBufferBuilder builder, int reddot)
		{
			builder.AddInt(1, reddot, 0);
		}

		public static Offset<UniqueCustomerData> EndUniqueCustomerData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<UniqueCustomerData>(o);
		}

		public UniqueCustomerDataT UnPack()
		{
			var _o = new UniqueCustomerDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(UniqueCustomerDataT _o)
		{
			_o.Customer = new List<bool>();
			for (var _j = 0; _j < this.CustomerLength; ++_j)
				_o.Customer.Add(this.Customer(_j));
			_o.Reddot = this.Reddot;
		}

		public static Offset<UniqueCustomerData> Pack(FlatBufferBuilder builder, UniqueCustomerDataT _o)
		{
			if (_o == null) return default(Offset<UniqueCustomerData>);
			var _customer = default(VectorOffset);
			if (_o.Customer != null)
			{
				var __customer = _o.Customer.ToArray();
				_customer = CreateCustomerVector(builder, __customer);
			}
			StartUniqueCustomerData(builder);
			AddCustomer(builder, _customer);
			AddReddot(builder, _o.Reddot);
			return EndUniqueCustomerData(builder);
		}
	}
}
