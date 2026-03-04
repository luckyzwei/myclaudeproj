using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CatstaEventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Value { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Like { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Reward { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static CatstaEventData GetRootAsCatstaEventData(ByteBuffer _bb)
		{
			return GetRootAsCatstaEventData(_bb, new CatstaEventData());
		}

		public static CatstaEventData GetRootAsCatstaEventData(ByteBuffer _bb, CatstaEventData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public CatstaEventData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateValue(int value)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, value);
				return true;
			}
			return false;
		}

		public bool MutateLike(bool like)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(like ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateReward(bool reward)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(reward ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<CatstaEventData> CreateCatstaEventData(FlatBufferBuilder builder, int idx = 0, int value = 0, bool like = false, bool reward = false)
		{
			builder.StartTable(4);
			AddReward(builder, reward);
			AddLike(builder, like);
			AddValue(builder, value);
			AddIdx(builder, idx);
			return EndCatstaEventData(builder);
		}

		public static void StartCatstaEventData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(1, value, 0);
		}

		public static void AddLike(FlatBufferBuilder builder, bool like)
		{
			builder.AddBool(2, like, false);
		}

		public static void AddReward(FlatBufferBuilder builder, bool reward)
		{
			builder.AddBool(3, reward, false);
		}

		public static Offset<CatstaEventData> EndCatstaEventData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<CatstaEventData>(o);
		}

		public CatstaEventDataT UnPack()
		{
			var _o = new CatstaEventDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(CatstaEventDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Value = this.Value;
			_o.Like = this.Like;
			_o.Reward = this.Reward;
		}

		public static Offset<CatstaEventData> Pack(FlatBufferBuilder builder, CatstaEventDataT _o)
		{
			if (_o == null) return default(Offset<CatstaEventData>);
			StartCatstaEventData(builder);
			AddIdx(builder, _o.Idx);
			AddValue(builder, _o.Value);
			AddLike(builder, _o.Like);
			AddReward(builder, _o.Reward);
			return EndCatstaEventData(builder);
		}
	}
}
