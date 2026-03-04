using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CompanyListRefreshData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Remaincnt { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Lastchargetime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static CompanyListRefreshData GetRootAsCompanyListRefreshData(ByteBuffer _bb)
		{
			return GetRootAsCompanyListRefreshData(_bb, new CompanyListRefreshData());
		}

		public static CompanyListRefreshData GetRootAsCompanyListRefreshData(ByteBuffer _bb, CompanyListRefreshData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public CompanyListRefreshData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateRemaincnt(int remaincnt)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, remaincnt);
				return true;
			}
			return false;
		}

		public bool MutateLastchargetime(long lastchargetime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastchargetime);
				return true;
			}
			return false;
		}

		public static Offset<CompanyListRefreshData> CreateCompanyListRefreshData(FlatBufferBuilder builder, int remaincnt = 0, long lastchargetime = 0L)
		{
			builder.StartTable(2);
			AddLastchargetime(builder, lastchargetime);
			AddRemaincnt(builder, remaincnt);
			return EndCompanyListRefreshData(builder);
		}

		public static void StartCompanyListRefreshData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddRemaincnt(FlatBufferBuilder builder, int remaincnt)
		{
			builder.AddInt(0, remaincnt, 0);
		}

		public static void AddLastchargetime(FlatBufferBuilder builder, long lastchargetime)
		{
			builder.AddLong(1, lastchargetime, 0);
		}

		public static Offset<CompanyListRefreshData> EndCompanyListRefreshData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<CompanyListRefreshData>(o);
		}

		public CompanyListRefreshDataT UnPack()
		{
			var _o = new CompanyListRefreshDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(CompanyListRefreshDataT _o)
		{
			_o.Remaincnt = this.Remaincnt;
			_o.Lastchargetime = this.Lastchargetime;
		}

		public static Offset<CompanyListRefreshData> Pack(FlatBufferBuilder builder, CompanyListRefreshDataT _o)
		{
			if (_o == null) return default(Offset<CompanyListRefreshData>);
			StartCompanyListRefreshData(builder);
			AddRemaincnt(builder, _o.Remaincnt);
			AddLastchargetime(builder, _o.Lastchargetime);
			return EndCompanyListRefreshData(builder);
		}
	}
}
