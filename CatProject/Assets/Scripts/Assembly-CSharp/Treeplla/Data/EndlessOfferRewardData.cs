using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EndlessOfferRewardData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Endlessidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Orderidx { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Isbuy { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static EndlessOfferRewardData GetRootAsEndlessOfferRewardData(ByteBuffer _bb)
		{
			return GetRootAsEndlessOfferRewardData(_bb, new EndlessOfferRewardData());
		}

		public static EndlessOfferRewardData GetRootAsEndlessOfferRewardData(ByteBuffer _bb, EndlessOfferRewardData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public EndlessOfferRewardData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateOrderidx(int orderidx)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, orderidx);
				return true;
			}
			return false;
		}

		public bool MutateIsbuy(bool isbuy)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isbuy ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<EndlessOfferRewardData> CreateEndlessOfferRewardData(FlatBufferBuilder builder, int endlessidx = 0, int orderidx = 0, bool isbuy = false)
		{
			builder.StartTable(3);
			AddIsbuy(builder, isbuy);
			AddOrderidx(builder, orderidx);
			AddEndlessidx(builder, endlessidx);
			return EndEndlessOfferRewardData(builder);
		}

		public static void StartEndlessOfferRewardData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddEndlessidx(FlatBufferBuilder builder, int endlessidx)
		{
			builder.AddInt(0, endlessidx, 0);
		}

		public static void AddOrderidx(FlatBufferBuilder builder, int orderidx)
		{
			builder.AddInt(1, orderidx, 0);
		}

		public static void AddIsbuy(FlatBufferBuilder builder, bool isbuy)
		{
			builder.AddBool(2, isbuy, false);
		}

		public static Offset<EndlessOfferRewardData> EndEndlessOfferRewardData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<EndlessOfferRewardData>(o);
		}

		public EndlessOfferRewardDataT UnPack()
		{
			var _o = new EndlessOfferRewardDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(EndlessOfferRewardDataT _o)
		{
			_o.Endlessidx = this.Endlessidx;
			_o.Orderidx = this.Orderidx;
			_o.Isbuy = this.Isbuy;
		}

		public static Offset<EndlessOfferRewardData> Pack(FlatBufferBuilder builder, EndlessOfferRewardDataT _o)
		{
			if (_o == null) return default(Offset<EndlessOfferRewardData>);
			StartEndlessOfferRewardData(builder);
			AddEndlessidx(builder, _o.Endlessidx);
			AddOrderidx(builder, _o.Orderidx);
			AddIsbuy(builder, _o.Isbuy);
			return EndEndlessOfferRewardData(builder);
		}
	}
}
