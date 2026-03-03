using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FactoryBuilding : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Level => 0;

		public int Makeproduct => 0;

		public long Opencompletetime => 0L;

		public long Batteryuseendtime => 0L;

		public int Usebattery => 0;

		public static void ValidateVersion()
		{
		}

		public static FactoryBuilding GetRootAsFactoryBuilding(ByteBuffer _bb)
		{
			return default(FactoryBuilding);
		}

		public static FactoryBuilding GetRootAsFactoryBuilding(ByteBuffer _bb, FactoryBuilding obj)
		{
			return default(FactoryBuilding);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public FactoryBuilding __assign(int _i, ByteBuffer _bb)
		{
			return default(FactoryBuilding);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateMakeproduct(int makeproduct)
		{
			return false;
		}

		public bool MutateOpencompletetime(long opencompletetime)
		{
			return false;
		}

		public bool MutateBatteryuseendtime(long batteryuseendtime)
		{
			return false;
		}

		public bool MutateUsebattery(int usebattery)
		{
			return false;
		}

		public static Offset<FactoryBuilding> CreateFactoryBuilding(FlatBufferBuilder builder, int idx = 0, int level = 0, int makeproduct = 0, long opencompletetime = 0L, long batteryuseendtime = 0L, int usebattery = -1)
		{
			return default(Offset<FactoryBuilding>);
		}

		public static void StartFactoryBuilding(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddMakeproduct(FlatBufferBuilder builder, int makeproduct)
		{
		}

		public static void AddOpencompletetime(FlatBufferBuilder builder, long opencompletetime)
		{
		}

		public static void AddBatteryuseendtime(FlatBufferBuilder builder, long batteryuseendtime)
		{
		}

		public static void AddUsebattery(FlatBufferBuilder builder, int usebattery)
		{
		}

		public static Offset<FactoryBuilding> EndFactoryBuilding(FlatBufferBuilder builder)
		{
			return default(Offset<FactoryBuilding>);
		}

		public FactoryBuildingT UnPack()
		{
			return null;
		}

		public void UnPackTo(FactoryBuildingT _o)
		{
		}

		public static Offset<FactoryBuilding> Pack(FlatBufferBuilder builder, FactoryBuildingT _o)
		{
			return default(Offset<FactoryBuilding>);
		}
	}
}
