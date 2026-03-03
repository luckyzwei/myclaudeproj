using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ManagerCard : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Cardcount => 0;

		public int Level => 0;

		public bool Isopen => false;

		public static void ValidateVersion()
		{
		}

		public static ManagerCard GetRootAsManagerCard(ByteBuffer _bb)
		{
			return default(ManagerCard);
		}

		public static ManagerCard GetRootAsManagerCard(ByteBuffer _bb, ManagerCard obj)
		{
			return default(ManagerCard);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public ManagerCard __assign(int _i, ByteBuffer _bb)
		{
			return default(ManagerCard);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateCardcount(int cardcount)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateIsopen(bool isopen)
		{
			return false;
		}

		public static Offset<ManagerCard> CreateManagerCard(FlatBufferBuilder builder, int idx = 0, int cardcount = 0, int level = 0, bool isopen = false)
		{
			return default(Offset<ManagerCard>);
		}

		public static void StartManagerCard(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddCardcount(FlatBufferBuilder builder, int cardcount)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddIsopen(FlatBufferBuilder builder, bool isopen)
		{
		}

		public static Offset<ManagerCard> EndManagerCard(FlatBufferBuilder builder)
		{
			return default(Offset<ManagerCard>);
		}

		public ManagerCardT UnPack()
		{
			return null;
		}

		public void UnPackTo(ManagerCardT _o)
		{
		}

		public static Offset<ManagerCard> Pack(FlatBufferBuilder builder, ManagerCardT _o)
		{
			return default(Offset<ManagerCard>);
		}
	}
}
