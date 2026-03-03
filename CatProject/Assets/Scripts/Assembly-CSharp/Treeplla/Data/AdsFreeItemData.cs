using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AdsFreeItemData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Itemidx => 0;

		public int Viewcount => 0;

		public long Lastviewtime => 0L;

		public static void ValidateVersion()
		{
		}

		public static AdsFreeItemData GetRootAsAdsFreeItemData(ByteBuffer _bb)
		{
			return default(AdsFreeItemData);
		}

		public static AdsFreeItemData GetRootAsAdsFreeItemData(ByteBuffer _bb, AdsFreeItemData obj)
		{
			return default(AdsFreeItemData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AdsFreeItemData __assign(int _i, ByteBuffer _bb)
		{
			return default(AdsFreeItemData);
		}

		public bool MutateItemidx(int itemidx)
		{
			return false;
		}

		public bool MutateViewcount(int viewcount)
		{
			return false;
		}

		public bool MutateLastviewtime(long lastviewtime)
		{
			return false;
		}

		public static Offset<AdsFreeItemData> CreateAdsFreeItemData(FlatBufferBuilder builder, int itemidx = 0, int viewcount = 0, long lastviewtime = 0L)
		{
			return default(Offset<AdsFreeItemData>);
		}

		public static void StartAdsFreeItemData(FlatBufferBuilder builder)
		{
		}

		public static void AddItemidx(FlatBufferBuilder builder, int itemidx)
		{
		}

		public static void AddViewcount(FlatBufferBuilder builder, int viewcount)
		{
		}

		public static void AddLastviewtime(FlatBufferBuilder builder, long lastviewtime)
		{
		}

		public static Offset<AdsFreeItemData> EndAdsFreeItemData(FlatBufferBuilder builder)
		{
			return default(Offset<AdsFreeItemData>);
		}

		public AdsFreeItemDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(AdsFreeItemDataT _o)
		{
		}

		public static Offset<AdsFreeItemData> Pack(FlatBufferBuilder builder, AdsFreeItemDataT _o)
		{
			return default(Offset<AdsFreeItemData>);
		}
	}
}
