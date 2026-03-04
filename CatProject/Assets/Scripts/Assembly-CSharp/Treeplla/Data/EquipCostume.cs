using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EquipCostume : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Head { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Body { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Hand { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static EquipCostume GetRootAsEquipCostume(ByteBuffer _bb)
		{
			return GetRootAsEquipCostume(_bb, new EquipCostume());
		}

		public static EquipCostume GetRootAsEquipCostume(ByteBuffer _bb, EquipCostume obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public EquipCostume __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateHead(int head)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, head);
				return true;
			}
			return false;
		}

		public bool MutateBody(int body)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, body);
				return true;
			}
			return false;
		}

		public bool MutateHand(int hand)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, hand);
				return true;
			}
			return false;
		}

		public static Offset<EquipCostume> CreateEquipCostume(FlatBufferBuilder builder, int head = 0, int body = 0, int hand = 0)
		{
			builder.StartTable(3);
			AddHand(builder, hand);
			AddBody(builder, body);
			AddHead(builder, head);
			return EndEquipCostume(builder);
		}

		public static void StartEquipCostume(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddHead(FlatBufferBuilder builder, int head)
		{
			builder.AddInt(0, head, 0);
		}

		public static void AddBody(FlatBufferBuilder builder, int body)
		{
			builder.AddInt(1, body, 0);
		}

		public static void AddHand(FlatBufferBuilder builder, int hand)
		{
			builder.AddInt(2, hand, 0);
		}

		public static Offset<EquipCostume> EndEquipCostume(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<EquipCostume>(o);
		}

		public EquipCostumeT UnPack()
		{
			var _o = new EquipCostumeT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(EquipCostumeT _o)
		{
			_o.Head = this.Head;
			_o.Body = this.Body;
			_o.Hand = this.Hand;
		}

		public static Offset<EquipCostume> Pack(FlatBufferBuilder builder, EquipCostumeT _o)
		{
			if (_o == null) return default(Offset<EquipCostume>);
			StartEquipCostume(builder);
			AddHead(builder, _o.Head);
			AddBody(builder, _o.Body);
			AddHand(builder, _o.Hand);
			return EndEquipCostume(builder);
		}
	}
}
