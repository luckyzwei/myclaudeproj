using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct PlantData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public float Exp { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0f; } }

		public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int FullsLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Count { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Abilitytime { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public bool Isnew { get { int o = __p.__offset(16); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static PlantData GetRootAsPlantData(ByteBuffer _bb)
		{
			return GetRootAsPlantData(_bb, new PlantData());
		}

		public static PlantData GetRootAsPlantData(ByteBuffer _bb, PlantData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public PlantData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIdx(int idx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, idx);
				return true;
			}
			return false;
		}

		public bool MutateExp(float exp)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutFloat(o + __p.bb_pos, exp);
				return true;
			}
			return false;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public KeyValue? Fulls(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? (new KeyValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateCount(int count)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, count);
				return true;
			}
			return false;
		}

		public bool MutateAbilitytime(long abilitytime)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, abilitytime);
				return true;
			}
			return false;
		}

		public bool MutateIsnew(bool isnew)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isnew ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<PlantData> CreatePlantData(FlatBufferBuilder builder, int idx = 0, float exp = 0f, int level = 0, VectorOffset fullsOffset = default(VectorOffset), int count = 0, long abilitytime = 0L, bool isnew = false)
		{
			builder.StartTable(7);
			AddIsnew(builder, isnew);
			AddAbilitytime(builder, abilitytime);
			AddCount(builder, count);
			AddFulls(builder, fullsOffset);
			AddLevel(builder, level);
			AddExp(builder, exp);
			AddIdx(builder, idx);
			return EndPlantData(builder);
		}

		public static void StartPlantData(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddExp(FlatBufferBuilder builder, float exp)
		{
			builder.AddFloat(1, exp, 0f);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(2, level, 0);
		}

		public static void AddFulls(FlatBufferBuilder builder, VectorOffset fullsOffset)
		{
			builder.AddOffset(3, fullsOffset.Value, 0);
		}

		public static VectorOffset CreateFullsVector(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateFullsVectorBlock(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateFullsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValue>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateFullsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartFullsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(4, count, 0);
		}

		public static void AddAbilitytime(FlatBufferBuilder builder, long abilitytime)
		{
			builder.AddLong(5, abilitytime, 0);
		}

		public static void AddIsnew(FlatBufferBuilder builder, bool isnew)
		{
			builder.AddBool(6, isnew, false);
		}

		public static Offset<PlantData> EndPlantData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<PlantData>(o);
		}

		public PlantDataT UnPack()
		{
			var _o = new PlantDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(PlantDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Exp = this.Exp;
			_o.Level = this.Level;
			_o.Fulls = new List<KeyValueT>();
			for (var _j = 0; _j < this.FullsLength; ++_j)
				_o.Fulls.Add(this.Fulls(_j).HasValue ? this.Fulls(_j).Value.UnPack() : null);
			_o.Count = this.Count;
			_o.Abilitytime = this.Abilitytime;
			_o.Isnew = this.Isnew;
		}

		public static Offset<PlantData> Pack(FlatBufferBuilder builder, PlantDataT _o)
		{
			if (_o == null) return default(Offset<PlantData>);
			var _fulls = default(VectorOffset);
			if (_o.Fulls != null)
			{
				var __fulls = new Offset<KeyValue>[_o.Fulls.Count];
				for (var _j = 0; _j < _o.Fulls.Count; ++_j)
					__fulls[_j] = KeyValue.Pack(builder, _o.Fulls[_j]);
				_fulls = CreateFullsVector(builder, __fulls);
			}
			StartPlantData(builder);
			AddIdx(builder, _o.Idx);
			AddExp(builder, _o.Exp);
			AddLevel(builder, _o.Level);
			AddFulls(builder, _fulls);
			AddCount(builder, _o.Count);
			AddAbilitytime(builder, _o.Abilitytime);
			AddIsnew(builder, _o.Isnew);
			return EndPlantData(builder);
		}
	}
}
