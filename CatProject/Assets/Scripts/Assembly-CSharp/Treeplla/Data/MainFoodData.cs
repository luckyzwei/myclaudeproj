using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MainFoodData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Foodslotidx => 0;

		public long Resettime => 0L;

		public static void ValidateVersion()
		{
		}

		public static MainFoodData GetRootAsMainFoodData(ByteBuffer _bb)
		{
			return default(MainFoodData);
		}

		public static MainFoodData GetRootAsMainFoodData(ByteBuffer _bb, MainFoodData obj)
		{
			return default(MainFoodData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public MainFoodData __assign(int _i, ByteBuffer _bb)
		{
			return default(MainFoodData);
		}

		public bool MutateFoodslotidx(int foodslotidx)
		{
			return false;
		}

		public bool MutateResettime(long resettime)
		{
			return false;
		}

		public static Offset<MainFoodData> CreateMainFoodData(FlatBufferBuilder builder, int foodslotidx = 0, long resettime = 0L)
		{
			return default(Offset<MainFoodData>);
		}

		public static void StartMainFoodData(FlatBufferBuilder builder)
		{
		}

		public static void AddFoodslotidx(FlatBufferBuilder builder, int foodslotidx)
		{
		}

		public static void AddResettime(FlatBufferBuilder builder, long resettime)
		{
		}

		public static Offset<MainFoodData> EndMainFoodData(FlatBufferBuilder builder)
		{
			return default(Offset<MainFoodData>);
		}

		public MainFoodDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(MainFoodDataT _o)
		{
		}

		public static Offset<MainFoodData> Pack(FlatBufferBuilder builder, MainFoodDataT _o)
		{
			return default(Offset<MainFoodData>);
		}
	}
}
