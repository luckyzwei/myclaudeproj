using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FactoryOrderSlot : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Slot { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Isopen { get { int o = __p.__offset(6); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Orderproduct { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Ordervalue { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Refreshtime { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Charactericonidx { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Charactertalkidx { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static FactoryOrderSlot GetRootAsFactoryOrderSlot(ByteBuffer _bb)
		{
			return GetRootAsFactoryOrderSlot(_bb, new FactoryOrderSlot());
		}

		public static FactoryOrderSlot GetRootAsFactoryOrderSlot(ByteBuffer _bb, FactoryOrderSlot obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public FactoryOrderSlot __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSlot(int slot)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, slot);
				return true;
			}
			return false;
		}

		public bool MutateIsopen(bool isopen)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isopen ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateOrderproduct(int orderproduct)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, orderproduct);
				return true;
			}
			return false;
		}

		public bool MutateOrdervalue(int ordervalue)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, ordervalue);
				return true;
			}
			return false;
		}

		public bool MutateRefreshtime(long refreshtime)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, refreshtime);
				return true;
			}
			return false;
		}

		public bool MutateCharactericonidx(int charactericonidx)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, charactericonidx);
				return true;
			}
			return false;
		}

		public bool MutateCharactertalkidx(int charactertalkidx)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, charactertalkidx);
				return true;
			}
			return false;
		}

		public static Offset<FactoryOrderSlot> CreateFactoryOrderSlot(FlatBufferBuilder builder, int slot = 0, bool isopen = false, int orderproduct = 0, int ordervalue = 0, long refreshtime = 0L, int charactericonidx = 0, int charactertalkidx = 0)
		{
			builder.StartTable(7);
			AddCharactertalkidx(builder, charactertalkidx);
			AddCharactericonidx(builder, charactericonidx);
			AddRefreshtime(builder, refreshtime);
			AddOrdervalue(builder, ordervalue);
			AddOrderproduct(builder, orderproduct);
			AddIsopen(builder, isopen);
			AddSlot(builder, slot);
			return EndFactoryOrderSlot(builder);
		}

		public static void StartFactoryOrderSlot(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		public static void AddSlot(FlatBufferBuilder builder, int slot)
		{
			builder.AddInt(0, slot, 0);
		}

		public static void AddIsopen(FlatBufferBuilder builder, bool isopen)
		{
			builder.AddBool(1, isopen, false);
		}

		public static void AddOrderproduct(FlatBufferBuilder builder, int orderproduct)
		{
			builder.AddInt(2, orderproduct, 0);
		}

		public static void AddOrdervalue(FlatBufferBuilder builder, int ordervalue)
		{
			builder.AddInt(3, ordervalue, 0);
		}

		public static void AddRefreshtime(FlatBufferBuilder builder, long refreshtime)
		{
			builder.AddLong(4, refreshtime, 0);
		}

		public static void AddCharactericonidx(FlatBufferBuilder builder, int charactericonidx)
		{
			builder.AddInt(5, charactericonidx, 0);
		}

		public static void AddCharactertalkidx(FlatBufferBuilder builder, int charactertalkidx)
		{
			builder.AddInt(6, charactertalkidx, 0);
		}

		public static Offset<FactoryOrderSlot> EndFactoryOrderSlot(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<FactoryOrderSlot>(o);
		}

		public FactoryOrderSlotT UnPack()
		{
			var _o = new FactoryOrderSlotT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(FactoryOrderSlotT _o)
		{
			_o.Slot = this.Slot;
			_o.Isopen = this.Isopen;
			_o.Orderproduct = this.Orderproduct;
			_o.Ordervalue = this.Ordervalue;
			_o.Refreshtime = this.Refreshtime;
			_o.Charactericonidx = this.Charactericonidx;
			_o.Charactertalkidx = this.Charactertalkidx;
		}

		public static Offset<FactoryOrderSlot> Pack(FlatBufferBuilder builder, FactoryOrderSlotT _o)
		{
			if (_o == null) return default(Offset<FactoryOrderSlot>);
			StartFactoryOrderSlot(builder);
			AddSlot(builder, _o.Slot);
			AddIsopen(builder, _o.Isopen);
			AddOrderproduct(builder, _o.Orderproduct);
			AddOrdervalue(builder, _o.Ordervalue);
			AddRefreshtime(builder, _o.Refreshtime);
			AddCharactericonidx(builder, _o.Charactericonidx);
			AddCharactertalkidx(builder, _o.Charactertalkidx);
			return EndFactoryOrderSlot(builder);
		}
	}
}
