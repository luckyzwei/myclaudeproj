using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RichAchieveCount : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Regionidx => 0;

		public int Count => 0;

		public static void ValidateVersion()
		{
		}

		public static RichAchieveCount GetRootAsRichAchieveCount(ByteBuffer _bb)
		{
			return default(RichAchieveCount);
		}

		public static RichAchieveCount GetRootAsRichAchieveCount(ByteBuffer _bb, RichAchieveCount obj)
		{
			return default(RichAchieveCount);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public RichAchieveCount __assign(int _i, ByteBuffer _bb)
		{
			return default(RichAchieveCount);
		}

		public bool MutateRegionidx(int regionidx)
		{
			return false;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public static Offset<RichAchieveCount> CreateRichAchieveCount(FlatBufferBuilder builder, int regionidx = 0, int count = 0)
		{
			return default(Offset<RichAchieveCount>);
		}

		public static void StartRichAchieveCount(FlatBufferBuilder builder)
		{
		}

		public static void AddRegionidx(FlatBufferBuilder builder, int regionidx)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static Offset<RichAchieveCount> EndRichAchieveCount(FlatBufferBuilder builder)
		{
			return default(Offset<RichAchieveCount>);
		}

		public RichAchieveCountT UnPack()
		{
			return null;
		}

		public void UnPackTo(RichAchieveCountT _o)
		{
		}

		public static Offset<RichAchieveCount> Pack(FlatBufferBuilder builder, RichAchieveCountT _o)
		{
			return default(Offset<RichAchieveCount>);
		}
	}
}
