using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct EquipCostume : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Head => 0;

		public int Body => 0;

		public int Hand => 0;

		public static void ValidateVersion()
		{
		}

		public static EquipCostume GetRootAsEquipCostume(ByteBuffer _bb)
		{
			return default(EquipCostume);
		}

		public static EquipCostume GetRootAsEquipCostume(ByteBuffer _bb, EquipCostume obj)
		{
			return default(EquipCostume);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public EquipCostume __assign(int _i, ByteBuffer _bb)
		{
			return default(EquipCostume);
		}

		public bool MutateHead(int head)
		{
			return false;
		}

		public bool MutateBody(int body)
		{
			return false;
		}

		public bool MutateHand(int hand)
		{
			return false;
		}

		public static Offset<EquipCostume> CreateEquipCostume(FlatBufferBuilder builder, int head = 0, int body = 0, int hand = 0)
		{
			return default(Offset<EquipCostume>);
		}

		public static void StartEquipCostume(FlatBufferBuilder builder)
		{
		}

		public static void AddHead(FlatBufferBuilder builder, int head)
		{
		}

		public static void AddBody(FlatBufferBuilder builder, int body)
		{
		}

		public static void AddHand(FlatBufferBuilder builder, int hand)
		{
		}

		public static Offset<EquipCostume> EndEquipCostume(FlatBufferBuilder builder)
		{
			return default(Offset<EquipCostume>);
		}

		public EquipCostumeT UnPack()
		{
			return null;
		}

		public void UnPackTo(EquipCostumeT _o)
		{
		}

		public static Offset<EquipCostume> Pack(FlatBufferBuilder builder, EquipCostumeT _o)
		{
			return default(Offset<EquipCostume>);
		}
	}
}
