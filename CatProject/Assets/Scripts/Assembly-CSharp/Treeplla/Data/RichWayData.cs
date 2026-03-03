using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RichWayData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Richpointlevel => 0;

		public static void ValidateVersion()
		{
		}

		public static RichWayData GetRootAsRichWayData(ByteBuffer _bb)
		{
			return default(RichWayData);
		}

		public static RichWayData GetRootAsRichWayData(ByteBuffer _bb, RichWayData obj)
		{
			return default(RichWayData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public RichWayData __assign(int _i, ByteBuffer _bb)
		{
			return default(RichWayData);
		}

		public bool MutateRichpointlevel(int richpointlevel)
		{
			return false;
		}

		public static Offset<RichWayData> CreateRichWayData(FlatBufferBuilder builder, int richpointlevel = 0)
		{
			return default(Offset<RichWayData>);
		}

		public static void StartRichWayData(FlatBufferBuilder builder)
		{
		}

		public static void AddRichpointlevel(FlatBufferBuilder builder, int richpointlevel)
		{
		}

		public static Offset<RichWayData> EndRichWayData(FlatBufferBuilder builder)
		{
			return default(Offset<RichWayData>);
		}

		public RichWayDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(RichWayDataT _o)
		{
		}

		public static Offset<RichWayData> Pack(FlatBufferBuilder builder, RichWayDataT _o)
		{
			return default(Offset<RichWayData>);
		}
	}
}
