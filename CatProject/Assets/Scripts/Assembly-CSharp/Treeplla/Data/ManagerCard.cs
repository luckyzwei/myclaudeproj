using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ManagerCard : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Cardcount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Isopen { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static ManagerCard GetRootAsManagerCard(ByteBuffer _bb)
		{
			return GetRootAsManagerCard(_bb, new ManagerCard());
		}

		public static ManagerCard GetRootAsManagerCard(ByteBuffer _bb, ManagerCard obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public ManagerCard __assign(int _i, ByteBuffer _bb)
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

		public bool MutateCardcount(int cardcount)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, cardcount);
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

		public bool MutateIsopen(bool isopen)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isopen ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<ManagerCard> CreateManagerCard(FlatBufferBuilder builder, int idx = 0, int cardcount = 0, int level = 0, bool isopen = false)
		{
			builder.StartTable(4);
			AddIsopen(builder, isopen);
			AddLevel(builder, level);
			AddCardcount(builder, cardcount);
			AddIdx(builder, idx);
			return EndManagerCard(builder);
		}

		public static void StartManagerCard(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddCardcount(FlatBufferBuilder builder, int cardcount)
		{
			builder.AddInt(1, cardcount, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(2, level, 0);
		}

		public static void AddIsopen(FlatBufferBuilder builder, bool isopen)
		{
			builder.AddBool(3, isopen, false);
		}

		public static Offset<ManagerCard> EndManagerCard(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<ManagerCard>(o);
		}

		public ManagerCardT UnPack()
		{
			var _o = new ManagerCardT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(ManagerCardT _o)
		{
			_o.Idx = this.Idx;
			_o.Cardcount = this.Cardcount;
			_o.Level = this.Level;
			_o.Isopen = this.Isopen;
		}

		public static Offset<ManagerCard> Pack(FlatBufferBuilder builder, ManagerCardT _o)
		{
			if (_o == null) return default(Offset<ManagerCard>);
			StartManagerCard(builder);
			AddIdx(builder, _o.Idx);
			AddCardcount(builder, _o.Cardcount);
			AddLevel(builder, _o.Level);
			AddIsopen(builder, _o.Isopen);
			return EndManagerCard(builder);
		}
	}
}
