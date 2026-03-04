using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SellerData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Itemidx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Grade { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Offorder { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Soldout { get { int o = __p.__offset(12); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SellerData GetRootAsSellerData(ByteBuffer _bb)
		{
			return GetRootAsSellerData(_bb, new SellerData());
		}

		public static SellerData GetRootAsSellerData(ByteBuffer _bb, SellerData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SellerData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateItemidx(int itemidx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, itemidx);
				return true;
			}
			return false;
		}

		public bool MutateGrade(int grade)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, grade);
				return true;
			}
			return false;
		}

		public bool MutateOfforder(int offorder)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, offorder);
				return true;
			}
			return false;
		}

		public bool MutateSoldout(bool soldout)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(soldout ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<SellerData> CreateSellerData(FlatBufferBuilder builder, int idx = 0, int itemidx = 0, int grade = 0, int offorder = 0, bool soldout = false)
		{
			builder.StartTable(5);
			AddSoldout(builder, soldout);
			AddOfforder(builder, offorder);
			AddGrade(builder, grade);
			AddItemidx(builder, itemidx);
			AddIdx(builder, idx);
			return EndSellerData(builder);
		}

		public static void StartSellerData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddItemidx(FlatBufferBuilder builder, int itemidx)
		{
			builder.AddInt(1, itemidx, 0);
		}

		public static void AddGrade(FlatBufferBuilder builder, int grade)
		{
			builder.AddInt(2, grade, 0);
		}

		public static void AddOfforder(FlatBufferBuilder builder, int offorder)
		{
			builder.AddInt(3, offorder, 0);
		}

		public static void AddSoldout(FlatBufferBuilder builder, bool soldout)
		{
			builder.AddBool(4, soldout, false);
		}

		public static Offset<SellerData> EndSellerData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SellerData>(o);
		}

		public SellerDataT UnPack()
		{
			var _o = new SellerDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SellerDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Itemidx = this.Itemidx;
			_o.Grade = this.Grade;
			_o.Offorder = this.Offorder;
			_o.Soldout = this.Soldout;
		}

		public static Offset<SellerData> Pack(FlatBufferBuilder builder, SellerDataT _o)
		{
			if (_o == null) return default(Offset<SellerData>);
			StartSellerData(builder);
			AddIdx(builder, _o.Idx);
			AddItemidx(builder, _o.Itemidx);
			AddGrade(builder, _o.Grade);
			AddOfforder(builder, _o.Offorder);
			AddSoldout(builder, _o.Soldout);
			return EndSellerData(builder);
		}
	}
}
