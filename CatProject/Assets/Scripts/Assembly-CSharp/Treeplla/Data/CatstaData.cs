using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CatstaData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Order { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Type { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Idx { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Like { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Reward { get { int o = __p.__offset(12); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static CatstaData GetRootAsCatstaData(ByteBuffer _bb)
		{
			return GetRootAsCatstaData(_bb, new CatstaData());
		}

		public static CatstaData GetRootAsCatstaData(ByteBuffer _bb, CatstaData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public CatstaData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateOrder(int order)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, order);
				return true;
			}
			return false;
		}

		public bool MutateType(int type)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, type);
				return true;
			}
			return false;
		}

		public bool MutateIdx(int idx)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, idx);
				return true;
			}
			return false;
		}

		public bool MutateLike(bool like)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(like ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateReward(bool reward)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(reward ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<CatstaData> CreateCatstaData(FlatBufferBuilder builder, int order = 0, int type = 0, int idx = 0, bool like = false, bool reward = false)
		{
			builder.StartTable(5);
			AddReward(builder, reward);
			AddLike(builder, like);
			AddIdx(builder, idx);
			AddType(builder, type);
			AddOrder(builder, order);
			return EndCatstaData(builder);
		}

		public static void StartCatstaData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddOrder(FlatBufferBuilder builder, int order)
		{
			builder.AddInt(0, order, 0);
		}

		public static void AddType(FlatBufferBuilder builder, int type)
		{
			builder.AddInt(1, type, 0);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(2, idx, 0);
		}

		public static void AddLike(FlatBufferBuilder builder, bool like)
		{
			builder.AddBool(3, like, false);
		}

		public static void AddReward(FlatBufferBuilder builder, bool reward)
		{
			builder.AddBool(4, reward, false);
		}

		public static Offset<CatstaData> EndCatstaData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<CatstaData>(o);
		}

		public CatstaDataT UnPack()
		{
			var _o = new CatstaDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(CatstaDataT _o)
		{
			_o.Order = this.Order;
			_o.Type = this.Type;
			_o.Idx = this.Idx;
			_o.Like = this.Like;
			_o.Reward = this.Reward;
		}

		public static Offset<CatstaData> Pack(FlatBufferBuilder builder, CatstaDataT _o)
		{
			if (_o == null) return default(Offset<CatstaData>);
			StartCatstaData(builder);
			AddOrder(builder, _o.Order);
			AddType(builder, _o.Type);
			AddIdx(builder, _o.Idx);
			AddLike(builder, _o.Like);
			AddReward(builder, _o.Reward);
			return EndCatstaData(builder);
		}
	}
}
