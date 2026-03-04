using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BoosterBuffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Boosteridx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Totalusecount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int BoosterregionbuffdataLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Boosterticketuseactive { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BoosterBuffData GetRootAsBoosterBuffData(ByteBuffer _bb)
		{
			return GetRootAsBoosterBuffData(_bb, new BoosterBuffData());
		}

		public static BoosterBuffData GetRootAsBoosterBuffData(ByteBuffer _bb, BoosterBuffData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BoosterBuffData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateBoosteridx(int boosteridx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, boosteridx);
				return true;
			}
			return false;
		}

		public bool MutateTotalusecount(int totalusecount)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, totalusecount);
				return true;
			}
			return false;
		}

		public BoosterRegionBuffData? Boosterregionbuffdata(int j)
		{
			int o = __p.__offset(8);
			return o != 0 ? (new BoosterRegionBuffData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateBoosterticketuseactive(bool boosterticketuseactive)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(boosterticketuseactive ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<BoosterBuffData> CreateBoosterBuffData(FlatBufferBuilder builder, int boosteridx = 0, int totalusecount = 0, VectorOffset boosterregionbuffdataOffset = default(VectorOffset), bool boosterticketuseactive = true)
		{
			builder.StartTable(4);
			AddBoosterticketuseactive(builder, boosterticketuseactive);
			AddBoosterregionbuffdata(builder, boosterregionbuffdataOffset);
			AddTotalusecount(builder, totalusecount);
			AddBoosteridx(builder, boosteridx);
			return EndBoosterBuffData(builder);
		}

		public static void StartBoosterBuffData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddBoosteridx(FlatBufferBuilder builder, int boosteridx)
		{
			builder.AddInt(0, boosteridx, 0);
		}

		public static void AddTotalusecount(FlatBufferBuilder builder, int totalusecount)
		{
			builder.AddInt(1, totalusecount, 0);
		}

		public static void AddBoosterregionbuffdata(FlatBufferBuilder builder, VectorOffset boosterregionbuffdataOffset)
		{
			builder.AddOffset(2, boosterregionbuffdataOffset.Value, 0);
		}

		public static VectorOffset CreateBoosterregionbuffdataVector(FlatBufferBuilder builder, Offset<BoosterRegionBuffData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateBoosterregionbuffdataVectorBlock(FlatBufferBuilder builder, Offset<BoosterRegionBuffData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBoosterregionbuffdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<BoosterRegionBuffData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateBoosterregionbuffdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartBoosterregionbuffdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddBoosterticketuseactive(FlatBufferBuilder builder, bool boosterticketuseactive)
		{
			builder.AddBool(3, boosterticketuseactive, false);
		}

		public static Offset<BoosterBuffData> EndBoosterBuffData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BoosterBuffData>(o);
		}

		public BoosterBuffDataT UnPack()
		{
			var _o = new BoosterBuffDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BoosterBuffDataT _o)
		{
			_o.Boosteridx = this.Boosteridx;
			_o.Totalusecount = this.Totalusecount;
			_o.Boosterregionbuffdata = new List<BoosterRegionBuffDataT>();
			for (var _j = 0; _j < this.BoosterregionbuffdataLength; ++_j)
				_o.Boosterregionbuffdata.Add(this.Boosterregionbuffdata(_j).HasValue ? this.Boosterregionbuffdata(_j).Value.UnPack() : null);
			_o.Boosterticketuseactive = this.Boosterticketuseactive;
		}

		public static Offset<BoosterBuffData> Pack(FlatBufferBuilder builder, BoosterBuffDataT _o)
		{
			if (_o == null) return default(Offset<BoosterBuffData>);
			var _boosterregionbuffdata = default(VectorOffset);
			if (_o.Boosterregionbuffdata != null)
			{
				var __boosterregionbuffdata = new Offset<BoosterRegionBuffData>[_o.Boosterregionbuffdata.Count];
				for (var _j = 0; _j < _o.Boosterregionbuffdata.Count; ++_j)
					__boosterregionbuffdata[_j] = BoosterRegionBuffData.Pack(builder, _o.Boosterregionbuffdata[_j]);
				_boosterregionbuffdata = CreateBoosterregionbuffdataVector(builder, __boosterregionbuffdata);
			}
			StartBoosterBuffData(builder);
			AddBoosteridx(builder, _o.Boosteridx);
			AddTotalusecount(builder, _o.Totalusecount);
			AddBoosterregionbuffdata(builder, _boosterregionbuffdata);
			AddBoosterticketuseactive(builder, _o.Boosterticketuseactive);
			return EndBoosterBuffData(builder);
		}
	}
}
