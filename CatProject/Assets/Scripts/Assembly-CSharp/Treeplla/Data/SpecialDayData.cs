using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SpecialDayData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Specialdayidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int SpecialdaydecoLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Firstguideview { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Specialdayyear { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SpecialDayData GetRootAsSpecialDayData(ByteBuffer _bb)
		{
			return GetRootAsSpecialDayData(_bb, new SpecialDayData());
		}

		public static SpecialDayData GetRootAsSpecialDayData(ByteBuffer _bb, SpecialDayData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SpecialDayData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSpecialdayidx(int specialdayidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, specialdayidx);
				return true;
			}
			return false;
		}

		public ItemData? Specialdaydeco(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? (new ItemData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateFirstguideview(bool firstguideview)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(firstguideview ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateSpecialdayyear(int specialdayyear)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, specialdayyear);
				return true;
			}
			return false;
		}

		public static Offset<SpecialDayData> CreateSpecialDayData(FlatBufferBuilder builder, int specialdayidx = 0, VectorOffset specialdaydecoOffset = default(VectorOffset), bool firstguideview = false, int specialdayyear = 0)
		{
			builder.StartTable(4);
			AddSpecialdayyear(builder, specialdayyear);
			AddFirstguideview(builder, firstguideview);
			AddSpecialdaydeco(builder, specialdaydecoOffset);
			AddSpecialdayidx(builder, specialdayidx);
			return EndSpecialDayData(builder);
		}

		public static void StartSpecialDayData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddSpecialdayidx(FlatBufferBuilder builder, int specialdayidx)
		{
			builder.AddInt(0, specialdayidx, 0);
		}

		public static void AddSpecialdaydeco(FlatBufferBuilder builder, VectorOffset specialdaydecoOffset)
		{
			builder.AddOffset(1, specialdaydecoOffset.Value, 0);
		}

		public static VectorOffset CreateSpecialdaydecoVector(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateSpecialdaydecoVectorBlock(FlatBufferBuilder builder, Offset<ItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSpecialdaydecoVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ItemData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateSpecialdaydecoVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartSpecialdaydecoVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddFirstguideview(FlatBufferBuilder builder, bool firstguideview)
		{
			builder.AddBool(2, firstguideview, false);
		}

		public static void AddSpecialdayyear(FlatBufferBuilder builder, int specialdayyear)
		{
			builder.AddInt(3, specialdayyear, 0);
		}

		public static Offset<SpecialDayData> EndSpecialDayData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SpecialDayData>(o);
		}

		public SpecialDayDataT UnPack()
		{
			var _o = new SpecialDayDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SpecialDayDataT _o)
		{
			_o.Specialdayidx = this.Specialdayidx;
			_o.Specialdaydeco = new List<ItemDataT>();
			for (var _j = 0; _j < this.SpecialdaydecoLength; ++_j)
				_o.Specialdaydeco.Add(this.Specialdaydeco(_j).HasValue ? this.Specialdaydeco(_j).Value.UnPack() : null);
			_o.Firstguideview = this.Firstguideview;
			_o.Specialdayyear = this.Specialdayyear;
		}

		public static Offset<SpecialDayData> Pack(FlatBufferBuilder builder, SpecialDayDataT _o)
		{
			if (_o == null) return default(Offset<SpecialDayData>);
			var _specialdaydeco = default(VectorOffset);
			if (_o.Specialdaydeco != null)
			{
				var __specialdaydeco = new Offset<ItemData>[_o.Specialdaydeco.Count];
				for (var _j = 0; _j < _o.Specialdaydeco.Count; ++_j)
					__specialdaydeco[_j] = ItemData.Pack(builder, _o.Specialdaydeco[_j]);
				_specialdaydeco = CreateSpecialdaydecoVector(builder, __specialdaydeco);
			}
			StartSpecialDayData(builder);
			AddSpecialdayidx(builder, _o.Specialdayidx);
			AddSpecialdaydeco(builder, _specialdaydeco);
			AddFirstguideview(builder, _o.Firstguideview);
			AddSpecialdayyear(builder, _o.Specialdayyear);
			return EndSpecialDayData(builder);
		}
	}
}
