using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ManagerKeyAddData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public long Factoryresettime { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Factoryorder { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int FactoryrewardsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Usegemcount { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int CatstakeyrewardLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int FactoryrewardcontentsopenLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Factoryrewardcontentsopen2Length { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static ManagerKeyAddData GetRootAsManagerKeyAddData(ByteBuffer _bb)
		{
			return GetRootAsManagerKeyAddData(_bb, new ManagerKeyAddData());
		}

		public static ManagerKeyAddData GetRootAsManagerKeyAddData(ByteBuffer _bb, ManagerKeyAddData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public ManagerKeyAddData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateFactoryresettime(long factoryresettime)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, factoryresettime);
				return true;
			}
			return false;
		}

		public bool MutateFactoryorder(int factoryorder)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, factoryorder);
				return true;
			}
			return false;
		}

		public int Factoryrewards(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetFactoryrewardsBytes()
		{
			return __p.__vector_as_arraysegment(18);
		}

		public int[] GetFactoryrewardsArray()
		{
			return null;
		}

		public bool MutateFactoryrewards(int j, int factoryrewards)
		{
			return false;
		}

		public bool MutateUsegemcount(int usegemcount)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, usegemcount);
				return true;
			}
			return false;
		}

		public int Catstakeyreward(int j)
		{
			int o = __p.__offset(12);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetCatstakeyrewardBytes()
		{
			return __p.__vector_as_arraysegment(20);
		}

		public int[] GetCatstakeyrewardArray()
		{
			return null;
		}

		public bool MutateCatstakeyreward(int j, int catstakeyreward)
		{
			return false;
		}

		public bool Factoryrewardcontentsopen(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetFactoryrewardcontentsopenBytes()
		{
			return __p.__vector_as_arraysegment(22);
		}

		public bool[] GetFactoryrewardcontentsopenArray()
		{
			return null;
		}

		public bool MutateFactoryrewardcontentsopen(int j, bool factoryrewardcontentsopen)
		{
			return false;
		}

		public bool Factoryrewardcontentsopen2(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetFactoryrewardcontentsopen2Bytes()
		{
			return __p.__vector_as_arraysegment(24);
		}

		public bool[] GetFactoryrewardcontentsopen2Array()
		{
			return null;
		}

		public bool MutateFactoryrewardcontentsopen2(int j, bool factoryrewardcontentsopen2)
		{
			return false;
		}

		public static Offset<ManagerKeyAddData> CreateManagerKeyAddData(FlatBufferBuilder builder, long factoryresettime = 0L, int factoryorder = 0, VectorOffset factoryrewardsOffset = default(VectorOffset), int usegemcount = 0, VectorOffset catstakeyrewardOffset = default(VectorOffset), VectorOffset factoryrewardcontentsopenOffset = default(VectorOffset), VectorOffset factoryrewardcontentsopen2Offset = default(VectorOffset))
		{
			builder.StartTable(7);
			AddFactoryrewardcontentsopen2(builder, factoryrewardcontentsopen2Offset);
			AddFactoryrewardcontentsopen(builder, factoryrewardcontentsopenOffset);
			AddCatstakeyreward(builder, catstakeyrewardOffset);
			AddUsegemcount(builder, usegemcount);
			AddFactoryrewards(builder, factoryrewardsOffset);
			AddFactoryorder(builder, factoryorder);
			AddFactoryresettime(builder, factoryresettime);
			return EndManagerKeyAddData(builder);
		}

		public static void StartManagerKeyAddData(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		public static void AddFactoryresettime(FlatBufferBuilder builder, long factoryresettime)
		{
			builder.AddLong(0, factoryresettime, 0);
		}

		public static void AddFactoryorder(FlatBufferBuilder builder, int factoryorder)
		{
			builder.AddInt(1, factoryorder, 0);
		}

		public static void AddFactoryrewards(FlatBufferBuilder builder, VectorOffset factoryrewardsOffset)
		{
			builder.AddOffset(2, factoryrewardsOffset.Value, 0);
		}

		public static VectorOffset CreateFactoryrewardsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateFactoryrewardsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateFactoryrewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateFactoryrewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartFactoryrewardsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddUsegemcount(FlatBufferBuilder builder, int usegemcount)
		{
			builder.AddInt(3, usegemcount, 0);
		}

		public static void AddCatstakeyreward(FlatBufferBuilder builder, VectorOffset catstakeyrewardOffset)
		{
			builder.AddOffset(4, catstakeyrewardOffset.Value, 0);
		}

		public static VectorOffset CreateCatstakeyrewardVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCatstakeyrewardVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCatstakeyrewardVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCatstakeyrewardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCatstakeyrewardVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddFactoryrewardcontentsopen(FlatBufferBuilder builder, VectorOffset factoryrewardcontentsopenOffset)
		{
			builder.AddOffset(5, factoryrewardcontentsopenOffset.Value, 0);
		}

		public static VectorOffset CreateFactoryrewardcontentsopenVector(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddBool(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateFactoryrewardcontentsopenVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddBool(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateFactoryrewardcontentsopenVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			builder.StartVector(1, data.Count, 1);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddBool(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateFactoryrewardcontentsopenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartFactoryrewardcontentsopenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddFactoryrewardcontentsopen2(FlatBufferBuilder builder, VectorOffset factoryrewardcontentsopen2Offset)
		{
			builder.AddOffset(6, factoryrewardcontentsopen2Offset.Value, 0);
		}

		public static VectorOffset CreateFactoryrewardcontentsopen2Vector(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddBool(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateFactoryrewardcontentsopen2VectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddBool(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateFactoryrewardcontentsopen2VectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			builder.StartVector(1, data.Count, 1);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddBool(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateFactoryrewardcontentsopen2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartFactoryrewardcontentsopen2Vector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<ManagerKeyAddData> EndManagerKeyAddData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<ManagerKeyAddData>(o);
		}

		public ManagerKeyAddDataT UnPack()
		{
			var _o = new ManagerKeyAddDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(ManagerKeyAddDataT _o)
		{
			_o.Factoryresettime = this.Factoryresettime;
			_o.Factoryorder = this.Factoryorder;
			_o.Factoryrewards = new List<int>();
			for (var _j = 0; _j < this.FactoryrewardsLength; ++_j)
				_o.Factoryrewards.Add(this.Factoryrewards(_j));
			_o.Usegemcount = this.Usegemcount;
			_o.Catstakeyreward = new List<int>();
			for (var _j = 0; _j < this.CatstakeyrewardLength; ++_j)
				_o.Catstakeyreward.Add(this.Catstakeyreward(_j));
			_o.Factoryrewardcontentsopen = new List<bool>();
			for (var _j = 0; _j < this.FactoryrewardcontentsopenLength; ++_j)
				_o.Factoryrewardcontentsopen.Add(this.Factoryrewardcontentsopen(_j));
			_o.Factoryrewardcontentsopen2 = new List<bool>();
			for (var _j = 0; _j < this.Factoryrewardcontentsopen2Length; ++_j)
				_o.Factoryrewardcontentsopen2.Add(this.Factoryrewardcontentsopen2(_j));
		}

		public static Offset<ManagerKeyAddData> Pack(FlatBufferBuilder builder, ManagerKeyAddDataT _o)
		{
			if (_o == null) return default(Offset<ManagerKeyAddData>);
			var _factoryrewards = default(VectorOffset);
			if (_o.Factoryrewards != null)
			{
				var __factoryrewards = _o.Factoryrewards.ToArray();
				_factoryrewards = CreateFactoryrewardsVector(builder, __factoryrewards);
			}
			var _catstakeyreward = default(VectorOffset);
			if (_o.Catstakeyreward != null)
			{
				var __catstakeyreward = _o.Catstakeyreward.ToArray();
				_catstakeyreward = CreateCatstakeyrewardVector(builder, __catstakeyreward);
			}
			var _factoryrewardcontentsopen = default(VectorOffset);
			if (_o.Factoryrewardcontentsopen != null)
			{
				var __factoryrewardcontentsopen = _o.Factoryrewardcontentsopen.ToArray();
				_factoryrewardcontentsopen = CreateFactoryrewardcontentsopenVector(builder, __factoryrewardcontentsopen);
			}
			var _factoryrewardcontentsopen2 = default(VectorOffset);
			if (_o.Factoryrewardcontentsopen2 != null)
			{
				var __factoryrewardcontentsopen2 = _o.Factoryrewardcontentsopen2.ToArray();
				_factoryrewardcontentsopen2 = CreateFactoryrewardcontentsopen2Vector(builder, __factoryrewardcontentsopen2);
			}
			StartManagerKeyAddData(builder);
			AddFactoryresettime(builder, _o.Factoryresettime);
			AddFactoryorder(builder, _o.Factoryorder);
			AddFactoryrewards(builder, _factoryrewards);
			AddUsegemcount(builder, _o.Usegemcount);
			AddCatstakeyreward(builder, _catstakeyreward);
			AddFactoryrewardcontentsopen(builder, _factoryrewardcontentsopen);
			AddFactoryrewardcontentsopen2(builder, _factoryrewardcontentsopen2);
			return EndManagerKeyAddData(builder);
		}
	}
}
