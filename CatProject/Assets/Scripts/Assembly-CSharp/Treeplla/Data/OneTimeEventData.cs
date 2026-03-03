using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OneTimeEventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Currency => 0;

		public int Level => 0;

		public int Levelexp => 0;

		public int Receivelevel => 0;

		public int Companyresetcount => 0;

		public long Companyresettime => 0L;

		public bool Activebonustheme => false;

		public static void ValidateVersion()
		{
		}

		public static OneTimeEventData GetRootAsOneTimeEventData(ByteBuffer _bb)
		{
			return default(OneTimeEventData);
		}

		public static OneTimeEventData GetRootAsOneTimeEventData(ByteBuffer _bb, OneTimeEventData obj)
		{
			return default(OneTimeEventData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public OneTimeEventData __assign(int _i, ByteBuffer _bb)
		{
			return default(OneTimeEventData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateCurrency(int currency)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateLevelexp(int levelexp)
		{
			return false;
		}

		public bool MutateReceivelevel(int receivelevel)
		{
			return false;
		}

		public bool MutateCompanyresetcount(int companyresetcount)
		{
			return false;
		}

		public bool MutateCompanyresettime(long companyresettime)
		{
			return false;
		}

		public bool MutateActivebonustheme(bool activebonustheme)
		{
			return false;
		}

		public static Offset<OneTimeEventData> CreateOneTimeEventData(FlatBufferBuilder builder, int idx = 0, int currency = 0, int level = 0, int levelexp = 0, int receivelevel = 0, int companyresetcount = 0, long companyresettime = 0L, bool activebonustheme = false)
		{
			return default(Offset<OneTimeEventData>);
		}

		public static void StartOneTimeEventData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddCurrency(FlatBufferBuilder builder, int currency)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddLevelexp(FlatBufferBuilder builder, int levelexp)
		{
		}

		public static void AddReceivelevel(FlatBufferBuilder builder, int receivelevel)
		{
		}

		public static void AddCompanyresetcount(FlatBufferBuilder builder, int companyresetcount)
		{
		}

		public static void AddCompanyresettime(FlatBufferBuilder builder, long companyresettime)
		{
		}

		public static void AddActivebonustheme(FlatBufferBuilder builder, bool activebonustheme)
		{
		}

		public static Offset<OneTimeEventData> EndOneTimeEventData(FlatBufferBuilder builder)
		{
			return default(Offset<OneTimeEventData>);
		}

		public OneTimeEventDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(OneTimeEventDataT _o)
		{
		}

		public static Offset<OneTimeEventData> Pack(FlatBufferBuilder builder, OneTimeEventDataT _o)
		{
			return default(Offset<OneTimeEventData>);
		}
	}
}
