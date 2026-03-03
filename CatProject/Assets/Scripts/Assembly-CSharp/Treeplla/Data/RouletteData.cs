using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RouletteData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public long Nextspintime => 0L;

		public int Luckydrawcount => 0;

		public bool Havefreespin => false;

		public static void ValidateVersion()
		{
		}

		public static RouletteData GetRootAsRouletteData(ByteBuffer _bb)
		{
			return default(RouletteData);
		}

		public static RouletteData GetRootAsRouletteData(ByteBuffer _bb, RouletteData obj)
		{
			return default(RouletteData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public RouletteData __assign(int _i, ByteBuffer _bb)
		{
			return default(RouletteData);
		}

		public bool MutateNextspintime(long nextspintime)
		{
			return false;
		}

		public bool MutateLuckydrawcount(int luckydrawcount)
		{
			return false;
		}

		public bool MutateHavefreespin(bool havefreespin)
		{
			return false;
		}

		public static Offset<RouletteData> CreateRouletteData(FlatBufferBuilder builder, long nextspintime = 0L, int luckydrawcount = 0, bool havefreespin = true)
		{
			return default(Offset<RouletteData>);
		}

		public static void StartRouletteData(FlatBufferBuilder builder)
		{
		}

		public static void AddNextspintime(FlatBufferBuilder builder, long nextspintime)
		{
		}

		public static void AddLuckydrawcount(FlatBufferBuilder builder, int luckydrawcount)
		{
		}

		public static void AddHavefreespin(FlatBufferBuilder builder, bool havefreespin)
		{
		}

		public static Offset<RouletteData> EndRouletteData(FlatBufferBuilder builder)
		{
			return default(Offset<RouletteData>);
		}

		public RouletteDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(RouletteDataT _o)
		{
		}

		public static Offset<RouletteData> Pack(FlatBufferBuilder builder, RouletteDataT _o)
		{
			return default(Offset<RouletteData>);
		}
	}
}
