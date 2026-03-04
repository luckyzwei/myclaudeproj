using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BoostTokenData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Tokeidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Endtime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BoostTokenData GetRootAsBoostTokenData(ByteBuffer _bb)
		{
			return GetRootAsBoostTokenData(_bb, new BoostTokenData());
		}

		public static BoostTokenData GetRootAsBoostTokenData(ByteBuffer _bb, BoostTokenData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BoostTokenData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateTokeidx(int tokeidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, tokeidx);
				return true;
			}
			return false;
		}

		public bool MutateEndtime(long endtime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, endtime);
				return true;
			}
			return false;
		}

		public static Offset<BoostTokenData> CreateBoostTokenData(FlatBufferBuilder builder, int tokeidx = 0, long endtime = 0L)
		{
			builder.StartTable(2);
			AddEndtime(builder, endtime);
			AddTokeidx(builder, tokeidx);
			return EndBoostTokenData(builder);
		}

		public static void StartBoostTokenData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddTokeidx(FlatBufferBuilder builder, int tokeidx)
		{
			builder.AddInt(0, tokeidx, 0);
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
			builder.AddLong(1, endtime, 0);
		}

		public static Offset<BoostTokenData> EndBoostTokenData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BoostTokenData>(o);
		}

		public BoostTokenDataT UnPack()
		{
			var _o = new BoostTokenDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BoostTokenDataT _o)
		{
			_o.Tokeidx = this.Tokeidx;
			_o.Endtime = this.Endtime;
		}

		public static Offset<BoostTokenData> Pack(FlatBufferBuilder builder, BoostTokenDataT _o)
		{
			if (_o == null) return default(Offset<BoostTokenData>);
			StartBoostTokenData(builder);
			AddTokeidx(builder, _o.Tokeidx);
			AddEndtime(builder, _o.Endtime);
			return EndBoostTokenData(builder);
		}
	}
}
