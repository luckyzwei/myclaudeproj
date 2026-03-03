using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CompanyListRefreshData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Remaincnt => 0;

		public long Lastchargetime => 0L;

		public static void ValidateVersion()
		{
		}

		public static CompanyListRefreshData GetRootAsCompanyListRefreshData(ByteBuffer _bb)
		{
			return default(CompanyListRefreshData);
		}

		public static CompanyListRefreshData GetRootAsCompanyListRefreshData(ByteBuffer _bb, CompanyListRefreshData obj)
		{
			return default(CompanyListRefreshData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public CompanyListRefreshData __assign(int _i, ByteBuffer _bb)
		{
			return default(CompanyListRefreshData);
		}

		public bool MutateRemaincnt(int remaincnt)
		{
			return false;
		}

		public bool MutateLastchargetime(long lastchargetime)
		{
			return false;
		}

		public static Offset<CompanyListRefreshData> CreateCompanyListRefreshData(FlatBufferBuilder builder, int remaincnt = 0, long lastchargetime = 0L)
		{
			return default(Offset<CompanyListRefreshData>);
		}

		public static void StartCompanyListRefreshData(FlatBufferBuilder builder)
		{
		}

		public static void AddRemaincnt(FlatBufferBuilder builder, int remaincnt)
		{
		}

		public static void AddLastchargetime(FlatBufferBuilder builder, long lastchargetime)
		{
		}

		public static Offset<CompanyListRefreshData> EndCompanyListRefreshData(FlatBufferBuilder builder)
		{
			return default(Offset<CompanyListRefreshData>);
		}

		public CompanyListRefreshDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(CompanyListRefreshDataT _o)
		{
		}

		public static Offset<CompanyListRefreshData> Pack(FlatBufferBuilder builder, CompanyListRefreshDataT _o)
		{
			return default(Offset<CompanyListRefreshData>);
		}
	}
}
