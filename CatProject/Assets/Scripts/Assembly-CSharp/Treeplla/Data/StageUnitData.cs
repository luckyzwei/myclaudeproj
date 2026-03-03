using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct StageUnitData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public UnitData? Worker => null;

		public UnitData? Planter => null;

		public static void ValidateVersion()
		{
		}

		public static StageUnitData GetRootAsStageUnitData(ByteBuffer _bb)
		{
			return default(StageUnitData);
		}

		public static StageUnitData GetRootAsStageUnitData(ByteBuffer _bb, StageUnitData obj)
		{
			return default(StageUnitData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public StageUnitData __assign(int _i, ByteBuffer _bb)
		{
			return default(StageUnitData);
		}

		public static Offset<StageUnitData> CreateStageUnitData(FlatBufferBuilder builder, Offset<UnitData> workerOffset = default(Offset<UnitData>), Offset<UnitData> planterOffset = default(Offset<UnitData>))
		{
			return default(Offset<StageUnitData>);
		}

		public static void StartStageUnitData(FlatBufferBuilder builder)
		{
		}

		public static void AddWorker(FlatBufferBuilder builder, Offset<UnitData> workerOffset)
		{
		}

		public static void AddPlanter(FlatBufferBuilder builder, Offset<UnitData> planterOffset)
		{
		}

		public static Offset<StageUnitData> EndStageUnitData(FlatBufferBuilder builder)
		{
			return default(Offset<StageUnitData>);
		}

		public StageUnitDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(StageUnitDataT _o)
		{
		}

		public static Offset<StageUnitData> Pack(FlatBufferBuilder builder, StageUnitDataT _o)
		{
			return default(Offset<StageUnitData>);
		}
	}
}
