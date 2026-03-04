using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct StageUnitData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public UnitData? Worker { get { int o = __p.__offset(4); return o != 0 ? (new UnitData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public UnitData? Planter { get { int o = __p.__offset(6); return o != 0 ? (new UnitData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static StageUnitData GetRootAsStageUnitData(ByteBuffer _bb)
		{
			return GetRootAsStageUnitData(_bb, new StageUnitData());
		}

		public static StageUnitData GetRootAsStageUnitData(ByteBuffer _bb, StageUnitData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public StageUnitData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public static Offset<StageUnitData> CreateStageUnitData(FlatBufferBuilder builder, Offset<UnitData> workerOffset = default(Offset<UnitData>), Offset<UnitData> planterOffset = default(Offset<UnitData>))
		{
			builder.StartTable(2);
			AddPlanter(builder, planterOffset);
			AddWorker(builder, workerOffset);
			return EndStageUnitData(builder);
		}

		public static void StartStageUnitData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddWorker(FlatBufferBuilder builder, Offset<UnitData> workerOffset)
		{
			builder.AddOffset(0, workerOffset.Value, 0);
		}

		public static void AddPlanter(FlatBufferBuilder builder, Offset<UnitData> planterOffset)
		{
			builder.AddOffset(1, planterOffset.Value, 0);
		}

		public static Offset<StageUnitData> EndStageUnitData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<StageUnitData>(o);
		}

		public StageUnitDataT UnPack()
		{
			var _o = new StageUnitDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(StageUnitDataT _o)
		{
			_o.Worker = this.Worker.HasValue ? this.Worker.Value.UnPack() : null;
			_o.Planter = this.Planter.HasValue ? this.Planter.Value.UnPack() : null;
		}

		public static Offset<StageUnitData> Pack(FlatBufferBuilder builder, StageUnitDataT _o)
		{
			if (_o == null) return default(Offset<StageUnitData>);
			var _worker = _o.Worker == null ? default(Offset<UnitData>) : UnitData.Pack(builder, _o.Worker);
			var _planter = _o.Planter == null ? default(Offset<UnitData>) : UnitData.Pack(builder, _o.Planter);
			StartStageUnitData(builder);
			AddWorker(builder, _worker);
			AddPlanter(builder, _planter);
			return EndStageUnitData(builder);
		}
	}
}
