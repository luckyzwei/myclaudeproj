using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EndlessOfferData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Endlessidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Curorderidx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Endtime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Lastautoshowtime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Buycount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static EndlessOfferData GetRootAsEndlessOfferData(ByteBuffer _bb)
		{
			return GetRootAsEndlessOfferData(_bb, new EndlessOfferData());
		}

		public static EndlessOfferData GetRootAsEndlessOfferData(ByteBuffer _bb, EndlessOfferData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public EndlessOfferData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateEndlessidx(int endlessidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, endlessidx);
				return true;
			}
			return false;
		}

		public bool MutateCurorderidx(int curorderidx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, curorderidx);
				return true;
			}
			return false;
		}

		public bool MutateEndtime(long endtime)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, endtime);
				return true;
			}
			return false;
		}

		public bool MutateLastautoshowtime(long lastautoshowtime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastautoshowtime);
				return true;
			}
			return false;
		}

		public bool MutateBuycount(int buycount)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, buycount);
				return true;
			}
			return false;
		}

		public static Offset<EndlessOfferData> CreateEndlessOfferData(FlatBufferBuilder builder, int endlessidx = 0, int curorderidx = 0, long endtime = 0L, long lastautoshowtime = 0L, int buycount = 0)
		{
			builder.StartTable(5);
			AddBuycount(builder, buycount);
			AddLastautoshowtime(builder, lastautoshowtime);
			AddEndtime(builder, endtime);
			AddCurorderidx(builder, curorderidx);
			AddEndlessidx(builder, endlessidx);
			return EndEndlessOfferData(builder);
		}

		public static void StartEndlessOfferData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddEndlessidx(FlatBufferBuilder builder, int endlessidx)
		{
			builder.AddInt(0, endlessidx, 0);
		}

		public static void AddCurorderidx(FlatBufferBuilder builder, int curorderidx)
		{
			builder.AddInt(1, curorderidx, 0);
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
			builder.AddLong(2, endtime, 0);
		}

		public static void AddLastautoshowtime(FlatBufferBuilder builder, long lastautoshowtime)
		{
			builder.AddLong(3, lastautoshowtime, 0);
		}

		public static void AddBuycount(FlatBufferBuilder builder, int buycount)
		{
			builder.AddInt(4, buycount, 0);
		}

		public static Offset<EndlessOfferData> EndEndlessOfferData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<EndlessOfferData>(o);
		}

		public EndlessOfferDataT UnPack()
		{
			var _o = new EndlessOfferDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(EndlessOfferDataT _o)
		{
			_o.Endlessidx = this.Endlessidx;
			_o.Curorderidx = this.Curorderidx;
			_o.Endtime = this.Endtime;
			_o.Lastautoshowtime = this.Lastautoshowtime;
			_o.Buycount = this.Buycount;
		}

		public static Offset<EndlessOfferData> Pack(FlatBufferBuilder builder, EndlessOfferDataT _o)
		{
			if (_o == null) return default(Offset<EndlessOfferData>);
			StartEndlessOfferData(builder);
			AddEndlessidx(builder, _o.Endlessidx);
			AddCurorderidx(builder, _o.Curorderidx);
			AddEndtime(builder, _o.Endtime);
			AddLastautoshowtime(builder, _o.Lastautoshowtime);
			AddBuycount(builder, _o.Buycount);
			return EndEndlessOfferData(builder);
		}
	}
}
