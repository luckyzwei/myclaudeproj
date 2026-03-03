using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AdsFreeViewData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Itemidx => 0;

		public int Viewcount => 0;

		public long Lastviewtime => 0L;

		public static void ValidateVersion()
		{
		}

		public static AdsFreeViewData GetRootAsAdsFreeViewData(ByteBuffer _bb)
		{
			return default(AdsFreeViewData);
		}

		public static AdsFreeViewData GetRootAsAdsFreeViewData(ByteBuffer _bb, AdsFreeViewData obj)
		{
			return default(AdsFreeViewData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AdsFreeViewData __assign(int _i, ByteBuffer _bb)
		{
			return default(AdsFreeViewData);
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

		public static Offset<AdsFreeViewData> CreateAdsFreeViewData(FlatBufferBuilder builder, int itemidx = 0, int viewcount = 0, long lastviewtime = 0L)
		{
			return default(Offset<AdsFreeViewData>);
		}

		public static void StartAdsFreeViewData(FlatBufferBuilder builder)
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

		public static Offset<AdsFreeViewData> EndAdsFreeViewData(FlatBufferBuilder builder)
		{
			return default(Offset<AdsFreeViewData>);
		}

		public AdsFreeViewDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(AdsFreeViewDataT _o)
		{
		}

		public static Offset<AdsFreeViewData> Pack(FlatBufferBuilder builder, AdsFreeViewDataT _o)
		{
			return default(Offset<AdsFreeViewData>);
		}
	}
}
