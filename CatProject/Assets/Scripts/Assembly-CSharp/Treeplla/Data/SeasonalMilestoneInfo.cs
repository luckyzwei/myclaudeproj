using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalMilestoneInfo : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalMilestoneInfo GetRootAsSeasonalMilestoneInfo(ByteBuffer _bb)
		{
			return GetRootAsSeasonalMilestoneInfo(_bb, new SeasonalMilestoneInfo());
		}

		public static SeasonalMilestoneInfo GetRootAsSeasonalMilestoneInfo(ByteBuffer _bb, SeasonalMilestoneInfo obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalMilestoneInfo __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public static void StartSeasonalMilestoneInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		public static Offset<SeasonalMilestoneInfo> EndSeasonalMilestoneInfo(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalMilestoneInfo>(o);
		}

		public SeasonalMilestoneInfoT UnPack()
		{
			var _o = new SeasonalMilestoneInfoT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalMilestoneInfoT _o)
		{
		}

		public static Offset<SeasonalMilestoneInfo> Pack(FlatBufferBuilder builder, SeasonalMilestoneInfoT _o)
		{
			if (_o == null) return default(Offset<SeasonalMilestoneInfo>);
			StartSeasonalMilestoneInfo(builder);
			return EndSeasonalMilestoneInfo(builder);
		}
	}
}
