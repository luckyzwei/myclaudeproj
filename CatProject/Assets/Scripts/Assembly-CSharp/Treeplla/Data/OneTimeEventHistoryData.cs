using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OneTimeEventHistoryData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Currency => 0;

		public int Level => 0;

		public int Levelexp => 0;

		public int Receivelevel => 0;

		public bool Activebonustheme => false;

		public static void ValidateVersion()
		{
		}

		public static OneTimeEventHistoryData GetRootAsOneTimeEventHistoryData(ByteBuffer _bb)
		{
			return default(OneTimeEventHistoryData);
		}

		public static OneTimeEventHistoryData GetRootAsOneTimeEventHistoryData(ByteBuffer _bb, OneTimeEventHistoryData obj)
		{
			return default(OneTimeEventHistoryData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public OneTimeEventHistoryData __assign(int _i, ByteBuffer _bb)
		{
			return default(OneTimeEventHistoryData);
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

		public bool MutateActivebonustheme(bool activebonustheme)
		{
			return false;
		}

		public static Offset<OneTimeEventHistoryData> CreateOneTimeEventHistoryData(FlatBufferBuilder builder, int idx = 0, int currency = 0, int level = 0, int levelexp = 0, int receivelevel = 0, bool activebonustheme = false)
		{
			return default(Offset<OneTimeEventHistoryData>);
		}

		public static void StartOneTimeEventHistoryData(FlatBufferBuilder builder)
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

		public static void AddActivebonustheme(FlatBufferBuilder builder, bool activebonustheme)
		{
		}

		public static Offset<OneTimeEventHistoryData> EndOneTimeEventHistoryData(FlatBufferBuilder builder)
		{
			return default(Offset<OneTimeEventHistoryData>);
		}

		public OneTimeEventHistoryDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(OneTimeEventHistoryDataT _o)
		{
		}

		public static Offset<OneTimeEventHistoryData> Pack(FlatBufferBuilder builder, OneTimeEventHistoryDataT _o)
		{
			return default(Offset<OneTimeEventHistoryData>);
		}
	}
}
