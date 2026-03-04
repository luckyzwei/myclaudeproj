using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RegionMissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Claimedmilestionecount { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static RegionMissionData GetRootAsRegionMissionData(ByteBuffer _bb)
		{
			return GetRootAsRegionMissionData(_bb, new RegionMissionData());
		}

		public static RegionMissionData GetRootAsRegionMissionData(ByteBuffer _bb, RegionMissionData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public RegionMissionData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateClaimedmilestionecount(int claimedmilestionecount)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, claimedmilestionecount);
				return true;
			}
			return false;
		}

		public static Offset<RegionMissionData> CreateRegionMissionData(FlatBufferBuilder builder, int claimedmilestionecount = -1)
		{
			builder.StartTable(1);
			AddClaimedmilestionecount(builder, claimedmilestionecount);
			return EndRegionMissionData(builder);
		}

		public static void StartRegionMissionData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		public static void AddClaimedmilestionecount(FlatBufferBuilder builder, int claimedmilestionecount)
		{
			builder.AddInt(0, claimedmilestionecount, 0);
		}

		public static Offset<RegionMissionData> EndRegionMissionData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<RegionMissionData>(o);
		}

		public RegionMissionDataT UnPack()
		{
			var _o = new RegionMissionDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(RegionMissionDataT _o)
		{
			_o.Claimedmilestionecount = this.Claimedmilestionecount;
		}

		public static Offset<RegionMissionData> Pack(FlatBufferBuilder builder, RegionMissionDataT _o)
		{
			if (_o == null) return default(Offset<RegionMissionData>);
			StartRegionMissionData(builder);
			AddClaimedmilestionecount(builder, _o.Claimedmilestionecount);
			return EndRegionMissionData(builder);
		}
	}
}
