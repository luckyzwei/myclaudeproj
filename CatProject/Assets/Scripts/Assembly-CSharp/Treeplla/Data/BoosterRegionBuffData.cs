using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BoosterRegionBuffData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Boosteridx => 0;

		public int Boosteractiveregionidx => 0;

		public int Boosterremaintimesec => 0;

		public long Boosternextresettime => 0L;

		public int Boosterdailyusecount => 0;

		public static void ValidateVersion()
		{
		}

		public static BoosterRegionBuffData GetRootAsBoosterRegionBuffData(ByteBuffer _bb)
		{
			return default(BoosterRegionBuffData);
		}

		public static BoosterRegionBuffData GetRootAsBoosterRegionBuffData(ByteBuffer _bb, BoosterRegionBuffData obj)
		{
			return default(BoosterRegionBuffData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BoosterRegionBuffData __assign(int _i, ByteBuffer _bb)
		{
			return default(BoosterRegionBuffData);
		}

		public bool MutateBoosteridx(int boosteridx)
		{
			return false;
		}

		public bool MutateBoosteractiveregionidx(int boosteractiveregionidx)
		{
			return false;
		}

		public bool MutateBoosterremaintimesec(int boosterremaintimesec)
		{
			return false;
		}

		public bool MutateBoosternextresettime(long boosternextresettime)
		{
			return false;
		}

		public bool MutateBoosterdailyusecount(int boosterdailyusecount)
		{
			return false;
		}

		public static Offset<BoosterRegionBuffData> CreateBoosterRegionBuffData(FlatBufferBuilder builder, int boosteridx = 0, int boosteractiveregionidx = 0, int boosterremaintimesec = 0, long boosternextresettime = 0L, int boosterdailyusecount = 0)
		{
			return default(Offset<BoosterRegionBuffData>);
		}

		public static void StartBoosterRegionBuffData(FlatBufferBuilder builder)
		{
		}

		public static void AddBoosteridx(FlatBufferBuilder builder, int boosteridx)
		{
		}

		public static void AddBoosteractiveregionidx(FlatBufferBuilder builder, int boosteractiveregionidx)
		{
		}

		public static void AddBoosterremaintimesec(FlatBufferBuilder builder, int boosterremaintimesec)
		{
		}

		public static void AddBoosternextresettime(FlatBufferBuilder builder, long boosternextresettime)
		{
		}

		public static void AddBoosterdailyusecount(FlatBufferBuilder builder, int boosterdailyusecount)
		{
		}

		public static Offset<BoosterRegionBuffData> EndBoosterRegionBuffData(FlatBufferBuilder builder)
		{
			return default(Offset<BoosterRegionBuffData>);
		}

		public BoosterRegionBuffDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BoosterRegionBuffDataT _o)
		{
		}

		public static Offset<BoosterRegionBuffData> Pack(FlatBufferBuilder builder, BoosterRegionBuffDataT _o)
		{
			return default(Offset<BoosterRegionBuffData>);
		}
	}
}
