using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct UnitData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Level => 0;

		public int Count => 0;

		public static void ValidateVersion()
		{
		}

		public static UnitData GetRootAsUnitData(ByteBuffer _bb)
		{
			return default(UnitData);
		}

		public static UnitData GetRootAsUnitData(ByteBuffer _bb, UnitData obj)
		{
			return default(UnitData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public UnitData __assign(int _i, ByteBuffer _bb)
		{
			return default(UnitData);
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateCount(int count)
		{
			return false;
		}

		public static Offset<UnitData> CreateUnitData(FlatBufferBuilder builder, int level = 0, int count = 0)
		{
			return default(Offset<UnitData>);
		}

		public static void StartUnitData(FlatBufferBuilder builder)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddCount(FlatBufferBuilder builder, int count)
		{
		}

		public static Offset<UnitData> EndUnitData(FlatBufferBuilder builder)
		{
			return default(Offset<UnitData>);
		}

		public UnitDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(UnitDataT _o)
		{
		}

		public static Offset<UnitData> Pack(FlatBufferBuilder builder, UnitDataT _o)
		{
			return default(Offset<UnitData>);
		}
	}
}
