using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CeoCostumeOwnedData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Defaultcostumeidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Equippedcostumeidx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int OwnedcostumeidxlistLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static CeoCostumeOwnedData GetRootAsCeoCostumeOwnedData(ByteBuffer _bb)
		{
			return GetRootAsCeoCostumeOwnedData(_bb, new CeoCostumeOwnedData());
		}

		public static CeoCostumeOwnedData GetRootAsCeoCostumeOwnedData(ByteBuffer _bb, CeoCostumeOwnedData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public CeoCostumeOwnedData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateDefaultcostumeidx(int defaultcostumeidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, defaultcostumeidx);
				return true;
			}
			return false;
		}

		public bool MutateEquippedcostumeidx(int equippedcostumeidx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, equippedcostumeidx);
				return true;
			}
			return false;
		}

		public CeoCostumeData? Ownedcostumeidxlist(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new CeoCostumeData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<CeoCostumeOwnedData> CreateCeoCostumeOwnedData(FlatBufferBuilder builder, int defaultcostumeidx = 0, int equippedcostumeidx = 0, VectorOffset ownedcostumeidxlistOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			AddOwnedcostumeidxlist(builder, ownedcostumeidxlistOffset);
			AddEquippedcostumeidx(builder, equippedcostumeidx);
			AddDefaultcostumeidx(builder, defaultcostumeidx);
			return EndCeoCostumeOwnedData(builder);
		}

		public static void StartCeoCostumeOwnedData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddDefaultcostumeidx(FlatBufferBuilder builder, int defaultcostumeidx)
		{
			builder.AddInt(0, defaultcostumeidx, 0);
		}

		public static void AddEquippedcostumeidx(FlatBufferBuilder builder, int equippedcostumeidx)
		{
			builder.AddInt(1, equippedcostumeidx, 0);
		}

		public static void AddOwnedcostumeidxlist(FlatBufferBuilder builder, VectorOffset ownedcostumeidxlistOffset)
		{
			builder.AddOffset(2, ownedcostumeidxlistOffset.Value, 0);
		}

		public static VectorOffset CreateOwnedcostumeidxlistVector(FlatBufferBuilder builder, Offset<CeoCostumeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOwnedcostumeidxlistVectorBlock(FlatBufferBuilder builder, Offset<CeoCostumeData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOwnedcostumeidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CeoCostumeData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOwnedcostumeidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOwnedcostumeidxlistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<CeoCostumeOwnedData> EndCeoCostumeOwnedData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<CeoCostumeOwnedData>(o);
		}

		public CeoCostumeOwnedDataT UnPack()
		{
			var _o = new CeoCostumeOwnedDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(CeoCostumeOwnedDataT _o)
		{
			_o.Defaultcostumeidx = this.Defaultcostumeidx;
			_o.Equippedcostumeidx = this.Equippedcostumeidx;
			_o.Ownedcostumeidxlist = new List<CeoCostumeDataT>();
			for (var _j = 0; _j < this.OwnedcostumeidxlistLength; ++_j)
				_o.Ownedcostumeidxlist.Add(this.Ownedcostumeidxlist(_j).HasValue ? this.Ownedcostumeidxlist(_j).Value.UnPack() : null);
		}

		public static Offset<CeoCostumeOwnedData> Pack(FlatBufferBuilder builder, CeoCostumeOwnedDataT _o)
		{
			if (_o == null) return default(Offset<CeoCostumeOwnedData>);
			var _ownedcostumeidxlist = default(VectorOffset);
			if (_o.Ownedcostumeidxlist != null)
			{
				var __ownedcostumeidxlist = new Offset<CeoCostumeData>[_o.Ownedcostumeidxlist.Count];
				for (var _j = 0; _j < _o.Ownedcostumeidxlist.Count; ++_j)
					__ownedcostumeidxlist[_j] = CeoCostumeData.Pack(builder, _o.Ownedcostumeidxlist[_j]);
				_ownedcostumeidxlist = CreateOwnedcostumeidxlistVector(builder, __ownedcostumeidxlist);
			}
			StartCeoCostumeOwnedData(builder);
			AddDefaultcostumeidx(builder, _o.Defaultcostumeidx);
			AddEquippedcostumeidx(builder, _o.Equippedcostumeidx);
			AddOwnedcostumeidxlist(builder, _ownedcostumeidxlist);
			return EndCeoCostumeOwnedData(builder);
		}
	}
}
