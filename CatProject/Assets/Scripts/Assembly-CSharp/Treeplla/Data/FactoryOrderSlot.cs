using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FactoryOrderSlot : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Slot => 0;

		public bool Isopen => false;

		public int Orderproduct => 0;

		public int Ordervalue => 0;

		public long Refreshtime => 0L;

		public int Charactericonidx => 0;

		public int Charactertalkidx => 0;

		public static void ValidateVersion()
		{
		}

		public static FactoryOrderSlot GetRootAsFactoryOrderSlot(ByteBuffer _bb)
		{
			return default(FactoryOrderSlot);
		}

		public static FactoryOrderSlot GetRootAsFactoryOrderSlot(ByteBuffer _bb, FactoryOrderSlot obj)
		{
			return default(FactoryOrderSlot);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public FactoryOrderSlot __assign(int _i, ByteBuffer _bb)
		{
			return default(FactoryOrderSlot);
		}

		public bool MutateSlot(int slot)
		{
			return false;
		}

		public bool MutateIsopen(bool isopen)
		{
			return false;
		}

		public bool MutateOrderproduct(int orderproduct)
		{
			return false;
		}

		public bool MutateOrdervalue(int ordervalue)
		{
			return false;
		}

		public bool MutateRefreshtime(long refreshtime)
		{
			return false;
		}

		public bool MutateCharactericonidx(int charactericonidx)
		{
			return false;
		}

		public bool MutateCharactertalkidx(int charactertalkidx)
		{
			return false;
		}

		public static Offset<FactoryOrderSlot> CreateFactoryOrderSlot(FlatBufferBuilder builder, int slot = 0, bool isopen = false, int orderproduct = 0, int ordervalue = 0, long refreshtime = 0L, int charactericonidx = 0, int charactertalkidx = 0)
		{
			return default(Offset<FactoryOrderSlot>);
		}

		public static void StartFactoryOrderSlot(FlatBufferBuilder builder)
		{
		}

		public static void AddSlot(FlatBufferBuilder builder, int slot)
		{
		}

		public static void AddIsopen(FlatBufferBuilder builder, bool isopen)
		{
		}

		public static void AddOrderproduct(FlatBufferBuilder builder, int orderproduct)
		{
		}

		public static void AddOrdervalue(FlatBufferBuilder builder, int ordervalue)
		{
		}

		public static void AddRefreshtime(FlatBufferBuilder builder, long refreshtime)
		{
		}

		public static void AddCharactericonidx(FlatBufferBuilder builder, int charactericonidx)
		{
		}

		public static void AddCharactertalkidx(FlatBufferBuilder builder, int charactertalkidx)
		{
		}

		public static Offset<FactoryOrderSlot> EndFactoryOrderSlot(FlatBufferBuilder builder)
		{
			return default(Offset<FactoryOrderSlot>);
		}

		public FactoryOrderSlotT UnPack()
		{
			return null;
		}

		public void UnPackTo(FactoryOrderSlotT _o)
		{
		}

		public static Offset<FactoryOrderSlot> Pack(FlatBufferBuilder builder, FactoryOrderSlotT _o)
		{
			return default(Offset<FactoryOrderSlot>);
		}
	}
}
