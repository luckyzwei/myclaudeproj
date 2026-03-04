using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RichWayData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Richpointlevel { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static RichWayData GetRootAsRichWayData(ByteBuffer _bb)
		{
			return GetRootAsRichWayData(_bb, new RichWayData());
		}

		public static RichWayData GetRootAsRichWayData(ByteBuffer _bb, RichWayData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public RichWayData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateRichpointlevel(int richpointlevel)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, richpointlevel);
				return true;
			}
			return false;
		}

		public static Offset<RichWayData> CreateRichWayData(FlatBufferBuilder builder, int richpointlevel = 0)
		{
			builder.StartTable(1);
			AddRichpointlevel(builder, richpointlevel);
			return EndRichWayData(builder);
		}

		public static void StartRichWayData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		public static void AddRichpointlevel(FlatBufferBuilder builder, int richpointlevel)
		{
			builder.AddInt(0, richpointlevel, 0);
		}

		public static Offset<RichWayData> EndRichWayData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<RichWayData>(o);
		}

		public RichWayDataT UnPack()
		{
			var _o = new RichWayDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(RichWayDataT _o)
		{
			_o.Richpointlevel = this.Richpointlevel;
		}

		public static Offset<RichWayData> Pack(FlatBufferBuilder builder, RichWayDataT _o)
		{
			if (_o == null) return default(Offset<RichWayData>);
			StartRichWayData(builder);
			AddRichpointlevel(builder, _o.Richpointlevel);
			return EndRichWayData(builder);
		}
	}
}
